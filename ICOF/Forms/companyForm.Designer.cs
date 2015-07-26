namespace ICOF
{
    partial class companyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companyForm));
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyName_TB = new System.Windows.Forms.TextBox();
            this.companyAddress_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyEmail_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyPhone_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.companyActivity_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fax_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.taxeCB = new System.Windows.Forms.ComboBox();
            this.montantLB = new System.Windows.Forms.Label();
            this.currentTA_TB = new System.Windows.Forms.TextBox();
            this.currentYear_TB = new System.Windows.Forms.TextBox();
            this.anneeLB = new System.Windows.Forms.Label();
            this.euroLB = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.euro_prevLB = new System.Windows.Forms.Label();
            this.previousYear_TB = new System.Windows.Forms.TextBox();
            this.annee_prevLB = new System.Windows.Forms.Label();
            this.previousTA_TB = new System.Windows.Forms.TextBox();
            this.montant_prevLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(68, 331);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(934, 43);
            this.add.TabIndex = 20;
            this.add.Text = "Ajouter entreprise";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nom entreprise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nouvelle entreprise";
            // 
            // companyName_TB
            // 
            this.companyName_TB.Location = new System.Drawing.Point(242, 74);
            this.companyName_TB.Name = "companyName_TB";
            this.companyName_TB.Size = new System.Drawing.Size(260, 20);
            this.companyName_TB.TabIndex = 1;
            this.companyName_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // companyAddress_TB
            // 
            this.companyAddress_TB.Location = new System.Drawing.Point(242, 114);
            this.companyAddress_TB.Name = "companyAddress_TB";
            this.companyAddress_TB.Size = new System.Drawing.Size(260, 20);
            this.companyAddress_TB.TabIndex = 2;
            this.companyAddress_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Adresse";
            // 
            // companyEmail_TB
            // 
            this.companyEmail_TB.Location = new System.Drawing.Point(242, 194);
            this.companyEmail_TB.Name = "companyEmail_TB";
            this.companyEmail_TB.Size = new System.Drawing.Size(260, 20);
            this.companyEmail_TB.TabIndex = 4;
            this.companyEmail_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Email entreprise";
            // 
            // companyPhone_TB
            // 
            this.companyPhone_TB.Location = new System.Drawing.Point(242, 154);
            this.companyPhone_TB.Name = "companyPhone_TB";
            this.companyPhone_TB.Size = new System.Drawing.Size(260, 20);
            this.companyPhone_TB.TabIndex = 3;
            this.companyPhone_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Téléphone";
            // 
            // companyActivity_TB
            // 
            this.companyActivity_TB.Location = new System.Drawing.Point(242, 234);
            this.companyActivity_TB.Name = "companyActivity_TB";
            this.companyActivity_TB.Size = new System.Drawing.Size(260, 20);
            this.companyActivity_TB.TabIndex = 5;
            this.companyActivity_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Activité ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Taxe d\'apprentisage";
            // 
            // fax_TB
            // 
            this.fax_TB.Location = new System.Drawing.Point(721, 76);
            this.fax_TB.Name = "fax_TB";
            this.fax_TB.Size = new System.Drawing.Size(260, 20);
            this.fax_TB.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(547, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "FAX";
            // 
            // taxeCB
            // 
            this.taxeCB.FormattingEnabled = true;
            this.taxeCB.Location = new System.Drawing.Point(242, 274);
            this.taxeCB.Name = "taxeCB";
            this.taxeCB.Size = new System.Drawing.Size(260, 21);
            this.taxeCB.TabIndex = 6;
            this.taxeCB.SelectedIndexChanged += new System.EventHandler(this.taxeCB_SelectedIndexChanged);
            // 
            // montantLB
            // 
            this.montantLB.AutoSize = true;
            this.montantLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantLB.Location = new System.Drawing.Point(545, 116);
            this.montantLB.Name = "montantLB";
            this.montantLB.Size = new System.Drawing.Size(115, 20);
            this.montantLB.TabIndex = 61;
            this.montantLB.Text = "Montant actuel";
            // 
            // currentTA_TB
            // 
            this.currentTA_TB.Enabled = false;
            this.currentTA_TB.Location = new System.Drawing.Point(721, 116);
            this.currentTA_TB.Name = "currentTA_TB";
            this.currentTA_TB.Size = new System.Drawing.Size(260, 20);
            this.currentTA_TB.TabIndex = 9;
            this.currentTA_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // currentYear_TB
            // 
            this.currentYear_TB.Enabled = false;
            this.currentYear_TB.Location = new System.Drawing.Point(721, 156);
            this.currentYear_TB.Name = "currentYear_TB";
            this.currentYear_TB.Size = new System.Drawing.Size(260, 20);
            this.currentYear_TB.TabIndex = 10;
            this.currentYear_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // anneeLB
            // 
            this.anneeLB.AutoSize = true;
            this.anneeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anneeLB.Location = new System.Drawing.Point(547, 156);
            this.anneeLB.Name = "anneeLB";
            this.anneeLB.Size = new System.Drawing.Size(112, 20);
            this.anneeLB.TabIndex = 63;
            this.anneeLB.Text = "Anée en cours";
            // 
            // euroLB
            // 
            this.euroLB.AutoSize = true;
            this.euroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euroLB.Location = new System.Drawing.Point(984, 116);
            this.euroLB.Name = "euroLB";
            this.euroLB.Size = new System.Drawing.Size(18, 20);
            this.euroLB.TabIndex = 65;
            this.euroLB.Text = "€";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(68, 381);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(934, 31);
            this.clear.TabIndex = 21;
            this.clear.Text = "Effacer le formulaire";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clearCompany);
            // 
            // euro_prevLB
            // 
            this.euro_prevLB.AutoSize = true;
            this.euro_prevLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euro_prevLB.Location = new System.Drawing.Point(984, 196);
            this.euro_prevLB.Name = "euro_prevLB";
            this.euro_prevLB.Size = new System.Drawing.Size(18, 20);
            this.euro_prevLB.TabIndex = 71;
            this.euro_prevLB.Text = "€";
            // 
            // previousYear_TB
            // 
            this.previousYear_TB.Enabled = false;
            this.previousYear_TB.Location = new System.Drawing.Point(721, 236);
            this.previousYear_TB.Name = "previousYear_TB";
            this.previousYear_TB.Size = new System.Drawing.Size(260, 20);
            this.previousYear_TB.TabIndex = 13;
            this.previousYear_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // annee_prevLB
            // 
            this.annee_prevLB.AutoSize = true;
            this.annee_prevLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annee_prevLB.Location = new System.Drawing.Point(547, 236);
            this.annee_prevLB.Name = "annee_prevLB";
            this.annee_prevLB.Size = new System.Drawing.Size(132, 20);
            this.annee_prevLB.TabIndex = 70;
            this.annee_prevLB.Text = "Anée precedente";
            // 
            // previousTA_TB
            // 
            this.previousTA_TB.Enabled = false;
            this.previousTA_TB.Location = new System.Drawing.Point(721, 196);
            this.previousTA_TB.Name = "previousTA_TB";
            this.previousTA_TB.Size = new System.Drawing.Size(260, 20);
            this.previousTA_TB.TabIndex = 11;
            this.previousTA_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // montant_prevLB
            // 
            this.montant_prevLB.AutoSize = true;
            this.montant_prevLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montant_prevLB.Location = new System.Drawing.Point(545, 196);
            this.montant_prevLB.Name = "montant_prevLB";
            this.montant_prevLB.Size = new System.Drawing.Size(144, 20);
            this.montant_prevLB.TabIndex = 69;
            this.montant_prevLB.Text = "Montant precedent";
            // 
            // companyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 433);
            this.Controls.Add(this.euro_prevLB);
            this.Controls.Add(this.previousYear_TB);
            this.Controls.Add(this.annee_prevLB);
            this.Controls.Add(this.previousTA_TB);
            this.Controls.Add(this.montant_prevLB);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.euroLB);
            this.Controls.Add(this.currentYear_TB);
            this.Controls.Add(this.anneeLB);
            this.Controls.Add(this.currentTA_TB);
            this.Controls.Add(this.montantLB);
            this.Controls.Add(this.taxeCB);
            this.Controls.Add(this.fax_TB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.companyActivity_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.companyEmail_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyPhone_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.companyAddress_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyName_TB);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "companyForm";
            this.Text = "Ajouter entreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyName_TB;
        private System.Windows.Forms.TextBox companyAddress_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companyEmail_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companyPhone_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companyActivity_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fax_TB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox taxeCB;
        private System.Windows.Forms.Label montantLB;
        private System.Windows.Forms.TextBox currentTA_TB;
        private System.Windows.Forms.TextBox currentYear_TB;
        private System.Windows.Forms.Label anneeLB;
        private System.Windows.Forms.Label euroLB;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label euro_prevLB;
        private System.Windows.Forms.TextBox previousYear_TB;
        private System.Windows.Forms.Label annee_prevLB;
        private System.Windows.Forms.TextBox previousTA_TB;
        private System.Windows.Forms.Label montant_prevLB;
    }
}