namespace ICOF
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.annuaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pourTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ufaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrepriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contact = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherRemarquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid_All = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_All)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annuaireToolStripMenuItem,
            this.data,
            this.contact,
            this.rechercheToolStripMenuItem,
            this.profile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // annuaireToolStripMenuItem
            // 
            this.annuaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pourTousToolStripMenuItem,
            this.ufaMenuItem,
            this.directionMenuItem,
            this.officeMenuItem,
            this.accountingMenuItem,
            this.sortirToolStripMenuItem});
            this.annuaireToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.annuaireToolStripMenuItem.Name = "annuaireToolStripMenuItem";
            this.annuaireToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.annuaireToolStripMenuItem.Text = "Annuaire";
            // 
            // pourTousToolStripMenuItem
            // 
            this.pourTousToolStripMenuItem.Name = "pourTousToolStripMenuItem";
            this.pourTousToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pourTousToolStripMenuItem.Text = "Tous";
            // 
            // ufaMenuItem
            // 
            this.ufaMenuItem.Name = "ufaMenuItem";
            this.ufaMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ufaMenuItem.Text = "UFA";
            this.ufaMenuItem.Click += new System.EventHandler(this.access_form);
            // 
            // directionMenuItem
            // 
            this.directionMenuItem.Name = "directionMenuItem";
            this.directionMenuItem.Size = new System.Drawing.Size(152, 22);
            this.directionMenuItem.Text = "Direction";
            this.directionMenuItem.Click += new System.EventHandler(this.access_form);
            // 
            // officeMenuItem
            // 
            this.officeMenuItem.Name = "officeMenuItem";
            this.officeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.officeMenuItem.Text = "Secrétariat";
            this.officeMenuItem.Click += new System.EventHandler(this.access_form);
            // 
            // accountingMenuItem
            // 
            this.accountingMenuItem.Name = "accountingMenuItem";
            this.accountingMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountingMenuItem.Text = "Comptabilité";
            this.accountingMenuItem.Click += new System.EventHandler(this.access_form);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.exit);
            // 
            // data
            // 
            this.data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(55, 20);
            this.data.Text = "Donées";
            this.data.Visible = false;
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personneToolStripMenuItem,
            this.entrepriseToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // personneToolStripMenuItem
            // 
            this.personneToolStripMenuItem.Name = "personneToolStripMenuItem";
            this.personneToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.personneToolStripMenuItem.Text = "Personne";
            this.personneToolStripMenuItem.Click += new System.EventHandler(this.personneToolStripMenuItem_Click);
            // 
            // entrepriseToolStripMenuItem
            // 
            this.entrepriseToolStripMenuItem.Name = "entrepriseToolStripMenuItem";
            this.entrepriseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.entrepriseToolStripMenuItem.Text = "Entreprise";
            this.entrepriseToolStripMenuItem.Click += new System.EventHandler(this.entrepriseToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // contact
            // 
            this.contact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherRemarquesToolStripMenuItem});
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(73, 20);
            this.contact.Text = "Remarques";
            this.contact.Visible = false;
            // 
            // afficherRemarquesToolStripMenuItem
            // 
            this.afficherRemarquesToolStripMenuItem.Name = "afficherRemarquesToolStripMenuItem";
            this.afficherRemarquesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.afficherRemarquesToolStripMenuItem.Text = "Ajouter remarque";
            this.afficherRemarquesToolStripMenuItem.Click += new System.EventHandler(this.afficherRemarquesToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chercherToolStripMenuItem});
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            // 
            // chercherToolStripMenuItem
            // 
            this.chercherToolStripMenuItem.Name = "chercherToolStripMenuItem";
            this.chercherToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.chercherToolStripMenuItem.Text = "Chercher...";
            // 
            // dataGrid_All
            // 
            this.dataGrid_All.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGrid_All.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGrid_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            this.dataGrid_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_All.Location = new System.Drawing.Point(0, 24);
            this.dataGrid_All.MultiSelect = false;
            this.dataGrid_All.Name = "dataGrid_All";
            this.dataGrid_All.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid_All.Size = new System.Drawing.Size(550, 271);
            this.dataGrid_All.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom de l\'entreprise";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 122;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adresse";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adresse 2";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 79;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CP";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 46;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ville";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 51;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pays";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 55;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Téléphone";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 83;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mail";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 51;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fax";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 49;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Site Web";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 76;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Qualification";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 90;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Type établissement";
            this.Column12.Name = "Column12";
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.Width = 123;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Civilité";
            this.Column13.Name = "Column13";
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column13.Width = 62;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Mme/Mr";
            this.Column14.Name = "Column14";
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column14.Width = 72;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Nom";
            this.Column15.Name = "Column15";
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column15.Width = 54;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Prénom";
            this.Column16.Name = "Column16";
            this.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column16.Width = 68;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Poste";
            this.Column17.Name = "Column17";
            this.Column17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column17.Width = 59;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Mail perso";
            this.Column18.Name = "Column18";
            this.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column18.Width = 80;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Ligne directe";
            this.Column19.Name = "Column19";
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column19.Width = 93;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Activité";
            this.Column20.Name = "Column20";
            this.Column20.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column20.Width = 67;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Stagiaire ICOF (Oui/Non)";
            this.Column21.Name = "Column21";
            this.Column21.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column21.Width = 150;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Année du stage";
            this.Column22.Name = "Column22";
            this.Column22.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column22.Width = 107;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Apprenti";
            this.Column23.Name = "Column23";
            this.Column23.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column23.Width = 71;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Sortie en";
            this.Column24.Name = "Column24";
            this.Column24.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column24.Width = 74;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Versement TA";
            this.Column25.Name = "Column25";
            this.Column25.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column25.Width = 99;
            // 
            // profile
            // 
            this.profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerMotDePasseToolStripMenuItem});
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(43, 20);
            this.profile.Text = "Profil";
            this.profile.Visible = false;
            // 
            // changerMotDePasseToolStripMenuItem
            // 
            this.changerMotDePasseToolStripMenuItem.Name = "changerMotDePasseToolStripMenuItem";
            this.changerMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.changerMotDePasseToolStripMenuItem.Text = "Changer mot de passe";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 295);
            this.Controls.Add(this.dataGrid_All);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Annuaire ICOF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.close_form);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_All)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem annuaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pourTousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ufaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem data;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.ToolStripMenuItem contact;
        private System.Windows.Forms.ToolStripMenuItem afficherRemarquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrepriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profile;
        private System.Windows.Forms.ToolStripMenuItem changerMotDePasseToolStripMenuItem;
    }
}

