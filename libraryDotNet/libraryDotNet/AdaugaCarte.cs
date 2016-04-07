using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;


namespace libraryDotNet
{
    public partial class AdaugaCarte : Form
    {
        private DBConnect dbConnect;
        public static bool enull = false;
        public bool salvat = false;



        public AdaugaCarte()
        {
            dbConnect = new DBConnect();
            InitializeComponent();
        }

        private void buttonAdaugaCarte_Click(object sender, EventArgs e)
        {

            if (verificaCampuri() == true)
            {
                //Evita null in baza de date
                if (textAlteInfo.Text == "")
                {
                    textAlteInfo.Text = "Fara detalii";
                }
                //ADAUGA CARTE
                if (dbConnect.AdaugaCarte(textBookID.Text, textTitlu.Text, textAutor.Text, textTotal.Text, textAlteInfo.Text) == true)
                {
                    textBookID.Text = textTitlu.Text = textAutor.Text = textTotal.Text = textAlteInfo.Text = string.Empty;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Cartea nu a putut fi adaugata!");
                }
                
            }
            else
            {
                //Nu are sens pentru ca deja avem verificaCampuri care da erorile
                //MessageBox.Show("A aparut o eroare in validarea campurilor!");
            }
        }


        bool verificaCampuri()
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
            else if (maiExistaCarteaDeja() == true)
            {
                MessageBox.Show("BookID ul este deja existent in baza de date.");
                return false;
            }


            return true;
        }

        public bool maiExistaCarteaDeja()
        {

            int count = dbConnect.getBookIDCount(textBookID.Text);


            if (count == 0)
            {
                return false; ;
            }
            else
            {
                return true;
            }
        }

        private bool IsInt(string sVal)
        {
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            return true;
        }

        private void AdaugaCarte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salvat == false)
            {
                if (textBookID.Text.Length > 0 || textTitlu.Text.Length > 0 || textAutor.Text.Length > 0 || textAlteInfo.Text.Length > 0 || textTotal.Text.Length > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa inchizi? \nToate datele care nu au fost incarcate vor fi pierdute!", "Esti sigur ca vrei sa inchizi?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        e.Cancel = true;
                    }

                }
            }

        }
        private void AdaugaCarte_Load(object sender, EventArgs e)
        {

        }


    }


}