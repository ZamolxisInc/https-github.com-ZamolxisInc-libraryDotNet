namespace libraryDotNet
{
    partial class VeziInchirieri
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.RightClickmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returneazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1087, 490);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // RightClickmenu
            // 
            this.RightClickmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returneazaToolStripMenuItem});
            this.RightClickmenu.Name = "RightClickmenu";
            this.RightClickmenu.Size = new System.Drawing.Size(133, 26);
            // 
            // returneazaToolStripMenuItem
            // 
            this.returneazaToolStripMenuItem.Name = "returneazaToolStripMenuItem";
            this.returneazaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.returneazaToolStripMenuItem.Text = "Returneaza";
            this.returneazaToolStripMenuItem.Click += new System.EventHandler(this.returneazaToolStripMenuItem_Click);
            // 
            // VeziInchirieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 490);
            this.Controls.Add(this.listView1);
            this.Name = "VeziInchirieri";
            this.Text = "VeziInchirieri";
            this.Load += new System.EventHandler(this.VeziInchirieri_Load);
            this.RightClickmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip RightClickmenu;
        private System.Windows.Forms.ToolStripMenuItem returneazaToolStripMenuItem;
    }
}