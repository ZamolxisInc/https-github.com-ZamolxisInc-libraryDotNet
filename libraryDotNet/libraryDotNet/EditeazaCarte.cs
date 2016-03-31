using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace libraryDotNet
{
    public partial class EditeazaCarte : Form
    {
        private string bookID;
        private string title;
        private string author;
        private string exemplare;
        private string id;
        private string otherinfo;
        

        public EditeazaCarte(string s0, string s1, string s2, string s3, string s4)
        {
            InitializeComponent();
            bookID = s0;
            title = s1;
            author = s2;
            exemplare = s3;
            otherinfo = s4;

            Load += new EventHandler(EditeazaCarte_Load);
        }

        private void EditeazaCarte_Load(object sender, EventArgs e)
        {
            textBookID.Text = bookID;
            textTitlu.Text = title;
            textAutor.Text = author;
            textTotal.Text = exemplare;
            textAlteInfo.Text = otherinfo;

        }

        private void textBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalveazaCarte_Click(object sender, EventArgs e)
        {
            if (checkFields() == true)
            {
                //EDITEAZA CARTE
                SqlConnectionStringBuilder cstring = new SqlConnectionStringBuilder(global::libraryDotNet.Properties.Settings.Default.librarydotnetConnectionString);
                cstring.AsynchronousProcessing = true;
                SqlConnection cn = new SqlConnection(cstring.ConnectionString);

                try
                {
                    string sql = "UPDATE books SET bookID = " + textBookID.Text + ", title = '" +
                                    textTitlu.Text + "', author = '" + textAutor.Text + "', total = " + textTotal.Text + ", free = " + textTotal.Text + ", details = '" +
                                    textAlteInfo.Text + "' WHERE bookID = " + bookID;
                    SqlCommand execSql = new SqlCommand(sql, cn);
                    cn.Open();
                    execSql.BeginExecuteNonQuery();

                    MessageBox.Show("Salvare reusita!");
                    textBookID.Text = null;
                    textTitlu.Text = null;
                    textAutor.Text = null;
                    textTotal.Text = null;
                    textAlteInfo.Text = null;
                    this.Close();
                    ModificaCarte modifForm = new ModificaCarte();
                    modifForm.Show();

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

        private bool checkFields()
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
            return true;
        }

        private void buttonStergeCarte_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cstring = new SqlConnectionStringBuilder(global::libraryDotNet.Properties.Settings.Default.librarydotnetConnectionString);
            cstring.AsynchronousProcessing = true;
            SqlConnection cn = new SqlConnection(cstring.ConnectionString);

            try
            {
                string sql = "DELETE FROM books WHERE bookID = " + bookID;
                SqlCommand execSql = new SqlCommand(sql, cn);
                cn.Open();
                execSql.BeginExecuteNonQuery();

                MessageBox.Show("Stergere reusita!");
                textBookID.Text = null;
                textTitlu.Text = null;
                textAutor.Text = null;
                textTotal.Text = null;
                textAlteInfo.Text = null;
                this.Close();
                ModificaCarte modifForm = new ModificaCarte();
                modifForm.Show();

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
    }
}
