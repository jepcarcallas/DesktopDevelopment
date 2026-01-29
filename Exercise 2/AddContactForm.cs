using ContactsManager.models;

namespace Exercise2
{
    public partial class AddContactForm : Form
    {
        public Contact? NewContact { get; private set; }

        public AddContactForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Add New Contact";
            this.Size = new Size(560, 800);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            // Create scrollable panel
            Panel mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(20)
            };
            this.Controls.Add(mainPanel);

            int yPosition = 10;

            // Personal Information Section
            Label lblPersonalInfo = CreateSectionLabel("Personal Information", yPosition);
            mainPanel.Controls.Add(lblPersonalInfo);
            yPosition += 35;

            // First Name
            Label lblFirstName = new Label
            {
                Text = "First Name: *",
                Location = new Point(20, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblFirstName);

            TextBox txtFirstName = new TextBox
            {
                Name = "txtFirstName",
                Location = new Point(20, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter first name"
            };
            mainPanel.Controls.Add(txtFirstName);

            // Last Name
            Label lblLastName = new Label
            {
                Text = "Last Name: *",
                Location = new Point(270, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblLastName);

            TextBox txtLastName = new TextBox
            {
                Name = "txtLastName",
                Location = new Point(270, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter last name"
            };
            mainPanel.Controls.Add(txtLastName);
            yPosition += 60;

            // Email Address
            Label lblEmail = new Label
            {
                Text = "Email Address: *",
                Location = new Point(20, yPosition),
                Size = new Size(480, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox
            {
                Name = "txtEmail",
                Location = new Point(20, yPosition + 20),
                Size = new Size(480, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter email address"
            };
            mainPanel.Controls.Add(txtEmail);

            Label lblEmailError = new Label
            {
                Name = "lblEmailError",
                Text = "! Please enter a valid email address",
                Location = new Point(20, yPosition + 48),
                Size = new Size(480, 20),
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Red,
                Visible = false
            };
            mainPanel.Controls.Add(lblEmailError);
            yPosition += 95;

            // Contact Details Section
            Label lblContactDetails = CreateSectionLabel("Contact Details", yPosition);
            mainPanel.Controls.Add(lblContactDetails);
            yPosition += 35;

            // Phone Number
            Label lblPhone = new Label
            {
                Text = "Phone Number:",
                Location = new Point(20, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblPhone);

            TextBox txtPhone = new TextBox
            {
                Name = "txtPhone",
                Location = new Point(20, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "(555) 000-0000"
            };
            mainPanel.Controls.Add(txtPhone);

            // Mobile Number
            Label lblMobile = new Label
            {
                Text = "Mobile Number:",
                Location = new Point(270, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblMobile);

            TextBox txtMobile = new TextBox
            {
                Name = "txtMobile",
                Location = new Point(270, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "(555) 000-0000"
            };
            mainPanel.Controls.Add(txtMobile);
            yPosition += 60;

            // Company
            Label lblCompany = new Label
            {
                Text = "Company:",
                Location = new Point(20, yPosition),
                Size = new Size(480, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblCompany);

            TextBox txtCompany = new TextBox
            {
                Name = "txtCompany",
                Location = new Point(20, yPosition + 20),
                Size = new Size(480, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter company name"
            };
            mainPanel.Controls.Add(txtCompany);
            yPosition += 60;

            // Job Title
            Label lblJobTitle = new Label
            {
                Text = "Job Title:",
                Location = new Point(20, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblJobTitle);

            TextBox txtJobTitle = new TextBox
            {
                Name = "txtJobTitle",
                Location = new Point(20, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter job title"
            };
            mainPanel.Controls.Add(txtJobTitle);

            // Department
            Label lblDepartment = new Label
            {
                Text = "Department:",
                Location = new Point(270, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblDepartment);

            TextBox txtDepartment = new TextBox
            {
                Name = "txtDepartment",
                Location = new Point(270, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter department"
            };
            mainPanel.Controls.Add(txtDepartment);
            yPosition += 70;

            // Address Information Section
            Label lblAddressInfo = CreateSectionLabel("Address Information", yPosition);
            mainPanel.Controls.Add(lblAddressInfo);
            yPosition += 35;

            // Street Address
            Label lblAddress = new Label
            {
                Text = "Street Address:",
                Location = new Point(20, yPosition),
                Size = new Size(480, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblAddress);

            TextBox txtAddress = new TextBox
            {
                Name = "txtAddress",
                Location = new Point(20, yPosition + 20),
                Size = new Size(480, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter street address"
            };
            mainPanel.Controls.Add(txtAddress);
            yPosition += 60;

            // City
            Label lblCity = new Label
            {
                Text = "City:",
                Location = new Point(20, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblCity);

            TextBox txtCity = new TextBox
            {
                Name = "txtCity",
                Location = new Point(20, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "Enter city"
            };
            mainPanel.Controls.Add(txtCity);

            // State
            Label lblState = new Label
            {
                Text = "State:",
                Location = new Point(270, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblState);

            ComboBox cmbState = new ComboBox
            {
                Name = "cmbState",
                Location = new Point(270, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
                "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
                "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
                "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            cmbState.Items.AddRange(states);
            cmbState.Items.Insert(0, "Select state...");
            cmbState.SelectedIndex = 0;
            mainPanel.Controls.Add(cmbState);
            yPosition += 60;

            // ZIP Code
            Label lblZip = new Label
            {
                Text = "ZIP Code:",
                Location = new Point(20, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblZip);

            TextBox txtZip = new TextBox
            {
                Name = "txtZip",
                Location = new Point(20, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                PlaceholderText = "00000"
            };
            mainPanel.Controls.Add(txtZip);

            // Country
            Label lblCountry = new Label
            {
                Text = "Country:",
                Location = new Point(270, yPosition),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            mainPanel.Controls.Add(lblCountry);

            TextBox txtCountry = new TextBox
            {
                Name = "txtCountry",
                Location = new Point(270, yPosition + 20),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 9),
                Text = "United States"
            };
            mainPanel.Controls.Add(txtCountry);
            yPosition += 70;

            // Note about required fields
            Panel notePanel = new Panel
            {
                Location = new Point(20, yPosition),
                Size = new Size(480, 40),
                BackColor = Color.FromArgb(255, 244, 206),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblNote = new Label
            {
                Text = "? Note: Fields marked with * are required. Please ensure all required information is entered before saving.",
                Location = new Point(10, 10),
                Size = new Size(460, 20),
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.FromArgb(133, 100, 4)
            };
            notePanel.Controls.Add(lblNote);
            mainPanel.Controls.Add(notePanel);
            yPosition += 60;

            // Buttons Panel
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.White,
                Padding = new Padding(20, 10, 20, 10)
            };

            Button btnSave = new Button
            {
                Text = "Save Contact",
                Size = new Size(130, 35),
                Location = new Point(410, 12),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += (s, e) => BtnSave_Click(txtFirstName, txtLastName, txtEmail, lblEmailError,
                txtPhone, txtMobile, txtCompany, txtJobTitle, txtDepartment,
                txtAddress, txtCity, cmbState, txtZip, txtCountry);
            buttonPanel.Controls.Add(btnSave);

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Size = new Size(90, 35),
                Location = new Point(310, 12),
                Font = new Font("Segoe UI", 10),
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            buttonPanel.Controls.Add(btnCancel);

            this.Controls.Add(buttonPanel);
        }

        private Label CreateSectionLabel(string text, int yPosition)
        {
            return new Label
            {
                Text = text,
                Location = new Point(20, yPosition),
                Size = new Size(480, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 0, 0)
            };
        }

        private void BtnSave_Click(TextBox txtFirstName, TextBox txtLastName, TextBox txtEmail, Label lblEmailError,
            TextBox txtPhone, TextBox txtMobile, TextBox txtCompany, TextBox txtJobTitle, TextBox txtDepartment,
            TextBox txtAddress, TextBox txtCity, ComboBox cmbState, TextBox txtZip, TextBox txtCountry)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter a last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                lblEmailError.Visible = true;
                txtEmail.BackColor = Color.FromArgb(255, 240, 240);
                txtEmail.Focus();
                return;
            }

            lblEmailError.Visible = false;
            txtEmail.BackColor = Color.White;

            // Create new contact
            NewContact = new Contact
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                MobileNumber = txtMobile.Text.Trim(),
                Company = txtCompany.Text.Trim(),
                JobTitle = txtJobTitle.Text.Trim(),
                Department = txtDepartment.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                State = cmbState.SelectedIndex > 0 ? cmbState.Text : "",
                ZipCode = txtZip.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Birthday = DateTime.Today
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && email.Contains("@") && email.Contains(".");
            }
            catch
            {
                return false;
            }
        }
    }
}
