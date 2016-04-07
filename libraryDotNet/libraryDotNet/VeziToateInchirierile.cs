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
    public partial class VeziToateInchirierile : Form
    {
        private DBConnect dbConnect;
        public VeziToateInchirierile()
        {
            dbConnect = new DBConnect();
            InitializeComponent();
        }

        private void VeziToateInchirierile_Load(object sender, EventArgs e)
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
            listView1.Columns.Add("DataRetur", 85);
            listView1.Columns.Add("Returnata", 85);
   
            

            //
            List<string>[] list;
            list = dbConnect.ToateCartileInchiriate();

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
                listView1.Items[i].SubItems.Add(list[5][i].ToString());
                listView1.Items[i].SubItems.Add(list[6][i].ToString());
                
                
            }
        }
        }
    }

