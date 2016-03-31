namespace libraryDotNet
{
    partial class AdaugaCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaCarte));
            this.buttonAdaugaCarte = new System.Windows.Forms.Button();
            this.textBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTitlu = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textAlteInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdaugaCarte
            // 
            this.buttonAdaugaCarte.Location = new System.Drawing.Point(420, 30);
            this.buttonAdaugaCarte.Name = "buttonAdaugaCarte";
            this.buttonAdaugaCarte.Size = new System.Drawing.Size(160, 127);
            this.buttonAdaugaCarte.TabIndex = 0;
            this.buttonAdaugaCarte.Text = "Adauga carte";
            this.buttonAdaugaCarte.UseVisualStyleBackColor = true;
            this.buttonAdaugaCarte.Click += new System.EventHandler(this.buttonAdaugaCarte_Click);
            // 
            // textBookID
            // 
            this.textBookID.Location = new System.Drawing.Point(97, 30);
            this.textBookID.Name = "textBookID";
            this.textBookID.Size = new System.Drawing.Size(191, 20);
            this.textBookID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "bookID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titlu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exemplare total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alte informatii";
            // 
            // textTitlu
            // 
            this.textTitlu.Location = new System.Drawing.Point(97, 64);
            this.textTitlu.Name = "textTitlu";
            this.textTitlu.Size = new System.Drawing.Size(191, 20);
            this.textTitlu.TabIndex = 7;
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(97, 96);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(191, 20);
            this.textAutor.TabIndex = 8;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(97, 125);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(191, 20);
            this.textTotal.TabIndex = 9;
            // 
            // textAlteInfo
            // 
            this.textAlteInfo.Location = new System.Drawing.Point(97, 153);
            this.textAlteInfo.Name = "textAlteInfo";
            this.textAlteInfo.Size = new System.Drawing.Size(191, 20);
            this.textAlteInfo.TabIndex = 10;
            // 
            // AdaugaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 205);
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
            this.Controls.Add(this.buttonAdaugaCarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdaugaCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga Carte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdaugaCarte_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdaugaCarte;
        private System.Windows.Forms.TextBox textBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTitlu;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textAlteInfo;
    }
}