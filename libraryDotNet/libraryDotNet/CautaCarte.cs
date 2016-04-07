using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace libraryDotNet
{
    public partial class CautaCarte : Form
    {
        private DBConnect dbConnect;
        public string GETbookID;
        public string GETauthor;
        public string GETtitle;


        public CautaCarte(string bookid, string author, string title)
        {
            GETbookID = bookid;
            GETauthor = author;
            GETtitle = title;
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void CautaCarte_Load(object sender, EventArgs e)
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
            list = dbConnect.CautaCarte(GETbookID, GETtitle, GETauthor);


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

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuRightClick.Show(Cursor.Position);
                }
            } 
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem();
            it = listView1.SelectedItems[0];
            EditeazaCarte editForm = new EditeazaCarte(it.SubItems[1].Text, it.SubItems[2].Text, it.SubItems[3].Text, it.SubItems[4].Text, it.SubItems[5].Text, it.SubItems[6].Text);
            editForm.Show();
            
        }

        private void inchiriazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem();
            it = listView1.SelectedItems[0];
            InchiriazaCarte inchiriazaForm = new InchiriazaCarte(it.SubItems[1].Text, it.SubItems[2].Text, it.SubItems[3].Text);
            inchiriazaForm.Show();
        }

        private void veziCineAInchiriatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem();
            it = listView1.SelectedItems[0];
            VeziInchirieri veziinchform = new VeziInchirieri(it.SubItems[1].Text);
            veziinchform.Show();
        }
    }
}
