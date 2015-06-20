namespace ICOF
{
    partial class addContactForm
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
            this.de_contacteTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a_contacteTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDP = new System.Windows.Forms.DateTimePicker();
            this.objetTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notesTB = new System.Windows.Forms.TextBox();
            this.effacer = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // de_contacteTB
            // 
            this.de_contacteTB.Location = new System.Drawing.Point(157, 74);
            this.de_contacteTB.Name = "de_contacteTB";
            this.de_contacteTB.Size = new System.Drawing.Size(260, 20);
            this.de_contacteTB.TabIndex = 24;
            this.de_contacteTB.Leave += new System.EventHandler(this.outControl);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "De";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nouvelle remarque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "A";
            // 
            // a_contacteTB
            // 
            this.a_contacteTB.Location = new System.Drawing.Point(157, 114);
            this.a_contacteTB.Name = "a_contacteTB";
            this.a_contacteTB.Size = new System.Drawing.Size(260, 20);
            this.a_contacteTB.TabIndex = 28;
            this.a_contacteTB.Leave += new System.EventHandler(this.outControl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Date";
            // 
            // dateDP
            // 
            this.dateDP.Location = new System.Drawing.Point(157, 154);
            this.dateDP.Name = "dateDP";
            this.dateDP.Size = new System.Drawing.Size(260, 20);
            this.dateDP.TabIndex = 30;
            // 
            // objetTB
            // 
            this.objetTB.Location = new System.Drawing.Point(157, 194);
            this.objetTB.Name = "objetTB";
            this.objetTB.Size = new System.Drawing.Size(260, 20);
            this.objetTB.TabIndex = 32;
            this.objetTB.Leave += new System.EventHandler(this.outControl);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Objet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Notes";
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(157, 233);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(260, 153);
            this.notesTB.TabIndex = 34;
            // 
            // effacer
            // 
            this.effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacer.Location = new System.Drawing.Point(157, 451);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(260, 31);
            this.effacer.TabIndex = 70;
            this.effacer.Text = "Effacer le formulaire";
            this.effacer.UseVisualStyleBackColor = true;
            this.effacer.Click += new System.EventHandler(this.clearContact);
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(157, 401);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(260, 43);
            this.ajouter.TabIndex = 69;
            this.ajouter.Text = "Ajouter remarque";
            this.ajouter.UseVisualStyleBackColor = true;
            // 
            // addContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(518, 498);
            this.Controls.Add(this.effacer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.objetTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a_contacteTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.de_contacteTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addContactForm";
            this.Text = "Nouvelle remarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox de_contacteTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox a_contacteTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDP;
        private System.Windows.Forms.TextBox objetTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.Button effacer;
        private System.Windows.Forms.Button ajouter;
    }
}