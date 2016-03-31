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
    public partial class ModificaCarte : Form
    {
        public ModificaCarte()
        {
            InitializeComponent();
            Load += new EventHandler(ModificaCarte_Load);
        }

        private void ModificaCarte_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Titlu", 140);
            listView1.Columns.Add("Autor", 140);
            listView1.Columns.Add("Total", 60);
            listView1.Columns.Add("Libere", 60);
            listView1.Columns.Add("Alte informatii", 160);

            SqlConnection cn = new SqlConnection(global::libraryDotNet.Properties.Settings.Default.librarydotnetConnectionString);
            string selStr = "SELECT * FROM books ORDER BY title, author";
            SqlCommand selSql = new SqlCommand(selStr, cn);
            try
            {
                cn.Open();
                SqlDataReader reader = selSql.ExecuteReader();
                int ct = 0;
                while(reader.Read())
                {
                    listView1.Items.Add(reader["bookID"].ToString());
                    listView1.Items[ct].SubItems.Add(reader["title"].ToString());
                    listView1.Items[ct].SubItems.Add(reader["author"].ToString());
                    listView1.Items[ct].SubItems.Add(reader["total"].ToString());
                    listView1.Items[ct].SubItems.Add(reader["free"].ToString());
                    listView1.Items[ct].SubItems.Add(reader["details"].ToString());
                    ct++;
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem it = new ListViewItem();
            it = listView1.SelectedItems[0];
            EditeazaCarte editForm = new EditeazaCarte(it.SubItems[0].Text, it.SubItems[1].Text, it.SubItems[2].Text, it.SubItems[3].Text, it.SubItems[5].Text);
            editForm.Show();
            this.Close();
        }

    }
}
