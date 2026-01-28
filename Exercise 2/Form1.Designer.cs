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
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1396, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(53, 27);
            editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(59, 27);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10F);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnDelete, toolStripSeparator1, btnSave, btnOpen });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1396, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 27);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(63, 27);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 27);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(69, 27);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(76, 27);
            btnOpen.Text = "Open";
            btnOpen.Click += btnOpen_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 63);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1396, 895);
            splitContainer1.SplitterDistance = 289;
            splitContainer1.SplitterWidth = 5;
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
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(11, 13, 11, 13);
            panelLeft.Size = new Size(289, 895);
            panelLeft.TabIndex = 0;
            // 
            // listBoxContacts
            // 
            listBoxContacts.Dock = DockStyle.Fill;
            listBoxContacts.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxContacts.Font = new Font("Segoe UI", 10F);
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.ItemHeight = 60;
            listBoxContacts.Location = new Point(11, 66);
            listBoxContacts.Margin = new Padding(3, 4, 3, 4);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(267, 816);
            listBoxContacts.TabIndex = 2;
            listBoxContacts.DrawItem += listBoxContacts_DrawItem;
            listBoxContacts.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(11, 36);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type to search...";
            txtSearch.Size = new Size(267, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearchContacts
            // 
            lblSearchContacts.Dock = DockStyle.Top;
            lblSearchContacts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearchContacts.Location = new Point(11, 13);
            lblSearchContacts.Name = "lblSearchContacts";
            lblSearchContacts.Size = new Size(267, 23);
            lblSearchContacts.TabIndex = 0;
            lblSearchContacts.Text = "Search Contacts:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPersonalInfo);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1102, 895);
            tabControl1.TabIndex = 0;
            // 
            // tabPersonalInfo
            // 
            tabPersonalInfo.Controls.Add(panelPersonalInfo);
            tabPersonalInfo.Location = new Point(4, 32);
            tabPersonalInfo.Margin = new Padding(3, 4, 3, 4);
            tabPersonalInfo.Name = "tabPersonalInfo";
            tabPersonalInfo.Padding = new Padding(3, 4, 3, 4);
            tabPersonalInfo.Size = new Size(1094, 859);
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
            panelPersonalInfo.Location = new Point(3, 4);
            panelPersonalInfo.Margin = new Padding(3, 4, 3, 4);
            panelPersonalInfo.Name = "panelPersonalInfo";
            panelPersonalInfo.Padding = new Padding(23, 27, 23, 27);
            panelPersonalInfo.Size = new Size(1088, 851);
            panelPersonalInfo.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(848, 795);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 40);
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
            btnSaveChanges.Location = new Point(957, 795);
            btnSaveChanges.Margin = new Padding(3, 4, 3, 4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(126, 40);
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
            groupBoxAdditionalInfo.Location = new Point(26, 621);
            groupBoxAdditionalInfo.Margin = new Padding(3, 4, 3, 4);
            groupBoxAdditionalInfo.Name = "groupBoxAdditionalInfo";
            groupBoxAdditionalInfo.Padding = new Padding(17, 20, 17, 20);
            groupBoxAdditionalInfo.Size = new Size(1035, 153);
            groupBoxAdditionalInfo.TabIndex = 2;
            groupBoxAdditionalInfo.TabStop = false;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpBirthday.Font = new Font("Segoe UI", 10F);
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(556, 93);
            dtpBirthday.Margin = new Padding(3, 4, 3, 4);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(457, 30);
            dtpBirthday.TabIndex = 7;
            // 
            // lblBirthday
            // 
            lblBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBirthday.Location = new Point(556, 69);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(84, 23);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Birthday:";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtJobTitle.Font = new Font("Segoe UI", 10F);
            txtJobTitle.Location = new Point(556, 41);
            txtJobTitle.Margin = new Padding(3, 4, 3, 4);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(457, 30);
            txtJobTitle.TabIndex = 5;
            // 
            // lblJobTitle
            // 
            lblJobTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJobTitle.Location = new Point(556, 17);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(85, 23);
            lblJobTitle.TabIndex = 4;
            lblJobTitle.Text = "Job Title:";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 10F);
            txtDepartment.Location = new Point(21, 93);
            txtDepartment.Margin = new Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(506, 30);
            txtDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDepartment.Location = new Point(21, 69);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(113, 23);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department:";
            // 
            // txtCompany
            // 
            txtCompany.Font = new Font("Segoe UI", 10F);
            txtCompany.Location = new Point(21, 41);
            txtCompany.Margin = new Padding(3, 4, 3, 4);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(506, 30);
            txtCompany.TabIndex = 1;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompany.Location = new Point(21, 17);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(91, 23);
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
            groupBoxContactDetails.Location = new Point(26, 293);
            groupBoxContactDetails.Margin = new Padding(3, 4, 3, 4);
            groupBoxContactDetails.Name = "groupBoxContactDetails";
            groupBoxContactDetails.Padding = new Padding(17, 20, 17, 20);
            groupBoxContactDetails.Size = new Size(1035, 320);
            groupBoxContactDetails.TabIndex = 1;
            groupBoxContactDetails.TabStop = false;
            groupBoxContactDetails.Enter += groupBoxContactDetails_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 14;
            label1.Text = "Contact Details";
            label1.Click += label1_Click;
            // 
            // cmbCountry
            // 
            cmbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbCountry.Font = new Font("Segoe UI", 10F);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(556, 276);
            cmbCountry.Margin = new Padding(3, 4, 3, 4);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(457, 31);
            cmbCountry.TabIndex = 13;
            // 
            // lblCountry
            // 
            lblCountry.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCountry.Location = new Point(556, 247);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(80, 23);
            lblCountry.TabIndex = 12;
            lblCountry.Text = "Country:";
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Segoe UI", 10F);
            txtZipCode.Location = new Point(21, 276);
            txtZipCode.Margin = new Padding(3, 4, 3, 4);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(506, 30);
            txtZipCode.TabIndex = 11;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblZipCode.Location = new Point(21, 252);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(86, 23);
            lblZipCode.TabIndex = 10;
            lblZipCode.Text = "ZIP Code:";
            // 
            // cmbState
            // 
            cmbState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbState.Font = new Font("Segoe UI", 10F);
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(556, 217);
            cmbState.Margin = new Padding(3, 4, 3, 4);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(457, 31);
            cmbState.TabIndex = 9;
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblState.Location = new Point(556, 195);
            lblState.Name = "lblState";
            lblState.Size = new Size(57, 23);
            lblState.TabIndex = 8;
            lblState.Text = "State:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.Location = new Point(21, 217);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(506, 30);
            txtCity.TabIndex = 7;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.Location = new Point(21, 193);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(47, 23);
            lblCity.TabIndex = 6;
            lblCity.Text = "City:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(21, 159);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(992, 30);
            txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.Location = new Point(21, 135);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 23);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMobileNumber.Font = new Font("Segoe UI", 10F);
            txtMobileNumber.Location = new Point(556, 100);
            txtMobileNumber.Margin = new Padding(3, 4, 3, 4);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(457, 30);
            txtMobileNumber.TabIndex = 3;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMobileNumber.Location = new Point(555, 75);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(143, 23);
            lblMobileNumber.TabIndex = 2;
            lblMobileNumber.Text = "Mobile Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtPhoneNumber.Location = new Point(21, 100);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(506, 30);
            txtPhoneNumber.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(21, 76);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(136, 23);
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
            groupBoxProfile.Location = new Point(26, 31);
            groupBoxProfile.Margin = new Padding(3, 4, 3, 4);
            groupBoxProfile.Name = "groupBoxProfile";
            groupBoxProfile.Padding = new Padding(17, 20, 17, 20);
            groupBoxProfile.Size = new Size(1035, 243);
            groupBoxProfile.TabIndex = 0;
            groupBoxProfile.TabStop = false;
            groupBoxProfile.Enter += groupBoxProfile_Enter;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.Font = new Font("Segoe UI", 10F);
            btnChangePhoto.Location = new Point(21, 188);
            btnChangePhoto.Margin = new Padding(3, 4, 3, 4);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.Size = new Size(114, 33);
            btnChangePhoto.TabIndex = 8;
            btnChangePhoto.Text = "Change Photo";
            btnChangePhoto.UseVisualStyleBackColor = true;
            btnChangePhoto.Click += btnChangePhoto_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProfile.Location = new Point(21, 53);
            pictureBoxProfile.Margin = new Padding(3, 4, 3, 4);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(114, 133);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 7;
            pictureBoxProfile.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(160, 156);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(852, 30);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(160, 132);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(141, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email Address: *";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(744, 97);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(268, 30);
            txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(744, 73);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(160, 97);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(268, 30);
            txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(160, 73);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(102, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfile.Location = new Point(21, 20);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(63, 23);
            lblProfile.TabIndex = 0;
            lblProfile.Text = "Profile";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 958);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
