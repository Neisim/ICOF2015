namespace ICOF
{
    partial class companyFoundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(companyFoundForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyName_TB = new System.Windows.Forms.TextBox();
            this.companyAddress_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_TB = new System.Windows.Forms.TextBox();
            this.email_LB = new System.Windows.Forms.Label();
            this.companyPhone_TB = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.activity_TB = new System.Windows.Forms.TextBox();
            this.activity_LB = new System.Windows.Forms.Label();
            this.taxe_LB = new System.Windows.Forms.Label();
            this.fax_TB = new System.Windows.Forms.TextBox();
            this.fax_LB = new System.Windows.Forms.Label();
            this.taxe_CB = new System.Windows.Forms.ComboBox();
            this.currentTA_LB = new System.Windows.Forms.Label();
            this.currentTA_TB = new System.Windows.Forms.TextBox();
            this.currentYear_TB = new System.Windows.Forms.TextBox();
            this.currentYear_LB = new System.Windows.Forms.Label();
            this.previousYear_TB = new System.Windows.Forms.TextBox();
            this.previousYear_LB = new System.Windows.Forms.Label();
            this.previousTA_TB = new System.Windows.Forms.TextBox();
            this.previousTA_LB = new System.Windows.Forms.Label();
            this.modify = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.data_TAB = new System.Windows.Forms.TabControl();
            this.contacts = new System.Windows.Forms.TabPage();
            this.contactsResult = new System.Windows.Forms.Label();
            this.addContact = new System.Windows.Forms.Button();
            this.contactDGV = new System.Windows.Forms.DataGridView();
            this.contact_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direct_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingStudents = new System.Windows.Forms.TabPage();
            this.studentsResult = new System.Windows.Forms.Label();
            this.addStudentTraining = new System.Windows.Forms.Button();
            this.studentsTrainingDGV = new System.Windows.Forms.DataGridView();
            this.student_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postIt = new System.Windows.Forms.TabPage();
            this.postItResult = new System.Windows.Forms.Label();
            this.addPostIt = new System.Windows.Forms.Button();
            this.postItDGV = new System.Windows.Forms.DataGridView();
            this.post_it_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearForm = new System.Windows.Forms.Button();
            this.modifyCompany = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.deleteCompany = new System.Windows.Forms.Button();
            this.data_TAB.SuspendLayout();
            this.contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDGV)).BeginInit();
            this.trainingStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTrainingDGV)).BeginInit();
            this.postIt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postItDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nom entreprise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entreprise";
            // 
            // companyName_TB
            // 
            this.companyName_TB.Enabled = false;
            this.companyName_TB.Location = new System.Drawing.Point(243, 74);
            this.companyName_TB.Name = "companyName_TB";
            this.companyName_TB.Size = new System.Drawing.Size(260, 20);
            this.companyName_TB.TabIndex = 1;
            this.companyName_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // companyAddress_TB
            // 
            this.companyAddress_TB.Enabled = false;
            this.companyAddress_TB.Location = new System.Drawing.Point(243, 114);
            this.companyAddress_TB.Name = "companyAddress_TB";
            this.companyAddress_TB.Size = new System.Drawing.Size(260, 20);
            this.companyAddress_TB.TabIndex = 2;
            this.companyAddress_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Adresse";
            // 
            // email_TB
            // 
            this.email_TB.Enabled = false;
            this.email_TB.Location = new System.Drawing.Point(243, 194);
            this.email_TB.Name = "email_TB";
            this.email_TB.Size = new System.Drawing.Size(260, 20);
            this.email_TB.TabIndex = 4;
            this.email_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // email_LB
            // 
            this.email_LB.AutoSize = true;
            this.email_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_LB.Location = new System.Drawing.Point(65, 194);
            this.email_LB.Name = "email_LB";
            this.email_LB.Size = new System.Drawing.Size(123, 20);
            this.email_LB.TabIndex = 47;
            this.email_LB.Text = "Email entreprise";
            // 
            // companyPhone_TB
            // 
            this.companyPhone_TB.Enabled = false;
            this.companyPhone_TB.Location = new System.Drawing.Point(243, 154);
            this.companyPhone_TB.Name = "companyPhone_TB";
            this.companyPhone_TB.Size = new System.Drawing.Size(260, 20);
            this.companyPhone_TB.TabIndex = 3;
            this.companyPhone_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(65, 154);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(84, 20);
            this.phone.TabIndex = 45;
            this.phone.Text = "Téléphone";
            // 
            // activity_TB
            // 
            this.activity_TB.Enabled = false;
            this.activity_TB.Location = new System.Drawing.Point(243, 234);
            this.activity_TB.Name = "activity_TB";
            this.activity_TB.Size = new System.Drawing.Size(260, 20);
            this.activity_TB.TabIndex = 5;
            this.activity_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // activity_LB
            // 
            this.activity_LB.AutoSize = true;
            this.activity_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity_LB.Location = new System.Drawing.Point(65, 234);
            this.activity_LB.Name = "activity_LB";
            this.activity_LB.Size = new System.Drawing.Size(64, 20);
            this.activity_LB.TabIndex = 49;
            this.activity_LB.Text = "Activité ";
            // 
            // taxe_LB
            // 
            this.taxe_LB.AutoSize = true;
            this.taxe_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxe_LB.Location = new System.Drawing.Point(65, 274);
            this.taxe_LB.Name = "taxe_LB";
            this.taxe_LB.Size = new System.Drawing.Size(152, 20);
            this.taxe_LB.TabIndex = 52;
            this.taxe_LB.Text = "Taxe d\'apprentisage";
            // 
            // fax_TB
            // 
            this.fax_TB.Enabled = false;
            this.fax_TB.Location = new System.Drawing.Point(736, 74);
            this.fax_TB.Name = "fax_TB";
            this.fax_TB.Size = new System.Drawing.Size(303, 20);
            this.fax_TB.TabIndex = 8;
            // 
            // fax_LB
            // 
            this.fax_LB.AutoSize = true;
            this.fax_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fax_LB.Location = new System.Drawing.Point(558, 74);
            this.fax_LB.Name = "fax_LB";
            this.fax_LB.Size = new System.Drawing.Size(41, 20);
            this.fax_LB.TabIndex = 56;
            this.fax_LB.Text = "FAX";
            // 
            // taxe_CB
            // 
            this.taxe_CB.Enabled = false;
            this.taxe_CB.FormattingEnabled = true;
            this.taxe_CB.Location = new System.Drawing.Point(243, 274);
            this.taxe_CB.Name = "taxe_CB";
            this.taxe_CB.Size = new System.Drawing.Size(260, 21);
            this.taxe_CB.TabIndex = 6;
            this.taxe_CB.SelectedIndexChanged += new System.EventHandler(this.taxe_CB_SelectedIndexChanged);
            // 
            // currentTA_LB
            // 
            this.currentTA_LB.AutoSize = true;
            this.currentTA_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTA_LB.Location = new System.Drawing.Point(558, 154);
            this.currentTA_LB.Name = "currentTA_LB";
            this.currentTA_LB.Size = new System.Drawing.Size(115, 20);
            this.currentTA_LB.TabIndex = 61;
            this.currentTA_LB.Text = "Montant actuel";
            // 
            // currentTA_TB
            // 
            this.currentTA_TB.Enabled = false;
            this.currentTA_TB.Location = new System.Drawing.Point(736, 154);
            this.currentTA_TB.Name = "currentTA_TB";
            this.currentTA_TB.Size = new System.Drawing.Size(303, 20);
            this.currentTA_TB.TabIndex = 9;
            this.currentTA_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // currentYear_TB
            // 
            this.currentYear_TB.Enabled = false;
            this.currentYear_TB.Location = new System.Drawing.Point(736, 114);
            this.currentYear_TB.Name = "currentYear_TB";
            this.currentYear_TB.Size = new System.Drawing.Size(303, 20);
            this.currentYear_TB.TabIndex = 10;
            this.currentYear_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // currentYear_LB
            // 
            this.currentYear_LB.AutoSize = true;
            this.currentYear_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYear_LB.Location = new System.Drawing.Point(558, 114);
            this.currentYear_LB.Name = "currentYear_LB";
            this.currentYear_LB.Size = new System.Drawing.Size(112, 20);
            this.currentYear_LB.TabIndex = 63;
            this.currentYear_LB.Text = "Anée en cours";
            // 
            // previousYear_TB
            // 
            this.previousYear_TB.Enabled = false;
            this.previousYear_TB.Location = new System.Drawing.Point(736, 194);
            this.previousYear_TB.Name = "previousYear_TB";
            this.previousYear_TB.Size = new System.Drawing.Size(303, 20);
            this.previousYear_TB.TabIndex = 13;
            this.previousYear_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // previousYear_LB
            // 
            this.previousYear_LB.AutoSize = true;
            this.previousYear_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousYear_LB.Location = new System.Drawing.Point(558, 194);
            this.previousYear_LB.Name = "previousYear_LB";
            this.previousYear_LB.Size = new System.Drawing.Size(132, 20);
            this.previousYear_LB.TabIndex = 70;
            this.previousYear_LB.Text = "Anée precedente";
            // 
            // previousTA_TB
            // 
            this.previousTA_TB.Enabled = false;
            this.previousTA_TB.Location = new System.Drawing.Point(736, 234);
            this.previousTA_TB.Name = "previousTA_TB";
            this.previousTA_TB.Size = new System.Drawing.Size(303, 20);
            this.previousTA_TB.TabIndex = 11;
            this.previousTA_TB.Leave += new System.EventHandler(this.outControl);
            // 
            // previousTA_LB
            // 
            this.previousTA_LB.AutoSize = true;
            this.previousTA_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousTA_LB.Location = new System.Drawing.Point(558, 234);
            this.previousTA_LB.Name = "previousTA_LB";
            this.previousTA_LB.Size = new System.Drawing.Size(144, 20);
            this.previousTA_LB.TabIndex = 69;
            this.previousTA_LB.Text = "Montant precedent";
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.Location = new System.Drawing.Point(68, 835);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(927, 43);
            this.modify.TabIndex = 78;
            this.modify.Text = "Modifier données entreprise";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(68, 885);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(927, 31);
            this.clear.TabIndex = 79;
            this.clear.Text = "Ajouter remarque";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // data_TAB
            // 
            this.data_TAB.Controls.Add(this.contacts);
            this.data_TAB.Controls.Add(this.trainingStudents);
            this.data_TAB.Controls.Add(this.postIt);
            this.data_TAB.Location = new System.Drawing.Point(69, 319);
            this.data_TAB.Name = "data_TAB";
            this.data_TAB.SelectedIndex = 0;
            this.data_TAB.Size = new System.Drawing.Size(974, 225);
            this.data_TAB.TabIndex = 82;
            // 
            // contacts
            // 
            this.contacts.Controls.Add(this.contactsResult);
            this.contacts.Controls.Add(this.addContact);
            this.contacts.Controls.Add(this.contactDGV);
            this.contacts.Location = new System.Drawing.Point(4, 22);
            this.contacts.Name = "contacts";
            this.contacts.Padding = new System.Windows.Forms.Padding(3);
            this.contacts.Size = new System.Drawing.Size(966, 199);
            this.contacts.TabIndex = 0;
            this.contacts.Text = "Contacts";
            this.contacts.UseVisualStyleBackColor = true;
            // 
            // contactsResult
            // 
            this.contactsResult.AutoSize = true;
            this.contactsResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.contactsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsResult.Location = new System.Drawing.Point(322, 68);
            this.contactsResult.Name = "contactsResult";
            this.contactsResult.Size = new System.Drawing.Size(327, 31);
            this.contactsResult.TabIndex = 78;
            this.contactsResult.Text = "Pas de contacts à afficher";
            this.contactsResult.Visible = false;
            // 
            // addContact
            // 
            this.addContact.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addContact.Location = new System.Drawing.Point(0, 162);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(966, 37);
            this.addContact.TabIndex = 77;
            this.addContact.Text = "Ajouter contact";
            this.addContact.UseVisualStyleBackColor = false;
            this.addContact.Visible = false;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // contactDGV
            // 
            this.contactDGV.AllowUserToAddRows = false;
            this.contactDGV.AllowUserToDeleteRows = false;
            this.contactDGV.AllowUserToResizeColumns = false;
            this.contactDGV.AllowUserToResizeRows = false;
            this.contactDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.contactDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.contactDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contact_lastname,
            this.contact_ID,
            this.contact_firstname,
            this.direct_phone,
            this.email,
            this.post});
            this.contactDGV.Location = new System.Drawing.Point(0, 0);
            this.contactDGV.MultiSelect = false;
            this.contactDGV.Name = "contactDGV";
            this.contactDGV.ReadOnly = true;
            this.contactDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contactDGV.Size = new System.Drawing.Size(966, 156);
            this.contactDGV.TabIndex = 73;
            this.contactDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getContact);
            // 
            // contact_lastname
            // 
            this.contact_lastname.DataPropertyName = "contact_lastname";
            this.contact_lastname.HeaderText = "Nom";
            this.contact_lastname.Name = "contact_lastname";
            this.contact_lastname.ReadOnly = true;
            // 
            // contact_ID
            // 
            this.contact_ID.DataPropertyName = "contact_id";
            this.contact_ID.HeaderText = "ID";
            this.contact_ID.Name = "contact_ID";
            this.contact_ID.ReadOnly = true;
            this.contact_ID.Visible = false;
            // 
            // contact_firstname
            // 
            this.contact_firstname.DataPropertyName = "contact_firstname";
            this.contact_firstname.HeaderText = "Prénom";
            this.contact_firstname.Name = "contact_firstname";
            this.contact_firstname.ReadOnly = true;
            // 
            // direct_phone
            // 
            this.direct_phone.DataPropertyName = "direct_phone";
            this.direct_phone.HeaderText = "Ligne directe";
            this.direct_phone.Name = "direct_phone";
            this.direct_phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // post
            // 
            this.post.DataPropertyName = "post";
            this.post.HeaderText = "Poste";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            // 
            // trainingStudents
            // 
            this.trainingStudents.Controls.Add(this.studentsResult);
            this.trainingStudents.Controls.Add(this.addStudentTraining);
            this.trainingStudents.Controls.Add(this.studentsTrainingDGV);
            this.trainingStudents.Location = new System.Drawing.Point(4, 22);
            this.trainingStudents.Name = "trainingStudents";
            this.trainingStudents.Padding = new System.Windows.Forms.Padding(3);
            this.trainingStudents.Size = new System.Drawing.Size(966, 199);
            this.trainingStudents.TabIndex = 1;
            this.trainingStudents.Text = "Élèves en satge";
            this.trainingStudents.UseVisualStyleBackColor = true;
            // 
            // studentsResult
            // 
            this.studentsResult.AutoSize = true;
            this.studentsResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.studentsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsResult.Location = new System.Drawing.Point(293, 68);
            this.studentsResult.Name = "studentsResult";
            this.studentsResult.Size = new System.Drawing.Size(397, 31);
            this.studentsResult.TabIndex = 79;
            this.studentsResult.Text = "Pas d\'élèves en stage à afficher";
            this.studentsResult.Visible = false;
            // 
            // addStudentTraining
            // 
            this.addStudentTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addStudentTraining.Location = new System.Drawing.Point(0, 162);
            this.addStudentTraining.Name = "addStudentTraining";
            this.addStudentTraining.Size = new System.Drawing.Size(966, 37);
            this.addStudentTraining.TabIndex = 78;
            this.addStudentTraining.Text = "Ajouter élève en stage";
            this.addStudentTraining.UseVisualStyleBackColor = true;
            this.addStudentTraining.Visible = false;
            this.addStudentTraining.Click += new System.EventHandler(this.addStudentTraining_Click);
            // 
            // studentsTrainingDGV
            // 
            this.studentsTrainingDGV.AllowUserToAddRows = false;
            this.studentsTrainingDGV.AllowUserToDeleteRows = false;
            this.studentsTrainingDGV.AllowUserToResizeColumns = false;
            this.studentsTrainingDGV.AllowUserToResizeRows = false;
            this.studentsTrainingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsTrainingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentsTrainingDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_lastname,
            this.student_id,
            this.student_firstname,
            this.job_year,
            this.course_name,
            this.teacher_lastname,
            this.teacher_firstname});
            this.studentsTrainingDGV.Location = new System.Drawing.Point(0, 0);
            this.studentsTrainingDGV.Name = "studentsTrainingDGV";
            this.studentsTrainingDGV.ReadOnly = true;
            this.studentsTrainingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsTrainingDGV.Size = new System.Drawing.Size(966, 156);
            this.studentsTrainingDGV.TabIndex = 75;
            this.studentsTrainingDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getStudent);
            // 
            // student_lastname
            // 
            this.student_lastname.DataPropertyName = "student_lastname";
            this.student_lastname.HeaderText = "Nom élève";
            this.student_lastname.Name = "student_lastname";
            this.student_lastname.ReadOnly = true;
            // 
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "ID";
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Visible = false;
            // 
            // student_firstname
            // 
            this.student_firstname.DataPropertyName = "student_firstname";
            this.student_firstname.HeaderText = "Prénom élève";
            this.student_firstname.Name = "student_firstname";
            this.student_firstname.ReadOnly = true;
            // 
            // job_year
            // 
            this.job_year.DataPropertyName = "job_year";
            this.job_year.HeaderText = "Année de stage";
            this.job_year.Name = "job_year";
            this.job_year.ReadOnly = true;
            // 
            // course_name
            // 
            this.course_name.DataPropertyName = "course_name";
            this.course_name.HeaderText = "Formation";
            this.course_name.Name = "course_name";
            this.course_name.ReadOnly = true;
            // 
            // teacher_lastname
            // 
            this.teacher_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_lastname.DataPropertyName = "teacher_lastname";
            this.teacher_lastname.HeaderText = "Nom maitre apprentissage";
            this.teacher_lastname.Name = "teacher_lastname";
            this.teacher_lastname.ReadOnly = true;
            // 
            // teacher_firstname
            // 
            this.teacher_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teacher_firstname.DataPropertyName = "teacher_firstname";
            this.teacher_firstname.HeaderText = "Prénom maitre apprentissage";
            this.teacher_firstname.Name = "teacher_firstname";
            this.teacher_firstname.ReadOnly = true;
            // 
            // postIt
            // 
            this.postIt.Controls.Add(this.postItResult);
            this.postIt.Controls.Add(this.addPostIt);
            this.postIt.Controls.Add(this.postItDGV);
            this.postIt.Location = new System.Drawing.Point(4, 22);
            this.postIt.Name = "postIt";
            this.postIt.Size = new System.Drawing.Size(966, 199);
            this.postIt.TabIndex = 2;
            this.postIt.Text = "Remarques";
            this.postIt.UseVisualStyleBackColor = true;
            // 
            // postItResult
            // 
            this.postItResult.AutoSize = true;
            this.postItResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.postItResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postItResult.Location = new System.Drawing.Point(285, 68);
            this.postItResult.Name = "postItResult";
            this.postItResult.Size = new System.Drawing.Size(353, 31);
            this.postItResult.TabIndex = 80;
            this.postItResult.Text = "Pas de remarques à afficher";
            this.postItResult.Visible = false;
            // 
            // addPostIt
            // 
            this.addPostIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPostIt.Location = new System.Drawing.Point(0, 162);
            this.addPostIt.Name = "addPostIt";
            this.addPostIt.Size = new System.Drawing.Size(966, 37);
            this.addPostIt.TabIndex = 79;
            this.addPostIt.Text = "Ajouter remarque";
            this.addPostIt.UseVisualStyleBackColor = true;
            this.addPostIt.Visible = false;
            this.addPostIt.Click += new System.EventHandler(this.addPostIt_Click);
            // 
            // postItDGV
            // 
            this.postItDGV.AllowUserToAddRows = false;
            this.postItDGV.AllowUserToDeleteRows = false;
            this.postItDGV.AllowUserToResizeColumns = false;
            this.postItDGV.AllowUserToResizeRows = false;
            this.postItDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postItDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.postItDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.postItDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.post_it_id,
            this.to_name,
            this.from_name,
            this.date,
            this.subject,
            this.notes});
            this.postItDGV.Location = new System.Drawing.Point(0, 0);
            this.postItDGV.MultiSelect = false;
            this.postItDGV.Name = "postItDGV";
            this.postItDGV.ReadOnly = true;
            this.postItDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.postItDGV.Size = new System.Drawing.Size(966, 156);
            this.postItDGV.TabIndex = 78;
            this.postItDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getPostIt);
            // 
            // post_it_id
            // 
            this.post_it_id.DataPropertyName = "post_it_id";
            this.post_it_id.HeaderText = "ID";
            this.post_it_id.Name = "post_it_id";
            this.post_it_id.ReadOnly = true;
            this.post_it_id.Visible = false;
            // 
            // to_name
            // 
            this.to_name.DataPropertyName = "to_name";
            this.to_name.HeaderText = "A";
            this.to_name.Name = "to_name";
            this.to_name.ReadOnly = true;
            // 
            // from_name
            // 
            this.from_name.DataPropertyName = "from_name";
            this.from_name.HeaderText = "De";
            this.from_name.Name = "from_name";
            this.from_name.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "post_it_date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "Objet";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            // 
            // clearForm
            // 
            this.clearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearForm.Location = new System.Drawing.Point(69, 622);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(974, 31);
            this.clearForm.TabIndex = 85;
            this.clearForm.Text = "Effacer le formulaire";
            this.clearForm.UseVisualStyleBackColor = true;
            // 
            // modifyCompany
            // 
            this.modifyCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCompany.Location = new System.Drawing.Point(69, 572);
            this.modifyCompany.Name = "modifyCompany";
            this.modifyCompany.Size = new System.Drawing.Size(974, 43);
            this.modifyCompany.TabIndex = 84;
            this.modifyCompany.Text = "Modifier entreprise";
            this.modifyCompany.UseVisualStyleBackColor = true;
            this.modifyCompany.Click += new System.EventHandler(this.modifyCompany_Click);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(69, 572);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(974, 43);
            this.confirm.TabIndex = 86;
            this.confirm.Text = "Confirmer modifications";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // deleteCompany
            // 
            this.deleteCompany.BackColor = System.Drawing.Color.Brown;
            this.deleteCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCompany.Location = new System.Drawing.Point(69, 661);
            this.deleteCompany.Name = "deleteCompany";
            this.deleteCompany.Size = new System.Drawing.Size(974, 31);
            this.deleteCompany.TabIndex = 88;
            this.deleteCompany.Text = "Suprimer entreprise";
            this.deleteCompany.UseVisualStyleBackColor = false;
            this.deleteCompany.Click += new System.EventHandler(this.deleteCompany_Click);
            // 
            // companyFoundForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1112, 716);
            this.Controls.Add(this.deleteCompany);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.modifyCompany);
            this.Controls.Add(this.data_TAB);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.previousYear_TB);
            this.Controls.Add(this.previousYear_LB);
            this.Controls.Add(this.previousTA_TB);
            this.Controls.Add(this.previousTA_LB);
            this.Controls.Add(this.currentYear_TB);
            this.Controls.Add(this.currentYear_LB);
            this.Controls.Add(this.currentTA_TB);
            this.Controls.Add(this.currentTA_LB);
            this.Controls.Add(this.taxe_CB);
            this.Controls.Add(this.fax_TB);
            this.Controls.Add(this.fax_LB);
            this.Controls.Add(this.taxe_LB);
            this.Controls.Add(this.activity_TB);
            this.Controls.Add(this.activity_LB);
            this.Controls.Add(this.email_TB);
            this.Controls.Add(this.email_LB);
            this.Controls.Add(this.companyPhone_TB);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.companyAddress_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyName_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "companyFoundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultat de recherche";
            this.Leave += new System.EventHandler(this.outControl);
            this.data_TAB.ResumeLayout(false);
            this.contacts.ResumeLayout(false);
            this.contacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDGV)).EndInit();
            this.trainingStudents.ResumeLayout(false);
            this.trainingStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTrainingDGV)).EndInit();
            this.postIt.ResumeLayout(false);
            this.postIt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postItDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyName_TB;
        private System.Windows.Forms.TextBox companyAddress_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_TB;
        private System.Windows.Forms.Label email_LB;
        private System.Windows.Forms.TextBox companyPhone_TB;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox activity_TB;
        private System.Windows.Forms.Label activity_LB;
        private System.Windows.Forms.Label taxe_LB;
        private System.Windows.Forms.TextBox fax_TB;
        private System.Windows.Forms.Label fax_LB;
        private System.Windows.Forms.ComboBox taxe_CB;
        private System.Windows.Forms.Label currentTA_LB;
        private System.Windows.Forms.TextBox currentTA_TB;
        private System.Windows.Forms.TextBox currentYear_TB;
        private System.Windows.Forms.Label currentYear_LB;
        private System.Windows.Forms.TextBox previousYear_TB;
        private System.Windows.Forms.Label previousYear_LB;
        private System.Windows.Forms.TextBox previousTA_TB;
        private System.Windows.Forms.Label previousTA_LB;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TabControl data_TAB;
        private System.Windows.Forms.TabPage contacts;
        private System.Windows.Forms.Button addContact;
        private System.Windows.Forms.DataGridView contactDGV;
        private System.Windows.Forms.TabPage trainingStudents;
        private System.Windows.Forms.DataGridView studentsTrainingDGV;
        private System.Windows.Forms.Button addStudentTraining;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.Button modifyCompany;
        private System.Windows.Forms.TabPage postIt;
        private System.Windows.Forms.Button addPostIt;
        private System.Windows.Forms.DataGridView postItDGV;
        private System.Windows.Forms.Label contactsResult;
        private System.Windows.Forms.Label studentsResult;
        private System.Windows.Forms.Label postItResult;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn direct_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn post;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn post_it_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn to_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn from_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.Button deleteCompany;
    }
}