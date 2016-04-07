using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryDotNet
{
    public partial class VeziInchirieri : Form
    {
        public string GbookID;
        private DBConnect dbConnect;
        public VeziInchirieri()
        {
            GbookID = "";
            InitializeComponent();
            dbConnect = new DBConnect();
        }
        public VeziInchirieri(string GETbookID)
        {
            GbookID = GETbookID;
            InitializeComponent();
            dbConnect = new DBConnect();
        }

        private void VeziInchirieri_Load(object sender, EventArgs e)
        {
            //header
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Nr ordine", 60);
            listView1.Columns.Add("bookID", 80);
            listView1.Columns.Add("Titlu", 210);
            listView1.Columns.Add("Autor", 190);
            listView1.Columns.Add("Nume", 85);
            listView1.Columns.Add("Prenume", 85);
            listView1.Columns.Add("Clasa", 85);
            listView1.Columns.Add("DataInchi", 85);
   
            

            //
            List<string>[] list;
            list = dbConnect.CartiInchiriate(GbookID);

            for (int i = 0; i < list[0].Count; i++)
            {
                listView1.Items.Add(list[7][i].ToString());
                listView1.Items[i].SubItems.Add(list[0][i].ToString());
                listView1.Items[i].SubItems.Add(list[9][i].ToString());
                listView1.Items[i].SubItems.Add(list[10][i].ToString());
                listView1.Items[i].SubItems.Add(list[1][i].ToString());
                listView1.Items[i].SubItems.Add(list[2][i].ToString());
                listView1.Items[i].SubItems.Add(list[3][i].ToString());
                listView1.Items[i].SubItems.Add(list[4][i].ToString());
                
                
            }
        }

        private void returneazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //the code for return
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    RightClickmenu.Show(Cursor.Position);
                }
            } 
        }

    }
}
