using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace libraryDotNet
{
    public partial class AdaugaCarte : Form
    {
        public AdaugaCarte()
        {
            InitializeComponent();
        }

        private void buttonAdaugaCarte_Click(object sender, EventArgs e)
        {
            
            if (verificaCampuri() == true)
            {
                //ADAUGA CARTE
                SqlConnectionStringBuilder cstring = new SqlConnectionStringBuilder(global::libraryDotNet.Properties.Settings.Default.librarydotnetConnectionString);
                cstring.AsynchronousProcessing = true;
                SqlConnection cn = new SqlConnection(cstring.ConnectionString);

                try
                {
                    string sql = "INSERT INTO books (bookID, title, author, total, free, details) values(" + textBookID.Text + ",'" +
                                    textTitlu.Text + "','" + textAutor.Text + "'," + textTotal.Text + "," + textTotal.Text + ",'" +
                                    textAlteInfo.Text + "')";
                    SqlCommand execSql = new SqlCommand(sql, cn);
                    cn.Open();
                    execSql.BeginExecuteNonQuery();

                    MessageBox.Show("Adaugare reusita!");
                    textBookID.Text = null;
                    textTitlu.Text = null;
                    textAutor.Text = null;
                    textTotal.Text = null;
                    textAlteInfo.Text = null;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();      
                }
            }
            else
            {
                //MessageBox.Show("A aparut o eroare in validarea campurilor!");
            }
        }


        bool verificaCampuri()
        {
            if (textBookID.Text.Length != 7)
            {
                MessageBox.Show("BOOKID-ul trebuie sa fie de fix 7 cifre");
                return false;

            }
            else if (textTotal.Text.Length > 99 || textTotal.Text.Length < 1)
            {
                MessageBox.Show("Numarul de exemplare nu este valid");
                return false;

            }
            else if (textAlteInfo.Text.Length > 100)
            {
                MessageBox.Show("Prea multe caractere in campul Alte Informatii");
                return false;

            }
            //else if (maiExistaCartea() == true)
            //{
            //    MessageBox.Show("BookID ul este deja existent in baza de date.");
            //   return false;
            //}


            return true;
        }

        private bool maiExistaCartea()
        {
            SqlConnectionStringBuilder cstring = new SqlConnectionStringBuilder(global::libraryDotNet.Properties.Settings.Default.librarydotnetConnectionString);
            cstring.AsynchronousProcessing = true;
            SqlConnection cn = new SqlConnection(cstring.ConnectionString);

            try
            {
                string sql = "SELECT COUNT(bookID) FROM books (bookID) WHERE  bookID = '" + textBookID.Text + "'";
                SqlCommand execSql = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader reader = execSql.ExecuteReader();
                reader.Read();
                int record = reader.GetInt32(0);    // Weight int
                if (record.ToString() == textBookID.ToString())
                {
                    return true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


            return false;
        }

        private bool IsInt(string sVal)
        {
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            return true;
        }

        private void AdaugaCarte_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (textBookID.Text.Length > 0 || textTitlu.Text.Length > 0 || textAutor.Text.Length > 0 || textAlteInfo.Text.Length > 0 || textTotal.Text.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa inchizi? \nToate datele care nu au fost incarcate vor fi pierdute!", "Esti sigur ca vrei sa inchizi?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }

        }

    }
}
