namespace libraryDotNet
{
    partial class CautaCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CautaCarte));
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchiriazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziCineAInchiriatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(940, 488);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // contextMenuRightClick
            // 
            this.contextMenuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.inchiriazaToolStripMenuItem,
            this.veziCineAInchiriatToolStripMenuItem});
            this.contextMenuRightClick.Name = "contextMenuRightClick";
            this.contextMenuRightClick.Size = new System.Drawing.Size(175, 70);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // inchiriazaToolStripMenuItem
            // 
            this.inchiriazaToolStripMenuItem.Name = "inchiriazaToolStripMenuItem";
            this.inchiriazaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.inchiriazaToolStripMenuItem.Text = "Inchiriaza";
            this.inchiriazaToolStripMenuItem.Click += new System.EventHandler(this.inchiriazaToolStripMenuItem_Click);
            // 
            // veziCineAInchiriatToolStripMenuItem
            // 
            this.veziCineAInchiriatToolStripMenuItem.Name = "veziCineAInchiriatToolStripMenuItem";
            this.veziCineAInchiriatToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.veziCineAInchiriatToolStripMenuItem.Text = "Vezi cine a inchiriat";
            this.veziCineAInchiriatToolStripMenuItem.Click += new System.EventHandler(this.veziCineAInchiriatToolStripMenuItem_Click);
            // 
            // CautaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 488);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CautaCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CautaCarte";
            this.Load += new System.EventHandler(this.CautaCarte_Load);
            this.contextMenuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuRightClick;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchiriazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziCineAInchiriatToolStripMenuItem;
    }
}