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
    
    public partial class InchiriazaCarte : Form
    {
        private DBConnect dbConnect;
        private string GbookID;
        private string Gtitle;
        private string Gauthor;

        public InchiriazaCarte()
        {
            dbConnect = new DBConnect();
            InitializeComponent();
        }

        public InchiriazaCarte(string GETbookID, string GETtitle,string GETauthor)
        {

            GbookID = GETbookID;
            Gtitle = GETtitle;
            Gauthor = GETauthor;
            
            dbConnect = new DBConnect();
            InitializeComponent();
        }

        private void buttonInchiriazaCarte_Click(object sender, EventArgs e)
        {
            //verifica anyone left, seteaza rent, scade cu unu bookid ul respectiv
            if(checkFields() == true)
            {
                if(dbConnect.getFreeBooks(textBoxBookID.Text) > 0)
                {
                    rentBook();
                }
                else
                {
                    MessageBox.Show("Nu mai exista exemplare libere pentru aceasta carte!");
                }
            }
            
        }

        private bool checkFields()
        {
            if (textBoxBookID.Text.Length != 7)
            {
                MessageBox.Show("BOOKID-ul trebuie sa fie de fix 7 cifre");
                return false;

            }
            else if (string.IsNullOrEmpty(textBoxNume.Text))
            {
                MessageBox.Show("Campul nume nu este completat ! ");
                return false;

            }
            else if (string.IsNullOrEmpty(textBoxPrenume.Text))
            {
                MessageBox.Show("Campul prenume nu este completat ! ");
                return false;

            }
            else if (string.IsNullOrEmpty(textBoxClasa.Text))
            {
                MessageBox.Show("Campul clasa nu este completat ! ");
                return false;

            }
            else if (carteaExista(textBoxBookID.Text) == false)
            {
                MessageBox.Show("Cartea nu exista in baza de date ! ");
                return false;

            }
      

            return true;
        }

        private void InchiriazaCarte_Load(object sender, EventArgs e)
        {
            textBoxBookID.Text = GbookID;
            label5.Text = "Inchiriaza: ~" + Gtitle + "~ de " + Gauthor;
        }

        public void rentBook()
        {
            if(dbConnect.InchiriazaCarte(textBoxBookID.Text, textBoxNume.Text, textBoxPrenume.Text, textBoxClasa.Text)==true)
            {
                if(dbConnect.setMinusOneFreeBook(textBoxBookID.Text) == true)
                {
                    MessageBox.Show("Cartea a fost inchiriata cu succes!");
                }
                else
                {
                    MessageBox.Show("Cartea nu a fost inchiriata! \nInchirierea a fost adaugata dar numarul de carti libere nu a putut fi modificat\n Va rugam sa modificati numarul de carti libere manual\n pentru a remedia aceasta problema");
                }
            }
            else
            {
                MessageBox.Show("A aparut o eroare si cartea nu a putut fi inchiriata ! ");
            }
        }

        bool carteaExista(string bookID)
        {
            int count = dbConnect.getBookIDCount(bookID);


            if (count > 0)
            {
                return true; ;
            }
            else
            {
                return false;
            }
        }
    }
}
