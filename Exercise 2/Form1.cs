using System.Text.Json;
using ContactsManager.models;

namespace Exercise2
{
    public partial class Form1 : Form
{
    private List<Contact> contacts = new();
    private List<Contact> filteredContacts = new();
    private Contact? currentContact = null;
    private bool isEditing = false;

    public Form1()
    {
        InitializeComponent();
        InitializeControls();
        LoadSampleData();
    }

    private string GetImagePath(string relativePath)
    {
        if (string.IsNullOrEmpty(relativePath))
            return string.Empty;

        // Try relative path from application directory
        string appPath = Path.Combine(Application.StartupPath, relativePath);
        if (File.Exists(appPath))
            return appPath;

        // Try relative path from solution directory (for debugging)
        string solutionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", relativePath);
        solutionPath = Path.GetFullPath(solutionPath);
        if (File.Exists(solutionPath))
            return solutionPath;

        return relativePath;
    }

    private void InitializeControls()
    {
        PopulateStates();
        PopulateCountries();
        InitializeTasksDataGridView();
        SetEditMode(false);
    }

    private void PopulateStates()
    {
        string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
                "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
                "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
                "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
        cmbState.Items.AddRange(states);
    }

    private void PopulateCountries()
    {
        string[] countries = { "United States", "Canada", "Mexico", "United Kingdom", "Australia", "Germany", "France", "Japan", "China", "India" };
        cmbCountry.Items.AddRange(countries);
    }

    private void LoadSampleData()
    {
        contacts.Add(new Contact
        {
            FirstName = "Kromyko",
            LastName = "Cruzado",
            Email = "kccruzado@addu.edu.ph",
            PhoneNumber = "221 2496",
            MobileNumber = "639276000000",
            Address = "Solar Street, GSIS",
            City = "Davao City",
            State = "Alabama",
            ZipCode = "8000",
            Country = "Philippines",
            Company = "Ateneo de Davao University",
            JobTitle = "Senior Developer",
            Department = "UITO-MIS",
            Birthday = new DateTime(1987, 9, 16),
            ImageName = "Images\\photo1.jpg"
        });

        contacts.Add(new Contact
        {
            FirstName = "Tetet",
            LastName = "Te",
            Email = "mttquindoy@addu.edu.ph",
            PhoneNumber = "221 2497",
            MobileNumber = "639089000000",
            Address = "Daisy Street, El Rio Subdivision",
            City = "Davao City",
            State = "Wisconsin",
            ZipCode = "8001",
            Country = "Philippines",
            Company = "Ateneo de Davao University",
            JobTitle = "Project Manager",
            Department = "UITO-MIS",
            Birthday = new DateTime(1967, 8, 22),
            ImageName = "Images\\photo2.jpg"
        });

        contacts.Add(new Contact
        {
            FirstName = "John Roy",
            LastName = "Geralde",
            Email = "jregeralde@addu.edu.ph",
            PhoneNumber = "221 2498",
            MobileNumber = "639177000000",
            Address = "Daisy Street, El Rio Subdivision",
            City = "Davao City",
            State = "Washington",
            ZipCode = "8002",
            Country = "Philippines",
            Company = "Ateneo de Davao University",
            JobTitle = "Senior Developer",
            Department = "UITO-MIS",
            Birthday = new DateTime(1967, 3, 24),
            ImageName = "Images\\photo3.jpg"
        });

        contacts.Add(new Contact
        {
            FirstName = "Patrick",
            LastName = "Paasa",
            Email = "ppaasa@addu.edu.ph",
            PhoneNumber = "221 2499",
            MobileNumber = "639912000000",
            Address = "Diho Phase 2, Subdivision",
            City = "Davao City",
            State = "New York",
            ZipCode = "8003",
            Country = "Philippines",
            Company = "Ateneo de Davao University",
            JobTitle = "Senior Developer",
            Department = "UITO-MIS",
            Birthday = new DateTime(1990, 7, 25),
            ImageName = "Images\\photo4.jpg"
        });

        contacts.Add(new Contact
        {
            FirstName = "Ogs",
            LastName = "Ablazo",
            Email = "aablazo@addu.edu.ph",
            PhoneNumber = "221 2500",
            MobileNumber = "639178000000",
            Address = "Ecoland Drive Matina",
            City = "Davao City",
            State = "Portland",
            ZipCode = "8004",
            Country = "Philippines",
            Company = "Ateneo de Davao University",
            JobTitle = "UI/UX",
            Department = "UITO-MIS",
            Birthday = new DateTime(1987, 5, 5),
            ImageName = "Images\\photo5.jpg"
        });

        RefreshContactList();
    }

    private void RefreshContactList()
    {
        filteredContacts = string.IsNullOrWhiteSpace(txtSearch.Text)
            ? new List<Contact>(contacts)
            : contacts.Where(c =>
                c.FullName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                c.Email.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

        listBoxContacts.Items.Clear();
        foreach (var contact in filteredContacts)
        {
            listBoxContacts.Items.Add(contact);
        }

        if (listBoxContacts.Items.Count > 0 && currentContact != null)
        {
            int index = filteredContacts.IndexOf(currentContact);
            if (index >= 0)
            {
                listBoxContacts.SelectedIndex = index;
            }
        }
    }

    private void listBoxContacts_DrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index < 0) return;

        Contact contact = (Contact)listBoxContacts.Items[e.Index];
        e.DrawBackground();

        bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
        Color backgroundColor = isSelected ? SystemColors.Highlight : Color.White;
        Color textColor = isSelected ? Color.White : Color.Black;

        using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
        {
            e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
        }

        int padding = 10;
        int imageSize = 40;
        int imageY = e.Bounds.Top + (e.Bounds.Height - imageSize) / 2;
        Rectangle imageRect = new Rectangle(e.Bounds.Left + padding, imageY, imageSize, imageSize);

        // Try to load and draw the profile image
        bool imageDrawn = false;
        if (!string.IsNullOrEmpty(contact.ImageName))
        {
            string imagePath = GetImagePath(contact.ImageName);
            if (File.Exists(imagePath))
            {
                try
                {
                    using (Image profileImage = Image.FromFile(imagePath))
                    {
                        e.Graphics.SetClip(new System.Drawing.Drawing2D.GraphicsPath());
                        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddEllipse(imageRect);
                        e.Graphics.SetClip(path);
                        e.Graphics.DrawImage(profileImage, imageRect);
                        e.Graphics.ResetClip();
                        imageDrawn = true;
                    }
                }
                catch
                {
                    // If image loading fails, fall back to initials
                }
            }
        }

        // If no image was drawn, show initials
        if (!imageDrawn)
        {
            using (SolidBrush circleBrush = new SolidBrush(Color.FromArgb(200, 200, 200)))
            {
                e.Graphics.FillEllipse(circleBrush, imageRect);
            }

            string initials = "";
            if (!string.IsNullOrEmpty(contact.FirstName))
                initials += contact.FirstName[0];
            if (!string.IsNullOrEmpty(contact.LastName))
                initials += contact.LastName[0];

            using (Font initialsFont = new Font("Segoe UI", 14, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                SizeF initialsSize = e.Graphics.MeasureString(initials, initialsFont);
                float initialsX = e.Bounds.Left + padding + (imageSize - initialsSize.Width) / 2;
                float initialsY = imageY + (imageSize - initialsSize.Height) / 2;
                e.Graphics.DrawString(initials, initialsFont, textBrush, initialsX, initialsY);
            }
        }

        int textX = e.Bounds.Left + padding * 2 + imageSize + 5;
        int nameY = e.Bounds.Top + 8;
        int emailY = nameY + 20;

        using (Font nameFont = new Font("Segoe UI", 10, FontStyle.Bold))
        using (Font emailFont = new Font("Segoe UI", 8))
        using (SolidBrush textBrush = new SolidBrush(textColor))
        {
            e.Graphics.DrawString(contact.FullName, nameFont, textBrush, textX, nameY);
            e.Graphics.DrawString(contact.Email, emailFont, textBrush, textX, emailY);
        }

        e.DrawFocusRectangle();
    }

    private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxContacts.SelectedIndex >= 0)
        {
            currentContact = (Contact)listBoxContacts.SelectedItem;
            DisplayContact(currentContact);
            SetEditMode(false);
        }
    }

    private void DisplayContact(Contact contact)
    {
        txtFirstName.Text = contact.FirstName;
        txtLastName.Text = contact.LastName;
        txtEmail.Text = contact.Email;
        txtPhoneNumber.Text = contact.PhoneNumber;
        txtMobileNumber.Text = contact.MobileNumber;
        txtAddress.Text = contact.Address;
        txtCity.Text = contact.City;
        cmbState.Text = contact.State;
        txtZipCode.Text = contact.ZipCode;
        cmbCountry.Text = contact.Country;
        txtCompany.Text = contact.Company;
        txtJobTitle.Text = contact.JobTitle;
        txtDepartment.Text = contact.Department;

        if (contact.Birthday != DateTime.MinValue)
        {
            dtpBirthday.Value = contact.Birthday;
        }
        else
        {
            dtpBirthday.Value = DateTime.Today;
        }

        if (!string.IsNullOrEmpty(contact.ImageName))
        {
            string imagePath = GetImagePath(contact.ImageName);
            if (File.Exists(imagePath))
            {
                pictureBoxProfile.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxProfile.Image = null;
            }
        }
        else
        {
            pictureBoxProfile.Image = null;
        }

        // Load tasks for the selected contact
        LoadTasksForContact(contact);
        
        // Load notes for the selected contact
        txtNotes.Text = contact.Notes ?? string.Empty;
    }

    private void ClearContactForm()
    {
        txtFirstName.Clear();
        txtLastName.Clear();
        txtEmail.Clear();
        txtPhoneNumber.Clear();
        txtMobileNumber.Clear();
        txtAddress.Clear();
        txtCity.Clear();
        cmbState.SelectedIndex = -1;
        txtZipCode.Clear();
        cmbCountry.SelectedIndex = -1;
        txtCompany.Clear();
        txtJobTitle.Clear();
        txtDepartment.Clear();
        dtpBirthday.Value = DateTime.Today;
        pictureBoxProfile.Image = null;
    }

    private void SetEditMode(bool enabled)
    {
        isEditing = enabled;
        txtFirstName.ReadOnly = !enabled;
        txtLastName.ReadOnly = !enabled;
        txtEmail.ReadOnly = !enabled;
        txtPhoneNumber.ReadOnly = !enabled;
        txtMobileNumber.ReadOnly = !enabled;
        txtAddress.ReadOnly = !enabled;
        txtCity.ReadOnly = !enabled;
        cmbState.Enabled = enabled;
        txtZipCode.ReadOnly = !enabled;
        cmbCountry.Enabled = enabled;
        txtCompany.ReadOnly = !enabled;
        txtJobTitle.ReadOnly = !enabled;
        txtDepartment.ReadOnly = !enabled;
        dtpBirthday.Enabled = enabled;
        btnChangePhoto.Enabled = enabled;
        btnSaveChanges.Visible = enabled;
        btnCancel.Visible = enabled;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        currentContact = new Contact();
        ClearContactForm();
        SetEditMode(true);
        listBoxContacts.ClearSelected();
        txtFirstName.Focus();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (currentContact != null)
        {
            SetEditMode(true);
            txtFirstName.Focus();
        }
        else
        {
            MessageBox.Show("Please select a contact to edit.", "No Contact Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (currentContact != null && contacts.Contains(currentContact))
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {currentContact.FullName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                contacts.Remove(currentContact);
                currentContact = null;
                RefreshContactList();
                ClearContactForm();
                SetEditMode(false);
            }
        }
        else
        {
            MessageBox.Show("Please select a contact to delete.", "No Contact Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            MessageBox.Show("Email address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return;
        }

        if (currentContact != null)
        {
            currentContact.FirstName = txtFirstName.Text.Trim();
            currentContact.LastName = txtLastName.Text.Trim();
            currentContact.Email = txtEmail.Text.Trim();
            currentContact.PhoneNumber = txtPhoneNumber.Text.Trim();
            currentContact.MobileNumber = txtMobileNumber.Text.Trim();
            currentContact.Address = txtAddress.Text.Trim();
            currentContact.City = txtCity.Text.Trim();
            currentContact.State = cmbState.Text;
            currentContact.ZipCode = txtZipCode.Text.Trim();
            currentContact.Country = cmbCountry.Text;
            currentContact.Company = txtCompany.Text.Trim();
            currentContact.JobTitle = txtJobTitle.Text.Trim();
            currentContact.Department = txtDepartment.Text.Trim();
            currentContact.Birthday = dtpBirthday.Value;
            currentContact.Notes = txtNotes.Text.Trim();

            if (!contacts.Contains(currentContact))
            {
                contacts.Add(currentContact);
            }

            RefreshContactList();
            SetEditMode(false);
            MessageBox.Show("Contact saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (currentContact != null && contacts.Contains(currentContact))
        {
            DisplayContact(currentContact);
        }
        else
        {
            ClearContactForm();
            currentContact = null;
        }
        SetEditMode(false);
    }

    private void btnChangePhoto_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select a Profile Photo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxProfile.Image = Image.FromFile(openFileDialog.FileName);
                    if (currentContact != null)
                    {
                        currentContact.ImageName = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        RefreshContactList();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "JSON Files|*.json";
            saveFileDialog.Title = "Save Contacts";
            saveFileDialog.FileName = "contacts.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Contacts saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "JSON Files|*.json";
            openFileDialog.Title = "Open Contacts";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(openFileDialog.FileName);
                    var loadedContacts = JsonSerializer.Deserialize<List<Contact>>(json);
                    if (loadedContacts != null)
                    {
                        contacts = loadedContacts;
                        RefreshContactList();
                        MessageBox.Show("Contacts loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {

    }

    private void groupBoxContactDetails_Enter(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void groupBoxProfile_Enter(object sender, EventArgs e)
    {

    }

    // Task Management Methods
    private void InitializeTasksDataGridView()
    {
        dgvTasks.AutoGenerateColumns = false;
        dgvTasks.AllowUserToAddRows = false;
        dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTasks.RowHeadersVisible = false;
        dgvTasks.BackgroundColor = Color.White;
        dgvTasks.BorderStyle = BorderStyle.None;
        dgvTasks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvTasks.GridColor = Color.FromArgb(230, 230, 230);
        dgvTasks.RowTemplate.Height = 40;

        // Checkbox column for completion
        var checkBoxColumn = new DataGridViewCheckBoxColumn
        {
            Name = "IsCompleted",
            DataPropertyName = "IsCompleted",
            HeaderText = "",
            Width = 40
        };
        dgvTasks.Columns.Add(checkBoxColumn);

        // Task Description column
        var descriptionColumn = new DataGridViewTextBoxColumn
        {
            Name = "Description",
            DataPropertyName = "Description",
            HeaderText = "Task Description",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        dgvTasks.Columns.Add(descriptionColumn);

        // Due Date column
        var dueDateColumn = new DataGridViewTextBoxColumn
        {
            Name = "DueDate",
            DataPropertyName = "DueDate",
            HeaderText = "Due Date",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" }
        };
        dgvTasks.Columns.Add(dueDateColumn);

        // Priority column (stars)
        var priorityColumn = new DataGridViewTextBoxColumn
        {
            Name = "Priority",
            DataPropertyName = "Priority",
            HeaderText = "Priority",
            Width = 120
        };
        dgvTasks.Columns.Add(priorityColumn);

        // Status column
        var statusColumn = new DataGridViewTextBoxColumn
        {
            Name = "Status",
            DataPropertyName = "Status",
            HeaderText = "Status",
            Width = 120
        };
        dgvTasks.Columns.Add(statusColumn);

        dgvTasks.CellFormatting += DgvTasks_CellFormatting;
        dgvTasks.CellContentClick += DgvTasks_CellContentClick;
    }

    private void DgvTasks_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (dgvTasks.Columns[e.ColumnIndex].Name == "Priority" && e.Value != null)
        {
            int priority = (int)e.Value;
            e.Value = new string('★', priority) + new string('☆', 5 - priority);
            e.FormattingApplied = true;
        }

        if (dgvTasks.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
        {
            var status = (ContactsManager.models.TaskStatus)e.Value;
            switch (status)
            {
                case ContactsManager.models.TaskStatus.Completed:
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    break;
                case ContactsManager.models.TaskStatus.InProgress:
                    e.CellStyle.BackColor = Color.LightYellow;
                    e.CellStyle.ForeColor = Color.DarkOrange;
                    break;
                case ContactsManager.models.TaskStatus.Urgent:
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.DarkRed;
                    break;
                case ContactsManager.models.TaskStatus.NotStarted:
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.ForeColor = Color.Gray;
                    break;
            }
        }

        // Strike through completed tasks
        if (dgvTasks.Columns[e.ColumnIndex].Name == "Description")
        {
            var row = dgvTasks.Rows[e.RowIndex];
            if (row.Cells["IsCompleted"].Value is bool isCompleted && isCompleted)
            {
                e.CellStyle.Font = new Font(dgvTasks.Font, FontStyle.Strikeout);
                e.CellStyle.ForeColor = Color.Gray;
            }
        }
    }

    private void DgvTasks_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 0 && e.RowIndex >= 0) // Checkbox column clicked
        {
            dgvTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            UpdateTaskStatistics();
        }
    }

    private void LoadTasksForContact(Contact contact)
    {
        if (contact == null) return;

        lblTasksFor.Text = $"Tasks for {contact.FullName}";
        dgvTasks.DataSource = null;
        dgvTasks.DataSource = contact.Tasks;
        UpdateTaskStatistics();
    }

    private void UpdateTaskStatistics()
    {
        if (currentContact == null)
        {
            lblTotalTasksValue.Text = "0";
            lblCompletedValue.Text = "0";
            lblInProgressValue.Text = "0";
            lblUrgentValue.Text = "0";
            return;
        }

        var tasks = currentContact.Tasks;
        lblTotalTasksValue.Text = tasks.Count.ToString();
        lblCompletedValue.Text = tasks.Count(t => t.Status == ContactsManager.models.TaskStatus.Completed).ToString();
        lblInProgressValue.Text = tasks.Count(t => t.Status == ContactsManager.models.TaskStatus.InProgress).ToString();
        lblUrgentValue.Text = tasks.Count(t => t.Status == ContactsManager.models.TaskStatus.Urgent).ToString();
    }

    private void btnAddNewTask_Click(object sender, EventArgs e)
    {
        // Check if a contact is selected
        if (currentContact == null)
        {
            MessageBox.Show("Please select a contact first to add a task.", 
                "No Contact Selected", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            return;
        }

        // Open the task form dialog
        using (TaskForm taskForm = new TaskForm())
        {
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                // Generate a new ID for the task
                int newId = currentContact.Tasks.Any() 
                    ? currentContact.Tasks.Max(t => t.Id) + 1 
                    : 1;
                
                taskForm.Task.Id = newId;

                // Add the task to the current contact
                currentContact.Tasks.Add(taskForm.Task);

                // Refresh the tasks display
                LoadTasksForContact(currentContact);

                MessageBox.Show("Task added successfully!", 
                    "Success", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
    }
}

}
