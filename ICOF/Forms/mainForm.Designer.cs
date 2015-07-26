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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profiles = new System.Windows.Forms.ToolStripMenuItem();
            this.officeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.addPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.modify = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.profile = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDGV = new System.Windows.Forms.DataGridView();
            this.personDGV = new System.Windows.Forms.DataGridView();
            this.mrmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icofPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diploma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payed_TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previous_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previous_TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profiles,
            this.data,
            this.search,
            this.profile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profiles
            // 
            this.profiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.officeMenuItem,
            this.sortirToolStripMenuItem});
            this.profiles.ImageTransparentColor = System.Drawing.Color.White;
            this.profiles.Name = "profiles";
            this.profiles.Size = new System.Drawing.Size(73, 20);
            this.profiles.Text = "Connection";
            // 
            // officeMenuItem
            // 
            this.officeMenuItem.Name = "officeMenuItem";
            this.officeMenuItem.Size = new System.Drawing.Size(127, 22);
            this.officeMenuItem.Text = "Secrétariat";
            this.officeMenuItem.Click += new System.EventHandler(this.access_form);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.exit);
            // 
            // data
            // 
            this.data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.modify});
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(55, 20);
            this.data.Text = "Donées";
            this.data.Visible = false;
            // 
            // add
            // 
            this.add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPerson,
            this.addCompany});
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 22);
            this.add.Text = "Ajouter";
            // 
            // addPerson
            // 
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(123, 22);
            this.addPerson.Text = "Personne";
            this.addPerson.Click += new System.EventHandler(this.addPersonMenuItem_Click);
            // 
            // addCompany
            // 
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(123, 22);
            this.addCompany.Text = "Entreprise";
            this.addCompany.Click += new System.EventHandler(this.addCompanyMenuItem_Click);
            // 
            // modify
            // 
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(112, 22);
            this.modify.Text = "Modifier";
            // 
            // search
            // 
            this.search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchPerson,
            this.searchCompany});
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(70, 20);
            this.search.Text = "Recherche";
            // 
            // searchPerson
            // 
            this.searchPerson.Name = "searchPerson";
            this.searchPerson.Size = new System.Drawing.Size(171, 22);
            this.searchPerson.Text = "Chercher personne";
            this.searchPerson.Click += new System.EventHandler(this.searchPerson_Click);
            // 
            // searchCompany
            // 
            this.searchCompany.Name = "searchCompany";
            this.searchCompany.Size = new System.Drawing.Size(171, 22);
            this.searchCompany.Text = "Cherches entreprise";
            this.searchCompany.Click += new System.EventHandler(this.searchCompany_Click);
            // 
            // profile
            // 
            this.profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassword});
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(43, 20);
            this.profile.Text = "Profil";
            this.profile.Visible = false;
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(182, 22);
            this.changePassword.Text = "Changer mot de passe";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // companyDGV
            // 
            this.companyDGV.AllowUserToAddRows = false;
            this.companyDGV.AllowUserToDeleteRows = false;
            this.companyDGV.AllowUserToResizeColumns = false;
            this.companyDGV.AllowUserToResizeRows = false;
            this.companyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.companyDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.companyDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.companyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company_id,
            this.company_name,
            this.company_address,
            this.company_phone,
            this.company_email,
            this.fax,
            this.company_activity,
            this.payed_TA,
            this.current_year,
            this.current_TA,
            this.previous_year,
            this.previous_TA});
            this.companyDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyDGV.Location = new System.Drawing.Point(0, 24);
            this.companyDGV.MultiSelect = false;
            this.companyDGV.Name = "companyDGV";
            this.companyDGV.ReadOnly = true;
            this.companyDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.companyDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.companyDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companyDGV.Size = new System.Drawing.Size(750, 271);
            this.companyDGV.TabIndex = 73;
            this.companyDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getCompany);
            // 
            // personDGV
            // 
            this.personDGV.AllowUserToAddRows = false;
            this.personDGV.AllowUserToDeleteRows = false;
            this.personDGV.AllowUserToResizeColumns = false;
            this.personDGV.AllowUserToResizeRows = false;
            this.personDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.personDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.personDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.personDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mrmm,
            this.person_id,
            this.person_lastname,
            this.person_firstname,
            this.person_phone,
            this.person_email,
            this.icofPost,
            this.companyName,
            this.companyPost,
            this.birth_date,
            this.courseDone,
            this.yearIn,
            this.yearOut,
            this.Diploma});
            this.personDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personDGV.Location = new System.Drawing.Point(0, 24);
            this.personDGV.MultiSelect = false;
            this.personDGV.Name = "personDGV";
            this.personDGV.ReadOnly = true;
            this.personDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.personDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.personDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personDGV.Size = new System.Drawing.Size(750, 271);
            this.personDGV.TabIndex = 74;
            this.personDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getPerson);
            // 
            // mrmm
            // 
            this.mrmm.DataPropertyName = "mrmm";
            this.mrmm.HeaderText = "Civilité";
            this.mrmm.Name = "mrmm";
            this.mrmm.ReadOnly = true;
            this.mrmm.Width = 62;
            // 
            // person_id
            // 
            this.person_id.DataPropertyName = "person_id";
            this.person_id.HeaderText = "ID";
            this.person_id.Name = "person_id";
            this.person_id.ReadOnly = true;
            this.person_id.Visible = false;
            this.person_id.Width = 43;
            // 
            // person_lastname
            // 
            this.person_lastname.DataPropertyName = "person_lastname";
            this.person_lastname.HeaderText = "Nom";
            this.person_lastname.Name = "person_lastname";
            this.person_lastname.ReadOnly = true;
            this.person_lastname.Width = 54;
            // 
            // person_firstname
            // 
            this.person_firstname.DataPropertyName = "person_firstname";
            this.person_firstname.HeaderText = "Prénom";
            this.person_firstname.Name = "person_firstname";
            this.person_firstname.ReadOnly = true;
            this.person_firstname.Width = 68;
            // 
            // person_phone
            // 
            this.person_phone.DataPropertyName = "phone";
            this.person_phone.HeaderText = "Téléphone";
            this.person_phone.Name = "person_phone";
            this.person_phone.ReadOnly = true;
            this.person_phone.Width = 83;
            // 
            // person_email
            // 
            this.person_email.DataPropertyName = "email";
            this.person_email.HeaderText = "Email";
            this.person_email.Name = "person_email";
            this.person_email.ReadOnly = true;
            this.person_email.Width = 57;
            // 
            // icofPost
            // 
            this.icofPost.DataPropertyName = "icof_post";
            this.icofPost.HeaderText = "Poste a l\'ICOF";
            this.icofPost.Name = "icofPost";
            this.icofPost.ReadOnly = true;
            this.icofPost.Width = 91;
            // 
            // companyName
            // 
            this.companyName.DataPropertyName = "company_name";
            this.companyName.HeaderText = "Nom entreprise";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Width = 95;
            // 
            // companyPost
            // 
            this.companyPost.DataPropertyName = "company_post";
            this.companyPost.HeaderText = "Poste entreprise";
            this.companyPost.Name = "companyPost";
            this.companyPost.ReadOnly = true;
            this.companyPost.Width = 99;
            // 
            // birth_date
            // 
            this.birth_date.DataPropertyName = "birth_date";
            this.birth_date.HeaderText = "Année naissance";
            this.birth_date.Name = "birth_date";
            this.birth_date.ReadOnly = true;
            this.birth_date.Width = 105;
            // 
            // courseDone
            // 
            this.courseDone.DataPropertyName = "course_done";
            this.courseDone.HeaderText = "Cours";
            this.courseDone.Name = "courseDone";
            this.courseDone.ReadOnly = true;
            this.courseDone.Width = 59;
            // 
            // yearIn
            // 
            this.yearIn.DataPropertyName = "year_in";
            this.yearIn.HeaderText = "Année entrée";
            this.yearIn.Name = "yearIn";
            this.yearIn.ReadOnly = true;
            this.yearIn.Width = 88;
            // 
            // yearOut
            // 
            this.yearOut.DataPropertyName = "year_out";
            this.yearOut.HeaderText = "Année sortie";
            this.yearOut.Name = "yearOut";
            this.yearOut.ReadOnly = true;
            this.yearOut.Width = 84;
            // 
            // Diploma
            // 
            this.Diploma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diploma.DataPropertyName = "diploma";
            this.Diploma.HeaderText = "Obtention de diplome";
            this.Diploma.Name = "Diploma";
            this.Diploma.ReadOnly = true;
            // 
            // company_id
            // 
            this.company_id.DataPropertyName = "company_id";
            this.company_id.HeaderText = "ID";
            this.company_id.Name = "company_id";
            this.company_id.ReadOnly = true;
            this.company_id.Visible = false;
            this.company_id.Width = 43;
            // 
            // company_name
            // 
            this.company_name.DataPropertyName = "company_name";
            this.company_name.HeaderText = "Nom entreprise";
            this.company_name.Name = "company_name";
            this.company_name.ReadOnly = true;
            this.company_name.Width = 95;
            // 
            // company_address
            // 
            this.company_address.DataPropertyName = "address";
            this.company_address.HeaderText = "Adresse";
            this.company_address.Name = "company_address";
            this.company_address.ReadOnly = true;
            this.company_address.Width = 70;
            // 
            // company_phone
            // 
            this.company_phone.DataPropertyName = "phone";
            this.company_phone.HeaderText = "Télépohne";
            this.company_phone.Name = "company_phone";
            this.company_phone.ReadOnly = true;
            this.company_phone.Width = 83;
            // 
            // company_email
            // 
            this.company_email.DataPropertyName = "email";
            this.company_email.HeaderText = "Email";
            this.company_email.Name = "company_email";
            this.company_email.ReadOnly = true;
            this.company_email.Width = 57;
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fax";
            this.fax.HeaderText = "FAX";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            this.fax.Width = 52;
            // 
            // company_activity
            // 
            this.company_activity.DataPropertyName = "activity";
            this.company_activity.HeaderText = "Activité";
            this.company_activity.Name = "company_activity";
            this.company_activity.ReadOnly = true;
            this.company_activity.Width = 67;
            // 
            // payed_TA
            // 
            this.payed_TA.DataPropertyName = "payed_TA";
            this.payed_TA.HeaderText = "TA";
            this.payed_TA.Name = "payed_TA";
            this.payed_TA.ReadOnly = true;
            this.payed_TA.Width = 46;
            // 
            // current_year
            // 
            this.current_year.DataPropertyName = "current_year";
            this.current_year.HeaderText = "Année en cours";
            this.current_year.Name = "current_year";
            this.current_year.ReadOnly = true;
            this.current_year.Width = 75;
            // 
            // current_TA
            // 
            this.current_TA.DataPropertyName = "current_TA";
            this.current_TA.HeaderText = "TA en cours";
            this.current_TA.Name = "current_TA";
            this.current_TA.ReadOnly = true;
            this.current_TA.Width = 83;
            // 
            // previous_year
            // 
            this.previous_year.DataPropertyName = "previous_year";
            this.previous_year.HeaderText = "Année precedente";
            this.previous_year.Name = "previous_year";
            this.previous_year.ReadOnly = true;
            this.previous_year.Width = 110;
            // 
            // previous_TA
            // 
            this.previous_TA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.previous_TA.DataPropertyName = "previous_TA";
            this.previous_TA.HeaderText = "TA precedente";
            this.previous_TA.Name = "previous_TA";
            this.previous_TA.ReadOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 295);
            this.Controls.Add(this.personDGV);
            this.Controls.Add(this.companyDGV);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICOF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.close_form);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profiles;
        private System.Windows.Forms.ToolStripMenuItem officeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem data;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem modify;
        private System.Windows.Forms.ToolStripMenuItem search;
        private System.Windows.Forms.ToolStripMenuItem searchPerson;
        private System.Windows.Forms.ToolStripMenuItem addPerson;
        private System.Windows.Forms.ToolStripMenuItem addCompany;
        private System.Windows.Forms.ToolStripMenuItem profile;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.ToolStripMenuItem searchCompany;
        private System.Windows.Forms.DataGridView companyDGV;
        private System.Windows.Forms.DataGridView personDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrmm;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn person_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn icofPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diploma;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn payed_TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn previous_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn previous_TA;
    }
}

