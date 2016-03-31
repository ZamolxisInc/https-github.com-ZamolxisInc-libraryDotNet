using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryDotNet
{
    public partial class CautaCarte : Form
    {
        private string title;
        private string author;
        private string id;

        public CautaCarte(string s1, string s2, string s3)
        {
            InitializeComponent();
            title = s1;
            author = s2;
            id = s3;
            Load += new EventHandler(CautaCarte_Load);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void CautaCarte_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Titlu", 160);
            listView1.Columns.Add("Autor", 160);
            listView1.Columns.Add("Total", 80);
            listView1.Columns.Add("Libere", 80);
            listView1.Columns.Add("Alte informatii", 300);

            SqlConnection cn = new SqlConnection(global::libraryDotNet.Properties.Settings.Default.librarydotnetConnectionString);
            string selStr = "SELECT * FROM books ORDER BY title, author";
            SqlCommand selSql = new SqlCommand(selStr, cn);
            try
            {
                cn.Open();
                SqlDataReader reader = selSql.ExecuteReader();
                int ct = 0;
                bool b1, b2, b3;
                while (reader.Read())
                {
                    b1 = false;
                    b2 = false;
                    b3 = false;
                    if(title != null)
                    {
                        b1 = reader["title"].ToString().ToLower().Contains(title.ToLower());
                    }
                    if(author != null)
                    {
                        b2 = reader["author"].ToString().ToLower().Contains(author.ToLower());
                    }
                    if(id != null)
                    {
                        b3 = reader["bookID"].ToString().ToLower().Contains(id.ToLower());
                    }
                    if( (b1 || title == null) && (b2 || author == null) && (b3 || id == null))
                    {
                        listView1.Items.Add(reader["bookID"].ToString());
                        listView1.Items[ct].SubItems.Add(reader["title"].ToString());
                        listView1.Items[ct].SubItems.Add(reader["author"].ToString());
                        listView1.Items[ct].SubItems.Add(reader["total"].ToString());
                        listView1.Items[ct].SubItems.Add(reader["free"].ToString());
                        listView1.Items[ct].SubItems.Add(reader["details"].ToString());
                        ct++;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
       

    }
}
