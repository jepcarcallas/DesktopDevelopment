namespace Exercise2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnSave = new ToolStripButton();
            btnOpen = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            panelLeft = new Panel();
            listBoxContacts = new ListBox();
            txtSearch = new TextBox();
            lblSearchContacts = new Label();
            tabControl1 = new TabControl();
            tabPersonalInfo = new TabPage();
            panelPersonalInfo = new Panel();
            btnCancel = new Button();
            btnSaveChanges = new Button();
            groupBoxAdditionalInfo = new GroupBox();
            dtpBirthday = new DateTimePicker();
            lblBirthday = new Label();
            txtJobTitle = new TextBox();
            lblJobTitle = new Label();
            txtDepartment = new TextBox();
            lblDepartment = new Label();
            txtCompany = new TextBox();
            lblCompany = new Label();
            groupBoxContactDetails = new GroupBox();
            label1 = new Label();
            cmbCountry = new ComboBox();
            lblCountry = new Label();
            txtZipCode = new TextBox();
            lblZipCode = new Label();
            cmbState = new ComboBox();
            lblState = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtMobileNumber = new TextBox();
            lblMobileNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            groupBoxProfile = new GroupBox();
            btnChangePhoto = new Button();
            pictureBoxProfile = new PictureBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblProfile = new Label();
            tabTasks = new TabPage();
            panelTasks = new Panel();
            panelTaskStatistics = new Panel();
            lblUrgentValue = new Label();
            lblUrgentLabel = new Label();
            lblInProgressValue = new Label();
            lblInProgressLabel = new Label();
            lblCompletedValue = new Label();
            lblCompletedLabel = new Label();
            lblTotalTasksValue = new Label();
            lblTotalTasksLabel = new Label();
            lblTaskStatistics = new Label();
            groupBoxTaskList = new GroupBox();
            dgvTasks = new DataGridView();
            panelTaskHeader = new Panel();
            btnAddNewTask = new Button();
            lblTasksFor = new Label();
            tabNotes = new TabPage();
            txtNotes = new TextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelLeft.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPersonalInfo.SuspendLayout();
            panelPersonalInfo.SuspendLayout();
            groupBoxAdditionalInfo.SuspendLayout();
            groupBoxContactDetails.SuspendLayout();
            groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            tabTasks.SuspendLayout();
            panelTasks.SuspendLayout();
            panelTaskStatistics.SuspendLayout();
            groupBoxTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            panelTaskHeader.SuspendLayout();
            tabNotes.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1222, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(44, 23);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(49, 23);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10F);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, toolStripSeparator1, btnSave, btnOpen });
            toolStrip1.Location = new Point(0, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1222, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 24);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(56, 24);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 24);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(61, 24);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(67, 24);
            btnOpen.Text = "Open";
            btnOpen.Click += btnOpen_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 54);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1222, 664);
            splitContainer1.SplitterDistance = 252;
            splitContainer1.TabIndex = 2;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(listBoxContacts);
            panelLeft.Controls.Add(txtSearch);
            panelLeft.Controls.Add(lblSearchContacts);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10, 10, 10, 10);
            panelLeft.Size = new Size(252, 664);
            panelLeft.TabIndex = 0;
            // 
            // listBoxContacts
            // 
            listBoxContacts.Dock = DockStyle.Fill;
            listBoxContacts.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxContacts.Font = new Font("Segoe UI", 10F);
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.ItemHeight = 60;
            listBoxContacts.Location = new Point(10, 52);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(232, 602);
            listBoxContacts.TabIndex = 2;
            listBoxContacts.DrawItem += listBoxContacts_DrawItem;
            listBoxContacts.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(10, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type to search...";
            txtSearch.Size = new Size(232, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearchContacts
            // 
            lblSearchContacts.Dock = DockStyle.Top;
            lblSearchContacts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearchContacts.Location = new Point(10, 10);
            lblSearchContacts.Name = "lblSearchContacts";
            lblSearchContacts.Size = new Size(232, 17);
            lblSearchContacts.TabIndex = 0;
            lblSearchContacts.Text = "Search Contacts:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPersonalInfo);
            tabControl1.Controls.Add(tabTasks);
            tabControl1.Controls.Add(tabNotes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 664);
            tabControl1.TabIndex = 0;
            // 
            // tabPersonalInfo
            // 
            tabPersonalInfo.Controls.Add(panelPersonalInfo);
            tabPersonalInfo.Location = new Point(4, 26);
            tabPersonalInfo.Name = "tabPersonalInfo";
            tabPersonalInfo.Padding = new Padding(3, 3, 3, 3);
            tabPersonalInfo.Size = new Size(958, 634);
            tabPersonalInfo.TabIndex = 0;
            tabPersonalInfo.Text = "Personal Info";
            tabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // panelPersonalInfo
            // 
            panelPersonalInfo.AutoScroll = true;
            panelPersonalInfo.Controls.Add(btnCancel);
            panelPersonalInfo.Controls.Add(btnSaveChanges);
            panelPersonalInfo.Controls.Add(groupBoxAdditionalInfo);
            panelPersonalInfo.Controls.Add(groupBoxContactDetails);
            panelPersonalInfo.Controls.Add(groupBoxProfile);
            panelPersonalInfo.Dock = DockStyle.Fill;
            panelPersonalInfo.Location = new Point(3, 3);
            panelPersonalInfo.Name = "panelPersonalInfo";
            panelPersonalInfo.Padding = new Padding(20, 20, 20, 20);
            panelPersonalInfo.Size = new Size(952, 628);
            panelPersonalInfo.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(742, 588);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveChanges.BackColor = Color.FromArgb(0, 120, 215);
            btnSaveChanges.Font = new Font("Segoe UI", 10F);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(837, 588);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(110, 30);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Visible = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // groupBoxAdditionalInfo
            // 
            groupBoxAdditionalInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAdditionalInfo.Controls.Add(dtpBirthday);
            groupBoxAdditionalInfo.Controls.Add(lblBirthday);
            groupBoxAdditionalInfo.Controls.Add(txtJobTitle);
            groupBoxAdditionalInfo.Controls.Add(lblJobTitle);
            groupBoxAdditionalInfo.Controls.Add(txtDepartment);
            groupBoxAdditionalInfo.Controls.Add(lblDepartment);
            groupBoxAdditionalInfo.Controls.Add(txtCompany);
            groupBoxAdditionalInfo.Controls.Add(lblCompany);
            groupBoxAdditionalInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAdditionalInfo.Location = new Point(23, 466);
            groupBoxAdditionalInfo.Name = "groupBoxAdditionalInfo";
            groupBoxAdditionalInfo.Padding = new Padding(15, 15, 15, 15);
            groupBoxAdditionalInfo.Size = new Size(906, 115);
            groupBoxAdditionalInfo.TabIndex = 2;
            groupBoxAdditionalInfo.TabStop = false;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpBirthday.Font = new Font("Segoe UI", 10F);
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(486, 70);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(400, 25);
            dtpBirthday.TabIndex = 7;
            // 
            // lblBirthday
            // 
            lblBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBirthday.Location = new Point(486, 52);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(70, 19);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Birthday:";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtJobTitle.Font = new Font("Segoe UI", 10F);
            txtJobTitle.Location = new Point(486, 31);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(400, 25);
            txtJobTitle.TabIndex = 5;
            // 
            // lblJobTitle
            // 
            lblJobTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJobTitle.Location = new Point(486, 13);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(70, 19);
            lblJobTitle.TabIndex = 4;
            lblJobTitle.Text = "Job Title:";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 10F);
            txtDepartment.Location = new Point(18, 70);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(443, 25);
            txtDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDepartment.Location = new Point(18, 52);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(93, 19);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department:";
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Segoe UI", 10F);
            txtCompany.Location = new Point(18, 31);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(443, 25);
            txtCompany.TabIndex = 1;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompany.Location = new Point(18, 13);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(77, 19);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "Company:";
            // 
            // groupBoxContactDetails
            // 
            groupBoxContactDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxContactDetails.Controls.Add(label1);
            groupBoxContactDetails.Controls.Add(cmbCountry);
            groupBoxContactDetails.Controls.Add(lblCountry);
            groupBoxContactDetails.Controls.Add(txtZipCode);
            groupBoxContactDetails.Controls.Add(lblZipCode);
            groupBoxContactDetails.Controls.Add(cmbState);
            groupBoxContactDetails.Controls.Add(lblState);
            groupBoxContactDetails.Controls.Add(txtCity);
            groupBoxContactDetails.Controls.Add(lblCity);
            groupBoxContactDetails.Controls.Add(txtAddress);
            groupBoxContactDetails.Controls.Add(lblAddress);
            groupBoxContactDetails.Controls.Add(txtMobileNumber);
            groupBoxContactDetails.Controls.Add(lblMobileNumber);
            groupBoxContactDetails.Controls.Add(txtPhoneNumber);
            groupBoxContactDetails.Controls.Add(lblPhoneNumber);
            groupBoxContactDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxContactDetails.Location = new Point(23, 220);
            groupBoxContactDetails.Name = "groupBoxContactDetails";
            groupBoxContactDetails.Padding = new Padding(15, 15, 15, 15);
            groupBoxContactDetails.Size = new Size(906, 240);
            groupBoxContactDetails.TabIndex = 1;
            groupBoxContactDetails.TabStop = false;
            groupBoxContactDetails.Enter += groupBoxContactDetails_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 14;
            label1.Text = "Contact Details";
            label1.Click += label1_Click;
            // 
            // cmbCountry
            // 
            cmbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCountry.Font = new Font("Segoe UI", 10F);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(486, 207);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(400, 25);
            cmbCountry.TabIndex = 13;
            // 
            // lblCountry
            // 
            lblCountry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCountry.Location = new Point(486, 185);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(67, 19);
            lblCountry.TabIndex = 12;
            lblCountry.Text = "Country:";
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Segoe UI", 10F);
            txtZipCode.Location = new Point(18, 207);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(443, 25);
            txtZipCode.TabIndex = 11;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblZipCode.Location = new Point(18, 189);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(74, 19);
            lblZipCode.TabIndex = 10;
            lblZipCode.Text = "ZIP Code:";
            // 
            // cmbState
            // 
            cmbState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbState.Font = new Font("Segoe UI", 10F);
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(486, 163);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(400, 25);
            cmbState.TabIndex = 9;
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblState.Location = new Point(486, 146);
            lblState.Name = "lblState";
            lblState.Size = new Size(47, 19);
            lblState.TabIndex = 8;
            lblState.Text = "State:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(18, 163);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(443, 25);
            txtCity.TabIndex = 7;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.Location = new Point(18, 145);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 19);
            lblCity.TabIndex = 6;
            lblCity.Text = "City:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(18, 119);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(868, 25);
            txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.Location = new Point(18, 101);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(67, 19);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMobileNumber.Font = new Font("Segoe UI", 10F);
            txtMobileNumber.Location = new Point(486, 75);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(400, 25);
            txtMobileNumber.TabIndex = 3;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMobileNumber.Location = new Point(486, 56);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(120, 19);
            lblMobileNumber.TabIndex = 2;
            lblMobileNumber.Text = "Mobile Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtPhoneNumber.Location = new Point(18, 75);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(443, 25);
            txtPhoneNumber.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(18, 57);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(115, 19);
            lblPhoneNumber.TabIndex = 0;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // groupBoxProfile
            // 
            groupBoxProfile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProfile.Controls.Add(btnChangePhoto);
            groupBoxProfile.Controls.Add(pictureBoxProfile);
            groupBoxProfile.Controls.Add(txtEmail);
            groupBoxProfile.Controls.Add(lblEmail);
            groupBoxProfile.Controls.Add(txtLastName);
            groupBoxProfile.Controls.Add(lblLastName);
            groupBoxProfile.Controls.Add(txtFirstName);
            groupBoxProfile.Controls.Add(lblFirstName);
            groupBoxProfile.Controls.Add(lblProfile);
            groupBoxProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProfile.Location = new Point(23, 23);
            groupBoxProfile.Name = "groupBoxProfile";
            groupBoxProfile.Padding = new Padding(15, 15, 15, 15);
            groupBoxProfile.Size = new Size(906, 182);
            groupBoxProfile.TabIndex = 0;
            groupBoxProfile.TabStop = false;
            groupBoxProfile.Enter += groupBoxProfile_Enter;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.Font = new Font("Segoe UI", 10F);
            btnChangePhoto.Location = new Point(18, 141);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.Size = new Size(100, 25);
            btnChangePhoto.TabIndex = 8;
            btnChangePhoto.Text = "Change Photo";
            btnChangePhoto.UseVisualStyleBackColor = true;
            btnChangePhoto.Click += btnChangePhoto_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProfile.Location = new Point(18, 40);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(100, 100);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 7;
            pictureBoxProfile.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(140, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(746, 25);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(140, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(117, 19);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email Address: *";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(651, 73);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(235, 25);
            txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(651, 55);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(83, 19);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(140, 73);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(235, 25);
            txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(140, 55);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(85, 19);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfile.Location = new Point(18, 15);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(54, 19);
            lblProfile.TabIndex = 0;
            lblProfile.Text = "Profile";
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(panelTasks);
            tabTasks.Location = new Point(4, 26);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3, 3, 3, 3);
            tabTasks.Size = new Size(958, 634);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Tasks";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // panelTasks
            // 
            panelTasks.Controls.Add(panelTaskStatistics);
            panelTasks.Controls.Add(groupBoxTaskList);
            panelTasks.Controls.Add(panelTaskHeader);
            panelTasks.Dock = DockStyle.Fill;
            panelTasks.Location = new Point(3, 3);
            panelTasks.Margin = new Padding(3, 2, 3, 2);
            panelTasks.Name = "panelTasks";
            panelTasks.Padding = new Padding(20, 20, 20, 20);
            panelTasks.Size = new Size(952, 628);
            panelTasks.TabIndex = 0;
            // 
            // panelTaskStatistics
            // 
            panelTaskStatistics.Controls.Add(lblUrgentValue);
            panelTaskStatistics.Controls.Add(lblUrgentLabel);
            panelTaskStatistics.Controls.Add(lblInProgressValue);
            panelTaskStatistics.Controls.Add(lblInProgressLabel);
            panelTaskStatistics.Controls.Add(lblCompletedValue);
            panelTaskStatistics.Controls.Add(lblCompletedLabel);
            panelTaskStatistics.Controls.Add(lblTotalTasksValue);
            panelTaskStatistics.Controls.Add(lblTotalTasksLabel);
            panelTaskStatistics.Controls.Add(lblTaskStatistics);
            panelTaskStatistics.Dock = DockStyle.Bottom;
            panelTaskStatistics.Location = new Point(20, 496);
            panelTaskStatistics.Margin = new Padding(3, 2, 3, 2);
            panelTaskStatistics.Name = "panelTaskStatistics";
            panelTaskStatistics.Size = new Size(912, 112);
            panelTaskStatistics.TabIndex = 2;
            // 
            // lblUrgentValue
            // 
            lblUrgentValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblUrgentValue.ForeColor = Color.Red;
            lblUrgentValue.Location = new Point(615, 38);
            lblUrgentValue.Name = "lblUrgentValue";
            lblUrgentValue.Size = new Size(105, 45);
            lblUrgentValue.TabIndex = 8;
            lblUrgentValue.Text = "0";
            lblUrgentValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUrgentLabel
            // 
            lblUrgentLabel.AutoSize = true;
            lblUrgentLabel.Font = new Font("Segoe UI", 9F);
            lblUrgentLabel.ForeColor = Color.Gray;
            lblUrgentLabel.Location = new Point(639, 82);
            lblUrgentLabel.Name = "lblUrgentLabel";
            lblUrgentLabel.Size = new Size(43, 15);
            lblUrgentLabel.TabIndex = 7;
            lblUrgentLabel.Text = "Urgent";
            lblUrgentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInProgressValue
            // 
            lblInProgressValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblInProgressValue.ForeColor = Color.Orange;
            lblInProgressValue.Location = new Point(440, 38);
            lblInProgressValue.Name = "lblInProgressValue";
            lblInProgressValue.Size = new Size(105, 45);
            lblInProgressValue.TabIndex = 6;
            lblInProgressValue.Text = "0";
            lblInProgressValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInProgressLabel
            // 
            lblInProgressLabel.AutoSize = true;
            lblInProgressLabel.Font = new Font("Segoe UI", 9F);
            lblInProgressLabel.ForeColor = Color.Gray;
            lblInProgressLabel.Location = new Point(452, 82);
            lblInProgressLabel.Name = "lblInProgressLabel";
            lblInProgressLabel.Size = new Size(65, 15);
            lblInProgressLabel.TabIndex = 5;
            lblInProgressLabel.Text = "In Progress";
            lblInProgressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompletedValue
            // 
            lblCompletedValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCompletedValue.ForeColor = Color.Green;
            lblCompletedValue.Location = new Point(265, 38);
            lblCompletedValue.Name = "lblCompletedValue";
            lblCompletedValue.Size = new Size(105, 45);
            lblCompletedValue.TabIndex = 4;
            lblCompletedValue.Text = "0";
            lblCompletedValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompletedLabel
            // 
            lblCompletedLabel.AutoSize = true;
            lblCompletedLabel.Font = new Font("Segoe UI", 9F);
            lblCompletedLabel.ForeColor = Color.Gray;
            lblCompletedLabel.Location = new Point(283, 82);
            lblCompletedLabel.Name = "lblCompletedLabel";
            lblCompletedLabel.Size = new Size(66, 15);
            lblCompletedLabel.TabIndex = 3;
            lblCompletedLabel.Text = "Completed";
            lblCompletedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTasksValue
            // 
            lblTotalTasksValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalTasksValue.Location = new Point(90, 38);
            lblTotalTasksValue.Name = "lblTotalTasksValue";
            lblTotalTasksValue.Size = new Size(105, 45);
            lblTotalTasksValue.TabIndex = 2;
            lblTotalTasksValue.Text = "0";
            lblTotalTasksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTasksLabel
            // 
            lblTotalTasksLabel.AutoSize = true;
            lblTotalTasksLabel.Font = new Font("Segoe UI", 9F);
            lblTotalTasksLabel.ForeColor = Color.Gray;
            lblTotalTasksLabel.Location = new Point(108, 82);
            lblTotalTasksLabel.Name = "lblTotalTasksLabel";
            lblTotalTasksLabel.Size = new Size(64, 15);
            lblTotalTasksLabel.TabIndex = 1;
            lblTotalTasksLabel.Text = "Total Tasks";
            lblTotalTasksLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTaskStatistics
            // 
            lblTaskStatistics.AutoSize = true;
            lblTaskStatistics.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTaskStatistics.Location = new Point(3, 8);
            lblTaskStatistics.Name = "lblTaskStatistics";
            lblTaskStatistics.Size = new Size(115, 21);
            lblTaskStatistics.TabIndex = 0;
            lblTaskStatistics.Text = "Task Statistics";
            // 
            // groupBoxTaskList
            // 
            groupBoxTaskList.Controls.Add(dgvTasks);
            groupBoxTaskList.Dock = DockStyle.Fill;
            groupBoxTaskList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxTaskList.Location = new Point(20, 58);
            groupBoxTaskList.Margin = new Padding(3, 2, 3, 2);
            groupBoxTaskList.Name = "groupBoxTaskList";
            groupBoxTaskList.Padding = new Padding(13, 11, 13, 11);
            groupBoxTaskList.Size = new Size(912, 550);
            groupBoxTaskList.TabIndex = 1;
            groupBoxTaskList.TabStop = false;
            groupBoxTaskList.Text = "Task List";
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.BackgroundColor = Color.White;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Font = new Font("Segoe UI", 10F);
            dgvTasks.Location = new Point(13, 29);
            dgvTasks.Margin = new Padding(3, 2, 3, 2);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(886, 510);
            dgvTasks.TabIndex = 0;
            // 
            // panelTaskHeader
            // 
            panelTaskHeader.Controls.Add(btnAddNewTask);
            panelTaskHeader.Controls.Add(lblTasksFor);
            panelTaskHeader.Dock = DockStyle.Top;
            panelTaskHeader.Location = new Point(20, 20);
            panelTaskHeader.Margin = new Padding(3, 2, 3, 2);
            panelTaskHeader.Name = "panelTaskHeader";
            panelTaskHeader.Size = new Size(912, 38);
            panelTaskHeader.TabIndex = 0;
            // 
            // btnAddNewTask
            // 
            btnAddNewTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewTask.Font = new Font("Segoe UI", 10F);
            btnAddNewTask.Location = new Point(779, 4);
            btnAddNewTask.Margin = new Padding(3, 2, 3, 2);
            btnAddNewTask.Name = "btnAddNewTask";
            btnAddNewTask.Size = new Size(130, 30);
            btnAddNewTask.TabIndex = 1;
            btnAddNewTask.Text = "+ Add New Task";
            btnAddNewTask.UseVisualStyleBackColor = true;
            btnAddNewTask.Click += btnAddNewTask_Click;

            // 
            // lblTasksFor
            // 
            lblTasksFor.AutoSize = true;
            lblTasksFor.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTasksFor.Location = new Point(3, 8);
            lblTasksFor.Name = "lblTasksFor";
            lblTasksFor.Size = new Size(164, 25);
            lblTasksFor.TabIndex = 0;
            lblTasksFor.Text = "Tasks for Contact";
            // 
            // tabNotes
            // 
            tabNotes.Controls.Add(txtNotes);
            tabNotes.Location = new Point(4, 26);
            tabNotes.Name = "tabNotes";
            tabNotes.Padding = new Padding(3, 3, 3, 3);
            tabNotes.Size = new Size(956, 641);
            tabNotes.TabIndex = 2;
            tabNotes.Text = "Notes";
            tabNotes.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Font = new Font("Segoe UI", 10F);
            txtNotes.Location = new Point(3, 3);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(950, 635);
            txtNotes.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 718);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Contact Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPersonalInfo.ResumeLayout(false);
            panelPersonalInfo.ResumeLayout(false);
            groupBoxAdditionalInfo.ResumeLayout(false);
            groupBoxAdditionalInfo.PerformLayout();
            groupBoxContactDetails.ResumeLayout(false);
            groupBoxContactDetails.PerformLayout();
            groupBoxProfile.ResumeLayout(false);
            groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            tabTasks.ResumeLayout(false);
            panelTasks.ResumeLayout(false);
            panelTaskStatistics.ResumeLayout(false);
            panelTaskStatistics.PerformLayout();
            groupBoxTaskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            panelTaskHeader.ResumeLayout(false);
            panelTaskHeader.PerformLayout();
            tabNotes.ResumeLayout(false);
            tabNotes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnSave;
        private ToolStripButton btnOpen;
        private SplitContainer splitContainer1;
        private Panel panelLeft;
        private TextBox txtSearch;
        private Label lblSearchContacts;
        private ListBox listBoxContacts;
        private TabControl tabControl1;
        private TabPage tabPersonalInfo;
        private Panel panelPersonalInfo;
        private GroupBox groupBoxProfile;
        private Label lblProfile;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private PictureBox pictureBoxProfile;
        private Button btnChangePhoto;
        private GroupBox groupBoxContactDetails;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblMobileNumber;
        private TextBox txtMobileNumber;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblState;
        private ComboBox cmbState;
        private Label lblZipCode;
        private TextBox txtZipCode;
        private Label lblCountry;
        private ComboBox cmbCountry;
        private GroupBox groupBoxAdditionalInfo;
        private Label lblCompany;
        private TextBox txtCompany;
        private Label lblDepartment;
        private TextBox txtDepartment;
        private Label lblJobTitle;
        private TextBox txtJobTitle;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label label1;
        private TabPage tabTasks;
        private Panel panelTasks;
        private Panel panelTaskHeader;
        private Label lblTasksFor;
        private Button btnAddNewTask;
        private GroupBox groupBoxTaskList;
        private DataGridView dgvTasks;
        private Panel panelTaskStatistics;
        private Label lblTaskStatistics;
        private Label lblTotalTasksLabel;
        private Label lblTotalTasksValue;
        private Label lblCompletedLabel;
        private Label lblCompletedValue;
        private Label lblInProgressLabel;
        private Label lblInProgressValue;
        private Label lblUrgentLabel;
        private Label lblUrgentValue;
        private TabPage tabNotes;
        private TextBox txtNotes;
    }
}
