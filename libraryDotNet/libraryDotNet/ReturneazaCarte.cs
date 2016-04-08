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
        private string bookID;
        private string name;
        private string grade;
  
        public ReturneazaCarte()
        {
            InitializeComponent();
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
                bookID = idText.Text;
                name = nameText.Text;
                grade = gradeText.Text;
                dbconnect.ReturnBook(bookID, name, grade);
                dbconnect.setPlusOneFreeBook(bookID);
                MessageBox.Show("Returnare reusita!");
                this.Close();
            }
        }

        private bool checkText()
        {
            if (gradeText.Text != null && nameText.Text != null && idText != null)
                return true;
            return false;
        }
    }
}
