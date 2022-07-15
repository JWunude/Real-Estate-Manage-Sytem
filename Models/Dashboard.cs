using Lems.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lems.Models
{
    public struct TenantObj
    {
        public string TenantName { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime DofirstPayment { get; set; }
        public DateTime DoNextPayment { get; set; }
        public decimal BalanceAmount { get; set; }
    }

    public class Dashboard : DbConnection
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumberOneBedFlatsVacant { get; private set; }
        public int NumberTwoBedFlatsVacant { get; private set; }
        public int NumberOnebedFlatsOcupied { get; private set; }
        public int NumberTwobedFlatsOcupied { get; private set; }
        public List<KeyValuePair<string,int>>RenTageList { get; private set; }
        public List<TenantObj> AllTenantList { get; private set; }
        public List<TenantObj> TenantOwingtList { get; private set; }

        public object TotalAmountReceived { get; private set; }
        public object TotalAmountOwing { get; private set; }
        public int TotalTwoBedFlats { get; private set; }
        public int TotalOneBedFlats { get; private set; }
        public int TotalselfConFlats { get; private set; }
       
  
        //Constructor
        public Dashboard()
        {

        }


        //Private methods 
        private void GetNumberItems()
        {
            //{ Get total Number of Flats for each category}
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number of Two Bed Room Flats
                    command.CommandText = "SELECT COUNT(PID) FROM AccomodationInfo WHERE ACDescription LIKE '%2 bed room flat%'";
                    TotalTwoBedFlats =(int)command.ExecuteScalar();

                    //Get Total Number of One Bed Room Flats
                    command.CommandText = "SELECT COUNT(PID) FROM AccomodationInfo WHERE ACDescription LIKE '%1 bed room flat%'";
                    TotalOneBedFlats = (int)command.ExecuteScalar();

                    //Get Total Number of Self Contain Room.
                    command.CommandText = "SELECT COUNT(PID) FROM AccomodationInfo WHERE ACDescription LIKE '%self contain%'";
                    TotalselfConFlats = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetAmount()
        {
            //{ Get total Amount Received / Total Amount Owing}
            TotalAmountOwing = 0;
            TotalAmountReceived = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Amount Received Ordered By Date
                    command.CommandText = @"SELECT Sum(AmountPaid) FROM RentageInfo WHERE DateOfFirstPayment BETWEEN @fromDate AND @toDate";
                    
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    TotalAmountReceived = command.ExecuteScalar();

                    //Get Total Amount Owing Ordered By Date
                    command.CommandText = @"SELECT Sum(BalanceAmount) FROM RentageInfo WHERE DateOfFirstPayment BETWEEN @fromDate AND @toDate";
                    TotalAmountOwing = command.ExecuteScalar();
                }
            }
        }
        private void GetRentageList()
        {

            //{ Get Rentage List by Date}
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"SELECT TenantUniqueID, Amountpaid, DateOfFirstPayment,DateDueForNextPayment, BalanceAmount 
                                         FROM manageRentage 
                                         WHERE DateOfFirstPayment BETWEEN @fromDate AND @toDate ORDER BY DateDueForNextPayment";

                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();

                    AllTenantList = new List<TenantObj>();
                    while (reader.Read())
                    {
                        AllTenantList.Add(new TenantObj() { TenantName = reader["TenantUniqueID"].ToString(),
                            AmountPaid = (decimal)reader["Amountpaid"],
                            DofirstPayment = (DateTime)reader["DateOfFirstPayment"],
                            DoNextPayment = (DateTime)reader["DateDueForNextPayment"],
                            BalanceAmount = (decimal)reader["BalanceAmount"],
                        });
                    }
                    reader.Close();


                    //Get Only Tenant that have outstanding bills
                    command.CommandText = @"SELECT TenantUniqueID, Amountpaid, DateOfFirstPayment, DateDueForNextPayment, BalanceAmount
                                         FROM manageRentage 
                                         WHERE DateOfFirstPayment BETWEEN @fromDate AND @toDate AND TenancyStatus = 'NOT-CLEARED'
                                        ORDER BY DateDueForNextPayment";
                    reader = command.ExecuteReader();

                    TenantOwingtList = new List<TenantObj>();
                    while (reader.Read())
                    {
                        TenantOwingtList.Add(new TenantObj()
                        {
                            TenantName = reader["TenantUniqueID"].ToString(),
                            AmountPaid = (decimal)reader["Amountpaid"],
                            DofirstPayment = (DateTime)reader["DateOfFirstPayment"],
                            DoNextPayment = (DateTime)reader["DateDueForNextPayment"],
                            BalanceAmount = (decimal)reader["BalanceAmount"],
                        });
                    }
                    reader.Close();
                }
            }
        }

        //Public Methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);

            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetAmount();
                GetRentageList();
                Console.WriteLine("Refreshed Data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }

        }
    }
}
