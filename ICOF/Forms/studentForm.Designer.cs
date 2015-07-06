namespace ICOF
{
    partial class studentForm
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
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title_LB = new System.Windows.Forms.Label();
            this.jobYear_TB = new System.Windows.Forms.TextBox();
            this.courseDone_CB = new System.Windows.Forms.ComboBox();
            this.teacherLastname_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teacherFirstname_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modify = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(68, 390);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(523, 31);
            this.clear.TabIndex = 83;
            this.clear.Text = "Effacer le formulaire";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(68, 340);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(523, 43);
            this.add.TabIndex = 82;
            this.add.Text = "Ajouter élève en stage";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Formation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Année stage";
            // 
            // lastName_TB
            // 
            this.lastName_TB.Location = new System.Drawing.Point(331, 116);
            this.lastName_TB.Name = "lastName_TB";
            this.lastName_TB.Size = new System.Drawing.Size(260, 20);
            this.lastName_TB.TabIndex = 2;
            this.lastName_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Prénom";
            // 
            // firstName_TB
            // 
            this.firstName_TB.Location = new System.Drawing.Point(331, 76);
            this.firstName_TB.Name = "firstName_TB";
            this.firstName_TB.Size = new System.Drawing.Size(260, 20);
            this.firstName_TB.TabIndex = 1;
            this.firstName_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-31, -96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nouvelle remarque";
            // 
            // title_LB
            // 
            this.title_LB.AutoSize = true;
            this.title_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_LB.Location = new System.Drawing.Point(62, 18);
            this.title_LB.Name = "title_LB";
            this.title_LB.Size = new System.Drawing.Size(306, 31);
            this.title_LB.TabIndex = 84;
            this.title_LB.Text = "Nouveau élève en stage";
            // 
            // jobYear_TB
            // 
            this.jobYear_TB.Location = new System.Drawing.Point(331, 156);
            this.jobYear_TB.Name = "jobYear_TB";
            this.jobYear_TB.Size = new System.Drawing.Size(260, 20);
            this.jobYear_TB.TabIndex = 3;
            this.jobYear_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // courseDone_CB
            // 
            this.courseDone_CB.FormattingEnabled = true;
            this.courseDone_CB.Location = new System.Drawing.Point(331, 196);
            this.courseDone_CB.Name = "courseDone_CB";
            this.courseDone_CB.Size = new System.Drawing.Size(260, 21);
            this.courseDone_CB.TabIndex = 4;
            // 
            // teacherLastname_TB
            // 
            this.teacherLastname_TB.Location = new System.Drawing.Point(331, 236);
            this.teacherLastname_TB.Name = "teacherLastname_TB";
            this.teacherLastname_TB.Size = new System.Drawing.Size(260, 20);
            this.teacherLastname_TB.TabIndex = 5;
            this.teacherLastname_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Nom maitre d\'apprentissage";
            // 
            // teacherFirstname_TB
            // 
            this.teacherFirstname_TB.Location = new System.Drawing.Point(331, 280);
            this.teacherFirstname_TB.Name = "teacherFirstname_TB";
            this.teacherFirstname_TB.Size = new System.Drawing.Size(260, 20);
            this.teacherFirstname_TB.TabIndex = 6;
            this.teacherFirstname_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Prénom maitre d\'apprentissage";
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.Location = new System.Drawing.Point(68, 340);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(523, 43);
            this.modify.TabIndex = 91;
            this.modify.Text = "Modifier élève en stage";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Visible = false;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(68, 340);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(523, 43);
            this.confirm.TabIndex = 92;
            this.confirm.Text = "Confirmer modifications";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 445);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.teacherFirstname_TB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.teacherLastname_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.courseDone_CB);
            this.Controls.Add(this.jobYear_TB);
            this.Controls.Add(this.title_LB);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "studentForm";
            this.Text = "Ajouter élève en stage";
            this.Leave += new System.EventHandler(this.outControl);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_LB;
        private System.Windows.Forms.TextBox jobYear_TB;
        private System.Windows.Forms.ComboBox courseDone_CB;
        private System.Windows.Forms.TextBox teacherLastname_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teacherFirstname_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button confirm;
    }
}