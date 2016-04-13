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
    
    public partial class controlPanelForm : Form
    {
        public string version = "1.0";
       
        public controlPanelForm()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Log lg = new Log("Programul a fost pornit!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa iesi? Orice modificare pe care nu ai salvat-o va fi pierduta complet!!!", "Iesire", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
                Log log = new Log("Programul a fost inchis natural din panoul de control. Exit code 0");
                 
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

      

        private void controlPanelForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "libraryDotNet";
                notifyIcon1.BalloonTipText = "Voi ramane aici.";
                notifyIcon1.ShowBalloonTip(1000);
                
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "Bine ai revenit!";
                notifyIcon1.ShowBalloonTip(1000);
                notifyIcon1.Visible = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("libraryDotNet v" + version + " , developed by ZamolxisINC", "Despre aplicatie", 
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
         
        }

        private void buttonAdaugaCarte_Click(object sender, EventArgs e)
        {
            Form adaugaCarte = new AdaugaCarte();
            adaugaCarte.Show();
        }

        private void buttonModificaCarte_Click(object sender, EventArgs e)
        {
            Form modificaCarte = new ModificaCarte();
            modificaCarte.Show();
        }

        private void buttonReturneazaCarte_Click(object sender, EventArgs e)
        {
            Form reutrneazaCarte = new ReturneazaCarte();
            reutrneazaCarte.Show();
        }

        private void buttonCautCarte_Click(object sender, EventArgs e)
        {
            string s1 = null, s2 = null, s3 = null;
            s1 = textCautaTitlu.Text;
            s2 = textCautaAutor.Text;
            s3 = textID.Text;
            if(s1 != "" || s2 != "" || s3 != "")
            {
                 CautaCarte cautaCarteFrm = new CautaCarte(s3, s2, s1);
                 cautaCarteFrm.Show();
            }
            else
            {
                MessageBox.Show("Parametrii de cautare nu pot fi NULI! \nTe rugam sa completezi casutele de cautare cu datele dorite");
            }
           
            
            
        }

        private void controlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa parasesti aplicatia?", "Vrei sa inchizi?", MessageBoxButtons.YesNo);
           
            if (dialogResult == DialogResult.Yes)
            {
               
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonInchiriazaCarte_Click(object sender, EventArgs e)
        {
            InchiriazaCarte ic = new InchiriazaCarte();
            ic.Show();
        }

        private void buttonVeziToateCartile_Click(object sender, EventArgs e)
        {
            CautaCarte cc = new CautaCarte("","","");
            cc.Show();
        }

        private void buttonVeziToateCartileNereturnate_Click(object sender, EventArgs e)
        {
            //rents join cu bookid name title order by bookid
            VeziInchirieri vz = new VeziInchirieri();
            vz.Show();
        }

        private void buttonVeziAllRents_Click(object sender, EventArgs e)
        {
            VeziToateInchirierile vzt = new VeziToateInchirierile();
            vzt.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://zamolxisinc.github.io/Website-1.0/");
        }

        private void controlPanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log lg = new Log("Programul a fost inchis;");
        }
    }
}
