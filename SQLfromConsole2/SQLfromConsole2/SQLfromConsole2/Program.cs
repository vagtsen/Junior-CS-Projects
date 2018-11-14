using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLfromConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            string provider = ConfigurationManager.AppSettings["provider"];

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection dbconnection = factory.CreateConnection())
            {
                if (dbconnection == null)
                {
                    System.Console.WriteLine("Connection Error");
                    return;
                }

                try
                {
                    dbconnection.ConnectionString = connectionString;
                    dbconnection.Open();

                    DbCommand command = factory.CreateCommand();
                    command.Connection = dbconnection;
                    command.CommandText = "SELECT ID, Name, Password FROM usersDetailsTable";

                    using(DbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            System.Console.WriteLine($"{dataReader["ID"]} {dataReader["Name"]} {dataReader["Password"]}");
                        }
                    }
                }
                catch(SystemException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    dbconnection.Close();
                }
            }
        }
    }
}
