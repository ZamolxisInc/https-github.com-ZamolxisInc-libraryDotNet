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
                Log lg = new Log("Conectat cu succes la baza de date");
                return true;
            }
            catch (MySqlException ex)
            {

                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Imposibil de conectat la baza de date");
                        Log lg = new Log("Imposibil de conectat la baza de date");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        Log lg2 = new Log("Uss/Psw pentru baza de date sunt incorecte");
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
                Log lg = new Log("Conexiunea cu baza de date a fost inchisa cu succes");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Log lg = new Log(ex.Message.ToString());
                return false;
            }
        }


        public bool AdaugaCarte(string bookID, string title, string author, string total, string details)
        {
            int LocalEntryID = entryIdGenerator();
            string query = "INSERT INTO books (entryID, bookID, title, author, total, free, details) VALUES('" + LocalEntryID + "', '" + bookID + "', '" + title + "', '" + author + "', '" + total + "', '" + total + "', '" + details + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                Log lg = new Log("O carte a fost adaugata cu succes: entryID:" + LocalEntryID + ";bookId:" + bookID + ";title:" + title + ";author:" + author + ";total:" + total + ";details:" + details + ";");
                this.CloseConnection();
                MessageBox.Show("Cartea a fost adaugata cu succes!");
                 return true;

            }
            Log lg2 = new Log("O carte NU fost adaugata cu succes: entryID:" + LocalEntryID + ";bookId:" + bookID + ";title:" + title + ";author:" + author + ";total:" + total + ";details:" + details + ";");
               
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
                
                Log lg = new Log("O carte a fost inchiriata cu succes: bookId:" + bookID + ";nume:" + nume + ";prenume:" + prenume + ";clasa:" + clasa + ";");
                this.CloseConnection();
                return true;

            }
            Log lg2 = new Log("O carte NU a fost inchiriata cu succes: bookId:" + bookID + ";nume:" + nume + ";prenume:" + prenume + ";clasa:" + clasa + ";");
               
            return false;
        }

        public bool ReturnBook(string bookID, string nume, string clasa)
        {
            string query = "UPDATE rents SET returned='1', backDate = date(now()) WHERE bookID = '" + bookID + "' AND nume LIKE '%" + nume + "%' AND clasa LIKE '%" + clasa + "%'";
            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                
                Log lg = new Log("O carte a fost returnata cu succes: bookId:" + bookID + ";nume:" + nume + ";clasa:" + clasa + ";");
                this.CloseConnection();
                return true;
            }
            Log lg2 = new Log("O carte NU a fost returnata cu succes: bookId:" + bookID + ";nume:" + nume + ";clasa:" + clasa + ";");
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
               
                Log lg = new Log("Numar de carti libere a scazut cu una pentru: bookId:" + bookID + ";");
                this.CloseConnection();
                return true;

            }
            return false;
            Log lg2 = new Log("Numar de carti libere NU a scazut cu una pentru: bookId:" + bookID + ";");
        }

        public bool setPlusOneFreeBook(string bookID)
        {

            string query = "UPDATE books SET free=free+1 WHERE bookID = '" + bookID + "'";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
               
                Log lg = new Log("Numar de carti libere a crescut cu una pentru: bookId:" + bookID + ";");
                this.CloseConnection();
                return true;

            }
            Log lg2 = new Log("Numar de carti libere NU a crescut cu una pentru: bookId:" + bookID + ";");
            
            return false;
        }


        public bool StergeCarte(string bookID)
        {
            string query = "DELETE FROM books WHERE bookID='"+bookID+"'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Cartea a fost stearsa cu succes!");
                Log lg = new Log("Cartea a fost stearsa: bookId:" + bookID + ";");
                this.CloseConnection();
                return true;
            }
            Log lg2 = new Log("Cartea NU a fost stearsa: bookId:" + bookID + ";");
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
                    Log lg = new Log("S-au afisat toate cartile;");
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
                Log lg = new Log("S-a cautat cartea: bookid:" + bookID + ";title:" + title + ";author:" + author + ";");
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
                Log lg = new Log("S-au afisat cartile inchiriate pentu bookId:" + bookID + ";");
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
                Log lg = new Log("S-au afisat toate cartile inchiriate;");
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
                Log lg = new Log("O carte a fost modificata cu succes bookId:" + bookID + ";title:" + title + ";author:" + author + ";total:" + total + ";details:" + details + ";");
                
                //close connection
                this.CloseConnection();
                MessageBox.Show("Cartea a fost modificata cu succes!");
                
                return true;
            }
            Log lg2 = new Log("O carte NU a fost modificata cu succes bookId:" + bookID + ";title:" + title + ";author:" + author + ";total:" + total + ";details:" + details + ";");
                
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
                Log lg = new Log("S-a generat maxEntryID+1=" + (Count + 1).ToString() + ";");
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
                Log lg = new Log("S-a verificat daca exista bookid:" + bookID +";count:"+Count+";");
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
                Log lg = new Log("S-a verificat numarul de carti libere pentru bookid:" + bookID + ";count:" + Count + ";");
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



        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "/" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!" + ex.Message.ToString());
            }
        }

    }
}
