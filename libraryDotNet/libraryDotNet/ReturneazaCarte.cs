using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace libraryDotNet
{
    public partial class ReturneazaCarte : Form
    {
        private DBConnect dbconnect;
     
        public ReturneazaCarte()
        {
            InitializeComponent();
            dbconnect = new DBConnect();
        }
        public ReturneazaCarte(string GETbookID, string GETname, string GETgrade)
        {
           
            InitializeComponent();
            idText.Text = GETbookID;
            nameText.Text = GETname;
            gradeText.Text = GETgrade;
            dbconnect = new DBConnect();
        }


        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            if (!checkText())
            {
                MessageBox.Show("Nu ati completat toate informatiile");
            }
            else
            {
               
                if (dbconnect.ReturnBook(idText.Text, nameText.Text, gradeText.Text) == true)
                {
                    if (dbconnect.setPlusOneFreeBook(idText.Text) == true)
                    {
                        MessageBox.Show("Returnare reusita!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cartea a fost setata returnata dar numarul nou de carti libere (+1) nu a putut fi modificat\nVa rugam sa il modificati manual din editare carte!");
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Returnarea nu a putut fi realizata!");
                }
                
                
            }
        }

        private bool checkText()
        {
            if (idText.Text.Length != 7)
            {
                MessageBox.Show("BOOKID-ul trebuie sa fie de fix 7 cifre");
                return false;

            }
            else if (string.IsNullOrEmpty(nameText.Text))
            {
                MessageBox.Show("Campul nume nu este completat ! ");
                return false;

            }
            else if (string.IsNullOrEmpty(gradeText.Text))
            {
                MessageBox.Show("Campul clasa nu este completat ! ");
                return false;

            }
           


            return true;
        }
    }
}
