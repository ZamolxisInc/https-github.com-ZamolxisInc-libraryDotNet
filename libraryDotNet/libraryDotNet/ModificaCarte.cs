using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;




namespace libraryDotNet
{
    public partial class ModificaCarte : Form
    {
        
        private DBConnect dbConnect;
        public ModificaCarte()
        {
            InitializeComponent();
            Load += new EventHandler(ModificaCarte_Load);
            dbConnect = new DBConnect();
        }

        private void ModificaCarte_Load(object sender, EventArgs e)
        {


            //header
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nr ordine", 60);
            listView1.Columns.Add("bookID", 80);
            listView1.Columns.Add("Titlu", 210);
            listView1.Columns.Add("Autor", 190);
            listView1.Columns.Add("Total", 60);
            listView1.Columns.Add("Libere", 60);
            listView1.Columns.Add("Detalii", 85);

            //

            List<string>[] list;
            list = dbConnect.SelectAllBooks();

           
            for (int i = 0; i < list[0].Count; i++)
            {
                listView1.Items.Add(list[0][i].ToString());
                listView1.Items[i].SubItems.Add(list[1][i].ToString());
                listView1.Items[i].SubItems.Add(list[2][i].ToString());
                listView1.Items[i].SubItems.Add(list[3][i].ToString());
                listView1.Items[i].SubItems.Add(list[4][i].ToString());
                listView1.Items[i].SubItems.Add(list[5][i].ToString());
                listView1.Items[i].SubItems.Add(list[6][i].ToString());
                /*
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list[1][i];
                dgDisplay.Rows[number].Cells[2].Value = list[2][i];
                dgDisplay.Rows[number].Cells[3].Value = list[3][i];
                dgDisplay.Rows[number].Cells[4].Value = list[4][i];
                dgDisplay.Rows[number].Cells[5].Value = list[5][i];
                dgDisplay.Rows[number].Cells[6].Value = list[6][i];
                 * */
            }
           
            
        }






        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem it = new ListViewItem();
            it = listView1.SelectedItems[0];
            EditeazaCarte editForm = new EditeazaCarte(it.SubItems[1].Text, it.SubItems[2].Text, it.SubItems[3].Text, it.SubItems[4].Text,it.SubItems[5].Text, it.SubItems[6].Text);
            editForm.Show();
            this.Close();
        }



      

    }
}
