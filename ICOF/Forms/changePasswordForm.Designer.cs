namespace ICOF
{
    partial class changePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePasswordForm));
            this.change = new System.Windows.Forms.Button();
            this.repasswordTB = new System.Windows.Forms.TextBox();
            this.newpasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(70, 149);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(458, 43);
            this.change.TabIndex = 24;
            this.change.Text = "Changer mot de passe";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // repasswordTB
            // 
            this.repasswordTB.Location = new System.Drawing.Point(268, 106);
            this.repasswordTB.Name = "repasswordTB";
            this.repasswordTB.Size = new System.Drawing.Size(260, 20);
            this.repasswordTB.TabIndex = 23;
            this.repasswordTB.Leave += new System.EventHandler(this.outControl);
            // 
            // newpasswordTB
            // 
            this.newpasswordTB.Location = new System.Drawing.Point(268, 66);
            this.newpasswordTB.Name = "newpasswordTB";
            this.newpasswordTB.Size = new System.Drawing.Size(260, 20);
            this.newpasswordTB.TabIndex = 22;
            this.newpasswordTB.Leave += new System.EventHandler(this.outControl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(64, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Confirmer mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Noveau mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Changer mot de passe";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(70, 198);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(458, 31);
            this.clear.TabIndex = 25;
            this.clear.Text = "Effacer le formulaire";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 244);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.change);
            this.Controls.Add(this.repasswordTB);
            this.Controls.Add(this.newpasswordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changePasswordForm";
            this.Text = "Changer mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox repasswordTB;
        private System.Windows.Forms.TextBox newpasswordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
    }
}