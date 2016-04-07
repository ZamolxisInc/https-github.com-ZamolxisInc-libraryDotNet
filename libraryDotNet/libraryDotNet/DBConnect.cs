using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace libraryDotNet
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "localhost";
            database = "librarynet";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool AdaugaCarte(string bookID, string title, string author, string total, string details)
        {
            int LocalEntryID = entryIdGenerator();
            string query = "INSERT INTO books (entryID, bookID, title, author, total, free, details) VALUES('"+LocalEntryID+"', '" + bookID + "', '" + title + "', '" + author + "', '" + total + "', '" + total + "', '" + details + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
                MessageBox.Show("Cartea a fost adaugata cu succes!");
                return true;

            }
            return false;
        }


        public bool InchiriazaCarte(string bookID, string nume, string prenume, string clasa)
        {

            string query = "INSERT INTO rents (bookID, nume, prenume, clasa, rentDate, returned) VALUES('" + bookID + "', '" + nume + "', '" + prenume + "', '" + clasa + "', date(now()), '0')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            
                return true;

            }
            return false;
        }
        public bool setMinusOneFreeBook(string bookID)
        {

            string query = "UPDATE books SET free=free-1 WHERE bookID = '"+bookID+"'";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
         
                return true;

            }
            return false;
        }



        public bool StergeCarte(string bookID)
        {
            string query = "DELETE FROM books WHERE bookID='"+bookID+"'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                MessageBox.Show("Cartea a fost stearsa cu succes!");
                return true;
            }
            return false;
        }


        //Select statement
        public List<string>[] SelectAllBooks()
        {
            string query = "SELECT * FROM books";

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["entryID"] + "");
                    list[1].Add(dataReader["bookID"] + "");
                    list[2].Add(dataReader["title"] + "");
                    list[3].Add(dataReader["author"] + "");
                    list[4].Add(dataReader["total"] + "");
                    list[5].Add(dataReader["free"] + "");
                    list[6].Add(dataReader["details"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }



        public List<string>[] CautaCarte(string bookID, string title, string author)
        {
            string query = "SELECT * FROM books WHERE (bookID LIKE '%"+bookID+"%' OR title LIKE '%"+title+"%' OR author LIKE '%"+author+"%')";

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["entryID"] + "");
                    list[1].Add(dataReader["bookID"] + "");
                    list[2].Add(dataReader["title"] + "");
                    list[3].Add(dataReader["author"] + "");
                    list[4].Add(dataReader["total"] + "");
                    list[5].Add(dataReader["free"] + "");
                    list[6].Add(dataReader["details"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }


        public List<string>[] CartiInchiriate(string bookID)
        {
            string query = "SELECT * FROM rents RIGHT OUTER JOIN books ON rents.bookID = books.bookID WHERE (rents.bookID LIKE '%"+bookID+"%' AND rents.returned = '0') ORDER BY books.bookID";

            //Create a list to store the result
            List<string>[] list = new List<string>[14];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();
            list[13] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["bookID"] + "");
                    list[1].Add(dataReader["nume"] + "");
                    list[2].Add(dataReader["prenume"] + "");
                    list[3].Add(dataReader["clasa"] + "");
                    list[4].Add(dataReader["rentDate"] + "");
                    list[5].Add(dataReader["backDate"] + "");
                    list[6].Add(dataReader["returned"] + "");
                    list[7].Add(dataReader["entryID"] + "");
                    list[8].Add(dataReader["bookID"] + "");
                    list[9].Add(dataReader["title"] + "");
                    list[10].Add(dataReader["author"] + "");
                    list[11].Add(dataReader["total"] + "");
                    list[12].Add(dataReader["free"] + "");
                    list[13].Add(dataReader["details"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] ToateCartileInchiriate()
        {
            string query = "SELECT * FROM rents RIGHT OUTER JOIN books ON rents.bookID = books.bookID WHERE (rents.bookID IS NOT NULL) ORDER BY backDate DESC";

            //Create a list to store the result
            List<string>[] list = new List<string>[14];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();
            list[9] = new List<string>();
            list[10] = new List<string>();
            list[11] = new List<string>();
            list[12] = new List<string>();
            list[13] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["bookID"] + "");
                    list[1].Add(dataReader["nume"] + "");
                    list[2].Add(dataReader["prenume"] + "");
                    list[3].Add(dataReader["clasa"] + "");
                    list[4].Add(dataReader["rentDate"] + "");
                    list[5].Add(dataReader["backDate"] + "");
                    list[6].Add(dataReader["returned"] + "");
                    list[7].Add(dataReader["entryID"] + "");
                    list[8].Add(dataReader["bookID"] + "");
                    list[9].Add(dataReader["title"] + "");
                    list[10].Add(dataReader["author"] + "");
                    list[11].Add(dataReader["total"] + "");
                    list[12].Add(dataReader["free"] + "");
                    list[13].Add(dataReader["details"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }


        public bool modificaCarte(string bookID, string title, string author, string total, string free, string details)
        {
            string query = "UPDATE books SET title='"+title+"', author='"+author+"', total='"+total+"', free='"+free+"', details='"+details+"' WHERE bookID='"+bookID+"'";
            
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
                MessageBox.Show("Cartea a fost modificata cu succes!");
                return true;
            }
            return false;
        }


        public int entryIdGenerator()
        {
            string query = "SELECT MAX(entryID) FROM books";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count + 1;
            }
            else
            {
                MessageBox.Show("This should never happen! / entryIdgenerator");
                return 0;
            }
        }


        public int getBookIDCount(string bookID)
        {
            string query = "SELECT COUNT(*) FROM books WHERE bookID = '"+bookID+"'";
            int Count;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                MessageBox.Show("This should never happen! / getBOOKIDCOUNT");
                return -1;
            }
        }


        public int getFreeBooks(string bookID)
        {
            string query = "SELECT free FROM books WHERE bookID = '" + bookID + "'";
            int Count;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                MessageBox.Show("This should never happen! / getBOOKIDCOUNT");
                return -1;
            }
        }

    }
}
