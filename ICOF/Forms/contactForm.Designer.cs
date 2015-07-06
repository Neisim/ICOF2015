namespace ICOF.Forms
{
    partial class contactForm
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
            this.post_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phone_TB = new System.Windows.Forms.TextBox();
            this.title_LB = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_TB = new System.Windows.Forms.TextBox();
            this.modify = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // post_TB
            // 
            this.post_TB.Location = new System.Drawing.Point(286, 236);
            this.post_TB.Name = "post_TB";
            this.post_TB.Size = new System.Drawing.Size(260, 20);
            this.post_TB.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "Poste entreprise";
            // 
            // phone_TB
            // 
            this.phone_TB.Location = new System.Drawing.Point(286, 156);
            this.phone_TB.Name = "phone_TB";
            this.phone_TB.Size = new System.Drawing.Size(260, 20);
            this.phone_TB.TabIndex = 98;
            this.phone_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // title_LB
            // 
            this.title_LB.AutoSize = true;
            this.title_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_LB.Location = new System.Drawing.Point(61, 18);
            this.title_LB.Name = "title_LB";
            this.title_LB.Size = new System.Drawing.Size(219, 31);
            this.title_LB.TabIndex = 97;
            this.title_LB.Text = "Nouveau contact";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(65, 336);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(481, 31);
            this.clear.TabIndex = 96;
            this.clear.Text = "Effacer le formulaire";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(65, 286);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(481, 43);
            this.add.TabIndex = 95;
            this.add.Text = "Ajouter contacte";
            this.add.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Ligne directe";
            // 
            // firstName_TB
            // 
            this.firstName_TB.Location = new System.Drawing.Point(286, 116);
            this.firstName_TB.Name = "firstName_TB";
            this.firstName_TB.Size = new System.Drawing.Size(260, 20);
            this.firstName_TB.TabIndex = 92;
            this.firstName_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Prénom";
            // 
            // lastName_TB
            // 
            this.lastName_TB.Location = new System.Drawing.Point(286, 76);
            this.lastName_TB.Name = "lastName_TB";
            this.lastName_TB.Size = new System.Drawing.Size(260, 20);
            this.lastName_TB.TabIndex = 89;
            this.lastName_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Nom";
            // 
            // email_TB
            // 
            this.email_TB.Location = new System.Drawing.Point(286, 196);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(260, 20);
            this.email_TB.TabIndex = 102;
            this.email_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.Location = new System.Drawing.Point(65, 286);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(481, 43);
            this.modify.TabIndex = 104;
            this.modify.Text = "Modifier _contact";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(65, 286);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(481, 43);
            this.confirm.TabIndex = 105;
            this.confirm.Text = "Confirmer modifications";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // contactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 396);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.email_TB);
            this.Controls.Add(this.post_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone_TB);
            this.Controls.Add(this.title_LB);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName_TB);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "contactForm";
            this.Text = "Ajouter contacte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox post_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone_TB;
        private System.Windows.Forms.Label title_LB;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstName_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_TB;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button confirm;

    }
}