namespace libraryDotNet
{
    partial class EditeazaCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditeazaCarte));
            this.textAlteInfo = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textTitlu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBookID = new System.Windows.Forms.TextBox();
            this.buttonSalveazaCarte = new System.Windows.Forms.Button();
            this.buttonStergeCarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAlteInfo
            // 
            this.textAlteInfo.Location = new System.Drawing.Point(89, 157);
            this.textAlteInfo.Name = "textAlteInfo";
            this.textAlteInfo.Size = new System.Drawing.Size(191, 20);
            this.textAlteInfo.TabIndex = 21;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(89, 129);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(191, 20);
            this.textTotal.TabIndex = 20;
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(89, 100);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(191, 20);
            this.textAutor.TabIndex = 19;
            // 
            // textTitlu
            // 
            this.textTitlu.Location = new System.Drawing.Point(89, 68);
            this.textTitlu.Name = "textTitlu";
            this.textTitlu.Size = new System.Drawing.Size(191, 20);
            this.textTitlu.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Alte informatii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Exemplare total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Titlu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "bookID";
            // 
            // textBookID
            // 
            this.textBookID.Location = new System.Drawing.Point(89, 34);
            this.textBookID.Name = "textBookID";
            this.textBookID.Size = new System.Drawing.Size(191, 20);
            this.textBookID.TabIndex = 12;
            this.textBookID.TextChanged += new System.EventHandler(this.textBookID_TextChanged);
            // 
            // buttonSalveazaCarte
            // 
            this.buttonSalveazaCarte.Location = new System.Drawing.Point(409, 34);
            this.buttonSalveazaCarte.Name = "buttonSalveazaCarte";
            this.buttonSalveazaCarte.Size = new System.Drawing.Size(118, 54);
            this.buttonSalveazaCarte.TabIndex = 11;
            this.buttonSalveazaCarte.Text = "Salveaza carte";
            this.buttonSalveazaCarte.UseVisualStyleBackColor = true;
            this.buttonSalveazaCarte.Click += new System.EventHandler(this.buttonSalveazaCarte_Click);
            // 
            // buttonStergeCarte
            // 
            this.buttonStergeCarte.Location = new System.Drawing.Point(409, 119);
            this.buttonStergeCarte.Name = "buttonStergeCarte";
            this.buttonStergeCarte.Size = new System.Drawing.Size(118, 54);
            this.buttonStergeCarte.TabIndex = 22;
            this.buttonStergeCarte.Text = "Sterge carte";
            this.buttonStergeCarte.UseVisualStyleBackColor = true;
            this.buttonStergeCarte.Click += new System.EventHandler(this.buttonStergeCarte_Click);
            // 
            // EditeazaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 205);
            this.Controls.Add(this.buttonStergeCarte);
            this.Controls.Add(this.textAlteInfo);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.textTitlu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBookID);
            this.Controls.Add(this.buttonSalveazaCarte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditeazaCarte";
            this.Text = "EditeazaCarte";
            this.Load += new System.EventHandler(this.EditeazaCarte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAlteInfo;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textTitlu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBookID;
        private System.Windows.Forms.Button buttonSalveazaCarte;
        private System.Windows.Forms.Button buttonStergeCarte;
    }
}