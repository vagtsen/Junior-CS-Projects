using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SQLFromConsole
{
    class Program
    {
        static string connectionString =
                @"Server = VAGGOS2-LAPTOP\VAGGOS_SERVER; Database = Database100; Trusted_Connection = True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        static void Main(string[] args)
        {
            using (sqlConnection) // ονομάζεται using Statement ,
            {
                try
                {
                    sqlConnection.Open();

                    //Insert User
                    Console.WriteLine("Enter UserName and Password");
                    string username = Console.ReadLine();
                    string password = Console.ReadLine();

                    SqlCommand cmdInsert = new SqlCommand($"INSERT INTO usersDetailsTable (Name, Password) VALUES('{username}','{password}') ", sqlConnection);
                    int rowsInserted = cmdInsert.ExecuteNonQuery();


                    if (rowsInserted > 0)
                    {
                        Console.WriteLine("Insertion Successful");
                        Console.WriteLine($"{rowsInserted} rows Inserted Successfully");
                    }  

                    //Select 

                    SqlCommand cmdSelect = new SqlCommand("SELECT COUNT (*) FROM usersDetailsTable WHERE Name = @username AND Password = @password", sqlConnection);
                    cmdSelect.Parameters.AddWithValue("@username", "Christos");
                    cmdSelect.Parameters.AddWithValue("@password", "12345");
                    int result = (int)cmdSelect.ExecuteScalar(); // έκανα casting σε integer εφόσον η executeScalar επιστρέφει γενικά object       

                    if (result > 0)
                    {
                        Console.WriteLine("Found User Christos");
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                    }

                    //Login

                    Console.WriteLine("Enter UserName and Password to Login :");

                    string usernameInserted = Console.ReadLine();
                    string passwordInserted = Console.ReadLine();

                    SqlCommand cmdLogin = new SqlCommand($"SELECT ID, Name, Password FROM usersDetailsTable WHERE Name = '{usernameInserted}' AND PASSWORD = '{passwordInserted}'", sqlConnection);
                    SqlDataReader reader = cmdLogin.ExecuteReader();

                    while (reader.Read()) // όσο διαβάζει ο reader 
                    {
                        Console.WriteLine("User Logged In Succesfully");
                        User user = new User();
                        user.ID = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        Console.WriteLine(user);

                        // H Διαφορετικά
                        //Console.WriteLine("ID\tName\tPassword");
                        //Console.WriteLine($"{reader.GetInt32(0)}\t{reader.GetString(1)}\t{reader.GetString(2)}");

                    }
                    reader.Close();

                    //Select Multiple Users 
                    List<User> users = new List<User>();
                    SqlCommand cmdUsers = new SqlCommand($"SELECT ID, Name, Password FROM usersDetailsTable", sqlConnection);
                    SqlDataReader readerUsers = cmdUsers.ExecuteReader();
                    Console.WriteLine("Users : ");

                    while (readerUsers.Read())
                    {
                        User user = new User()
                        {
                            ID = readerUsers.GetInt32(0),
                            Name = readerUsers.GetString(1),
                            Password = readerUsers.GetString(2)
                        };
                        users.Add(user);
                    }

                    foreach (User user in users)
                    {
                        Console.WriteLine(user);
                    }
                    readerUsers.Close();


                    //UPDATE
                    Console.WriteLine("Enter a User for Update");
                    string nameForUpdate = Console.ReadLine();
                    Console.WriteLine("Enter a new Password for User : ");
                    string newPassword = Console.ReadLine();
                    SqlCommand cmdUpdate = new SqlCommand($"UPDATE usersDetailsTable SET Password = '{newPassword}' WHERE Name = '{nameForUpdate}'", sqlConnection);
                    int rowsUpdated = cmdUpdate.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        Console.WriteLine("Updated Successfull");
                        Console.WriteLine($"{rowsUpdated} rows Updated Succesfully ");
                    }

                    //Delete

                    Console.WriteLine("Enter a User to Delete");
                    string nameForDelete = Console.ReadLine();
                  
                    SqlCommand cmdDelete = new SqlCommand($"DELETE usersDetailsTable SET WHERE Name = '{nameForDelete}'", sqlConnection);

                    int rowsDeleted = cmdDelete.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        Console.WriteLine("Updated Successfull");
                        Console.WriteLine($"{rowsDeleted} rows Deleted Succesfully ");
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    //close the connection 
                    sqlConnection.Close();
                    //sqlConnection.Dispose(); // τη χρησιμοποιώ μόνο όταν δεν χρησιμοποιώ το using 
                }

                //sqlConnection.Open();
                ////Insert User
                //Console.WriteLine("Enter UserName and Password");
                //string username = Console.ReadLine();
                //string password = Console.ReadLine();
                //SqlCommand cmdInsert = new SqlCommand($"INSERT INTO usersDetailsTable (Name, Password) VALUES('{username}','{password}') ", sqlConnection);
                //int rowsInserted = cmdInsert.ExecuteNonQuery();
                //if (rowsInserted > 0)
                //{
                //    Console.WriteLine("Insertion Successful");
                //    Console.WriteLine($"{rowsInserted} rows Inserted Successfully");
                //}

            }
        }
    }
}
