namespace libraryDotNet
{
    partial class controlPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlPanelForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cautaCarteGroup = new System.Windows.Forms.GroupBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCautaAutor = new System.Windows.Forms.TextBox();
            this.textCautaTitlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCautCarte = new System.Windows.Forms.Button();
            this.buttonInchiriazaCarte = new System.Windows.Forms.Button();
            this.buttonReturneazaCarte = new System.Windows.Forms.Button();
            this.buttonAdaugaCarte = new System.Windows.Forms.Button();
            this.buttonModificaCarte = new System.Windows.Forms.Button();
            this.groupStatistici = new System.Windows.Forms.GroupBox();
            this.trayIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonVeziToateCartile = new System.Windows.Forms.Button();
            this.buttonVeziToateCartileNereturnate = new System.Windows.Forms.Button();
            this.buttonVeziAllRents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cautaCarteGroup.SuspendLayout();
            this.trayIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(841, 532);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(885, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "libraryDotNet v1.0";
            // 
            // cautaCarteGroup
            // 
            this.cautaCarteGroup.Controls.Add(this.textID);
            this.cautaCarteGroup.Controls.Add(this.label4);
            this.cautaCarteGroup.Controls.Add(this.textCautaAutor);
            this.cautaCarteGroup.Controls.Add(this.textCautaTitlu);
            this.cautaCarteGroup.Controls.Add(this.label3);
            this.cautaCarteGroup.Controls.Add(this.label2);
            this.cautaCarteGroup.Controls.Add(this.buttonCautCarte);
            this.cautaCarteGroup.Location = new System.Drawing.Point(12, 12);
            this.cautaCarteGroup.Name = "cautaCarteGroup";
            this.cautaCarteGroup.Size = new System.Drawing.Size(477, 185);
            this.cautaCarteGroup.TabIndex = 2;
            this.cautaCarteGroup.TabStop = false;
            this.cautaCarteGroup.Text = "Cauta carte";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(68, 133);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(214, 20);
            this.textID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // textCautaAutor
            // 
            this.textCautaAutor.Location = new System.Drawing.Point(68, 85);
            this.textCautaAutor.Name = "textCautaAutor";
            this.textCautaAutor.Size = new System.Drawing.Size(214, 20);
            this.textCautaAutor.TabIndex = 4;
            // 
            // textCautaTitlu
            // 
            this.textCautaTitlu.Location = new System.Drawing.Point(68, 42);
            this.textCautaTitlu.Name = "textCautaTitlu";
            this.textCautaTitlu.Size = new System.Drawing.Size(214, 20);
            this.textCautaTitlu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titlu";
            // 
            // buttonCautCarte
            // 
            this.buttonCautCarte.Location = new System.Drawing.Point(330, 63);
            this.buttonCautCarte.Name = "buttonCautCarte";
            this.buttonCautCarte.Size = new System.Drawing.Size(130, 63);
            this.buttonCautCarte.TabIndex = 0;
            this.buttonCautCarte.Text = "Cauta carte";
            this.buttonCautCarte.UseVisualStyleBackColor = true;
            this.buttonCautCarte.Click += new System.EventHandler(this.buttonCautCarte_Click);
            // 
            // buttonInchiriazaCarte
            // 
            this.buttonInchiriazaCarte.Location = new System.Drawing.Point(12, 243);
            this.buttonInchiriazaCarte.Name = "buttonInchiriazaCarte";
            this.buttonInchiriazaCarte.Size = new System.Drawing.Size(169, 71);
            this.buttonInchiriazaCarte.TabIndex = 3;
            this.buttonInchiriazaCarte.Text = "Inchiriza carte";
            this.buttonInchiriazaCarte.UseVisualStyleBackColor = true;
            this.buttonInchiriazaCarte.Click += new System.EventHandler(this.buttonInchiriazaCarte_Click);
            // 
            // buttonReturneazaCarte
            // 
            this.buttonReturneazaCarte.Location = new System.Drawing.Point(12, 320);
            this.buttonReturneazaCarte.Name = "buttonReturneazaCarte";
            this.buttonReturneazaCarte.Size = new System.Drawing.Size(169, 71);
            this.buttonReturneazaCarte.TabIndex = 4;
            this.buttonReturneazaCarte.Text = "Returneaza Carte";
            this.buttonReturneazaCarte.UseVisualStyleBackColor = true;
            this.buttonReturneazaCarte.Click += new System.EventHandler(this.buttonReturneazaCarte_Click);
            // 
            // buttonAdaugaCarte
            // 
            this.buttonAdaugaCarte.Location = new System.Drawing.Point(565, 12);
            this.buttonAdaugaCarte.Name = "buttonAdaugaCarte";
            this.buttonAdaugaCarte.Size = new System.Drawing.Size(169, 71);
            this.buttonAdaugaCarte.TabIndex = 5;
            this.buttonAdaugaCarte.Text = "Adauga carte";
            this.buttonAdaugaCarte.UseVisualStyleBackColor = true;
            this.buttonAdaugaCarte.Click += new System.EventHandler(this.buttonAdaugaCarte_Click);
            // 
            // buttonModificaCarte
            // 
            this.buttonModificaCarte.Location = new System.Drawing.Point(797, 12);
            this.buttonModificaCarte.Name = "buttonModificaCarte";
            this.buttonModificaCarte.Size = new System.Drawing.Size(169, 71);
            this.buttonModificaCarte.TabIndex = 6;
            this.buttonModificaCarte.Text = "Modifica Carte";
            this.buttonModificaCarte.UseVisualStyleBackColor = true;
            this.buttonModificaCarte.Click += new System.EventHandler(this.buttonModificaCarte_Click);
            // 
            // groupStatistici
            // 
            this.groupStatistici.Location = new System.Drawing.Point(220, 243);
            this.groupStatistici.Name = "groupStatistici";
            this.groupStatistici.Size = new System.Drawing.Size(586, 312);
            this.groupStatistici.TabIndex = 7;
            this.groupStatistici.TabStop = false;
            this.groupStatistici.Text = "Statistici";
            // 
            // trayIconMenuStrip
            // 
            this.trayIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayIconMenuStrip.Name = "trayIconMenuStrip";
            this.trayIconMenuStrip.Size = new System.Drawing.Size(108, 70);
            this.trayIconMenuStrip.Text = "libraryDotNet v1.0";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.activeToolStripMenuItem.Text = "Active";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayIconMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "libraryDotNet";
            this.notifyIcon1.Visible = true;
            // 
            // buttonVeziToateCartile
            // 
            this.buttonVeziToateCartile.Location = new System.Drawing.Point(565, 90);
            this.buttonVeziToateCartile.Name = "buttonVeziToateCartile";
            this.buttonVeziToateCartile.Size = new System.Drawing.Size(169, 23);
            this.buttonVeziToateCartile.TabIndex = 8;
            this.buttonVeziToateCartile.Text = "Vezi toate cartile";
            this.buttonVeziToateCartile.UseVisualStyleBackColor = true;
            this.buttonVeziToateCartile.Click += new System.EventHandler(this.buttonVeziToateCartile_Click);
            // 
            // buttonVeziToateCartileNereturnate
            // 
            this.buttonVeziToateCartileNereturnate.Location = new System.Drawing.Point(797, 90);
            this.buttonVeziToateCartileNereturnate.Name = "buttonVeziToateCartileNereturnate";
            this.buttonVeziToateCartileNereturnate.Size = new System.Drawing.Size(169, 23);
            this.buttonVeziToateCartileNereturnate.TabIndex = 9;
            this.buttonVeziToateCartileNereturnate.Text = "Vezi toate cartile nereturnate";
            this.buttonVeziToateCartileNereturnate.UseVisualStyleBackColor = true;
            this.buttonVeziToateCartileNereturnate.Click += new System.EventHandler(this.buttonVeziToateCartileNereturnate_Click);
            // 
            // buttonVeziAllRents
            // 
            this.buttonVeziAllRents.Location = new System.Drawing.Point(797, 119);
            this.buttonVeziAllRents.Name = "buttonVeziAllRents";
            this.buttonVeziAllRents.Size = new System.Drawing.Size(169, 23);
            this.buttonVeziAllRents.TabIndex = 10;
            this.buttonVeziAllRents.Text = "Vezi toate inchirierile";
            this.buttonVeziAllRents.UseVisualStyleBackColor = true;
            this.buttonVeziAllRents.Click += new System.EventHandler(this.buttonVeziAllRents_Click);
            // 
            // controlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 587);
            this.Controls.Add(this.buttonVeziAllRents);
            this.Controls.Add(this.buttonVeziToateCartileNereturnate);
            this.Controls.Add(this.buttonVeziToateCartile);
            this.Controls.Add(this.groupStatistici);
            this.Controls.Add(this.buttonModificaCarte);
            this.Controls.Add(this.buttonAdaugaCarte);
            this.Controls.Add(this.buttonReturneazaCarte);
            this.Controls.Add(this.buttonInchiriazaCarte);
            this.Controls.Add(this.cautaCarteGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "controlPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "libraryDotNet v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.controlPanelForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.controlPanelForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cautaCarteGroup.ResumeLayout(false);
            this.cautaCarteGroup.PerformLayout();
            this.trayIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox cautaCarteGroup;
        private System.Windows.Forms.Button buttonInchiriazaCarte;
        private System.Windows.Forms.Button buttonReturneazaCarte;
        private System.Windows.Forms.Button buttonAdaugaCarte;
        private System.Windows.Forms.Button buttonModificaCarte;
        private System.Windows.Forms.GroupBox groupStatistici;
        private System.Windows.Forms.ContextMenuStrip trayIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textCautaAutor;
        private System.Windows.Forms.TextBox textCautaTitlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCautCarte;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVeziToateCartile;
        private System.Windows.Forms.Button buttonVeziToateCartileNereturnate;
        private System.Windows.Forms.Button buttonVeziAllRents;
    }
}

