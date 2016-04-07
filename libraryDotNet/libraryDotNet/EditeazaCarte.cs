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
    public partial class EditeazaCarte : Form
    {
        private string bookID;
        private string title;
        private string author;
        private string exemplare;
        private string libere;
        private string id;
        private string otherinfo;
        private DBConnect dbConnect;

        public EditeazaCarte(string GETbookID, string GETtitle, string GETauthor, string GETexemplare, string GETlibere, string GETalteInfo)
        {
            InitializeComponent();
            bookID = GETbookID;
            title = GETtitle;
            author = GETauthor;
            exemplare = GETexemplare;
            libere = GETlibere;
            otherinfo = GETalteInfo;
            dbConnect = new DBConnect();
            Load += new EventHandler(EditeazaCarte_Load);
        }

        private void EditeazaCarte_Load(object sender, EventArgs e)
        {
            textBookID.Text = bookID;
            textTitlu.Text = title;
            textAutor.Text = author;
            textTotal.Text = exemplare;
            textLibere.Text = libere;
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
             if( dbConnect.modificaCarte(textBookID.Text,textTitlu.Text,textAutor.Text,textTotal.Text,textLibere.Text, textAlteInfo.Text) == true)
             {
                 this.Close();
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
            if (textBookID.Text.Length != 7)
            {
                MessageBox.Show("BOOKID-ul trebuie sa fie de fix 7 cifre");
                

            }
            else
            {
                //sterge
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi cartea?", "Stergere carte", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   if( dbConnect.StergeCarte(textBookID.Text) == true)
                   {
                       this.Close();
                   }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
           
        }
    }
}
