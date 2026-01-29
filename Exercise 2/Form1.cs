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
        InitializeNotesTab();
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
            ImageName = "Images\\photo1.jpg",
            Notes = "I have to meet the team on January 23 to discuss some items with them.\n\nI need to buy birthday cake for Che's birthday this Friday."
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
            ImageName = "Images\\photo2.jpg",
            Notes = "Push to repo before sleeping. Don't trust local changes.\n\nCheck timezone bug tomorrow — user is NOT wrong."
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
            ImageName = "Images\\photo3.jpg",
            Notes = "Bring charger. Laptop dies faster than my motivation.\n\nAsk if requirements changed before rewriting everything."
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
            ImageName = "Images\\photo4.jpg",
            Notes = "Stop overengineering. This is just a demo.\n\nRemember: worked on machine ≠ works on prod."
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
        LoadNotesForContact(contact);
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
        using (AddContactForm addForm = new AddContactForm())
        {
            if (addForm.ShowDialog() == DialogResult.OK && addForm.NewContact != null)
            {
                contacts.Add(addForm.NewContact);
                RefreshContactList();
                
                // Select the newly added contact
                int index = filteredContacts.IndexOf(addForm.NewContact);
                if (index >= 0)
                {
                    listBoxContacts.SelectedIndex = index;
                }
                
                MessageBox.Show($"Contact '{addForm.NewContact.FullName}' has been added successfully!", 
                    "Contact Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
            // Notes are saved directly in the TextBox TextChanged event

            if (!contacts.Contains(currentContact))
            {
                contacts.Add(currentContact);
            }

            RefreshContactList();
            SetEditMode(false);
            MessageBox.Show("Contact saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void LoadNotesForContact(Contact contact)
    {
        // Clear existing controls in Notes tab
        tabNotes.Controls.Clear();

        // Create main scrollable panel
        Panel panelNotesMain = new Panel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = Color.White,
            Padding = new Padding(20)
        };
        tabNotes.Controls.Add(panelNotesMain);

        int yPosition = 0;

        // Header Panel
        Panel headerPanel = new Panel
        {
            Width = panelNotesMain.ClientSize.Width - 40,
            Height = 60,
            Location = new Point(0, yPosition),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        Label lblNotesHeader = new Label
        {
            Text = $"Notes for {contact.FullName}",
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            Location = new Point(0, 15),
            AutoSize = true
        };
        headerPanel.Controls.Add(lblNotesHeader);

        Button btnAddNote = new Button
        {
            Text = "+ Add New Note",
            Size = new Size(150, 35),
            Location = new Point(headerPanel.Width - 160, 12),
            Font = new Font("Segoe UI", 10),
            BackColor = Color.FromArgb(0, 120, 215),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        btnAddNote.FlatAppearance.BorderSize = 0;
        btnAddNote.Click += (s, e) => BtnAddNote_Click(contact);
        headerPanel.Controls.Add(btnAddNote);

        panelNotesMain.Controls.Add(headerPanel);
        yPosition += 75;

        // Quick Notes Section
        Label lblQuickNotes = new Label
        {
            Text = "Quick Notes",
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            Location = new Point(0, yPosition),
            AutoSize = true,
            Anchor = AnchorStyles.Top | AnchorStyles.Left
        };
        panelNotesMain.Controls.Add(lblQuickNotes);
        yPosition += 35;

        Panel quickNotesPanel = new Panel
        {
            Width = panelNotesMain.ClientSize.Width - 40,
            Height = 130,
            Location = new Point(0, yPosition),
            BackColor = Color.FromArgb(250, 250, 250),
            BorderStyle = BorderStyle.FixedSingle,
            Padding = new Padding(15),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        TextBox txtQuickNotes = new TextBox
        {
            Width = quickNotesPanel.Width - 30,
            Height = 100,
            Multiline = true,
            Font = new Font("Segoe UI", 10),
            Location = new Point(15, 15),
            BorderStyle = BorderStyle.None,
            BackColor = Color.FromArgb(250, 250, 250),
            Text = contact.Notes ?? string.Empty,
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
            ScrollBars = ScrollBars.Vertical
        };
        txtQuickNotes.TextChanged += (s, e) => { if (currentContact != null) currentContact.Notes = txtQuickNotes.Text; };
        quickNotesPanel.Controls.Add(txtQuickNotes);

        panelNotesMain.Controls.Add(quickNotesPanel);
        yPosition += 150;

        // Meeting Notes Section
        Label lblMeetingNotes = new Label
        {
            Text = "Meeting Notes",
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            Location = new Point(0, yPosition),
            AutoSize = true,
            Anchor = AnchorStyles.Top | AnchorStyles.Left
        };
        panelNotesMain.Controls.Add(lblMeetingNotes);
        yPosition += 35;

        Panel meetingNotesPanel = new Panel
        {
            Width = panelNotesMain.ClientSize.Width - 40,
            Height = 180,
            Location = new Point(0, yPosition),
            BackColor = Color.FromArgb(250, 250, 250),
            BorderStyle = BorderStyle.FixedSingle,
            Padding = new Padding(15),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        // Sample meeting note entry
        Label lblMeetingTitle = new Label
        {
            Text = "Initial Contact - Jan 5, 2026",
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            Location = new Point(15, 15),
            AutoSize = true
        };

        Label lblMeetingContent = new Label
        {
            Text = "First meeting. Very professional and knowledgeable about their team's needs. Expressed interest in long-term partnership.",
            Font = new Font("Segoe UI", 9),
            ForeColor = Color.Gray,
            Location = new Point(15, 40),
            MaximumSize = new Size(meetingNotesPanel.Width - 30, 0),
            AutoSize = true
        };

        LinkLabel linkEdit = new LinkLabel
        {
            Text = "Edit",
            Font = new Font("Segoe UI", 9),
            Location = new Point(meetingNotesPanel.Width - 50, 15),
            AutoSize = true,
            LinkColor = Color.FromArgb(0, 120, 215),
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };
        linkEdit.LinkClicked += (s, e) => EditMeetingNote_Click(lblMeetingTitle, lblMeetingContent);

        meetingNotesPanel.Controls.Add(lblMeetingTitle);
        meetingNotesPanel.Controls.Add(linkEdit);
        meetingNotesPanel.Controls.Add(lblMeetingContent);

        panelNotesMain.Controls.Add(meetingNotesPanel);
        yPosition += 200;

        // Important Reminders Section
        Label lblReminders = new Label
        {
            Text = "Important Reminders",
            Font = new Font("Segoe UI", 14, FontStyle.Bold),
            Location = new Point(0, yPosition),
            AutoSize = true,
            Anchor = AnchorStyles.Top | AnchorStyles.Left
        };
        panelNotesMain.Controls.Add(lblReminders);
        yPosition += 35;

        Panel remindersPanel = new Panel
        {
            Width = panelNotesMain.ClientSize.Width - 40,
            Height = 160,
            Location = new Point(0, yPosition),
            BackColor = Color.FromArgb(250, 250, 250),
            BorderStyle = BorderStyle.FixedSingle,
            Padding = new Padding(15),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };

        // Sample reminders
        CreateReminderEntry(remindersPanel, "Send proposal by Jan 22", "Include pricing options and implementation timeline", 15, false);
        CreateReminderEntry(remindersPanel, "Schedule follow-up meeting", "Confirm availability for week of Jan 27", 60, false);
        CreateReminderEntry(remindersPanel, "Send initial documentation", "Completed on Jan 12", 105, true);

        panelNotesMain.Controls.Add(remindersPanel);
    }

    private void CreateReminderEntry(Panel parent, string title, string subtitle, int yPos, bool isCompleted)
    {
        CheckBox chkReminder = new CheckBox
        {
            Checked = isCompleted,
            Location = new Point(0, yPos),
            AutoSize = true
        };

        Label lblTitle = new Label
        {
            Text = title,
            Font = new Font("Segoe UI", 10, isCompleted ? FontStyle.Strikeout : FontStyle.Bold),
            Location = new Point(25, yPos),
            AutoSize = true,
            ForeColor = isCompleted ? Color.Gray : Color.Black
        };

        Label lblSubtitle = new Label
        {
            Text = subtitle,
            Font = new Font("Segoe UI", 9),
            ForeColor = Color.Gray,
            Location = new Point(25, yPos + 22),
            AutoSize = true
        };

        // Add CheckedChanged event handler
        chkReminder.CheckedChanged += (s, e) =>
        {
            bool completed = chkReminder.Checked;
            lblTitle.Font = new Font("Segoe UI", 10, completed ? FontStyle.Strikeout : FontStyle.Bold);
            lblTitle.ForeColor = completed ? Color.Gray : Color.Black;
            
            string message = completed ? 
                $"Reminder '{title}' marked as completed!" : 
                $"Reminder '{title}' marked as incomplete.";
            MessageBox.Show(message, "Reminder Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };

        parent.Controls.Add(chkReminder);
        parent.Controls.Add(lblTitle);
        parent.Controls.Add(lblSubtitle);
    }

    private void BtnAddNote_Click(Contact contact)
    {
        // Create a simple dialog to add a new meeting note
        Form noteDialog = new Form
        {
            Text = "Add New Meeting Note",
            Size = new Size(500, 350),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false,
            MinimizeBox = false
        };

        Label lblTitle = new Label
        {
            Text = "Note Title:",
            Location = new Point(20, 20),
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        noteDialog.Controls.Add(lblTitle);

        TextBox txtTitle = new TextBox
        {
            Location = new Point(20, 45),
            Size = new Size(440, 25),
            Font = new Font("Segoe UI", 10),
            PlaceholderText = "e.g., Project Discussion - Jan 15, 2026"
        };
        noteDialog.Controls.Add(txtTitle);

        Label lblContent = new Label
        {
            Text = "Note Content:",
            Location = new Point(20, 85),
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        noteDialog.Controls.Add(lblContent);

        TextBox txtContent = new TextBox
        {
            Location = new Point(20, 110),
            Size = new Size(440, 120),
            Font = new Font("Segoe UI", 10),
            Multiline = true,
            ScrollBars = ScrollBars.Vertical,
            PlaceholderText = "Enter your meeting notes here..."
        };
        noteDialog.Controls.Add(txtContent);

        Button btnSaveNote = new Button
        {
            Text = "Save Note",
            Location = new Point(280, 250),
            Size = new Size(90, 35),
            BackColor = Color.FromArgb(0, 120, 215),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10)
        };
        btnSaveNote.FlatAppearance.BorderSize = 0;
        btnSaveNote.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a note title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Note saved successfully!\n\nTitle: {txtTitle.Text}\nContent: {txtContent.Text}", 
                "Note Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            noteDialog.DialogResult = DialogResult.OK;
            noteDialog.Close();
            
            // Reload notes to show the new note
            LoadNotesForContact(contact);
        };
        noteDialog.Controls.Add(btnSaveNote);

        Button btnCancelNote = new Button
        {
            Text = "Cancel",
            Location = new Point(380, 250),
            Size = new Size(80, 35),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10)
        };
        btnCancelNote.Click += (s, e) =>
        {
            noteDialog.DialogResult = DialogResult.Cancel;
            noteDialog.Close();
        };
        noteDialog.Controls.Add(btnCancelNote);

        noteDialog.ShowDialog();
    }

    private void EditMeetingNote_Click(Label lblTitle, Label lblContent)
    {
        // Create a dialog to edit the meeting note
        Form editDialog = new Form
        {
            Text = "Edit Meeting Note",
            Size = new Size(500, 350),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false,
            MinimizeBox = false
        };

        Label lblEditTitle = new Label
        {
            Text = "Note Title:",
            Location = new Point(20, 20),
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        editDialog.Controls.Add(lblEditTitle);

        TextBox txtEditTitle = new TextBox
        {
            Location = new Point(20, 45),
            Size = new Size(440, 25),
            Font = new Font("Segoe UI", 10),
            Text = lblTitle.Text
        };
        editDialog.Controls.Add(txtEditTitle);

        Label lblEditContent = new Label
        {
            Text = "Note Content:",
            Location = new Point(20, 85),
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        editDialog.Controls.Add(lblEditContent);

        TextBox txtEditContent = new TextBox
        {
            Location = new Point(20, 110),
            Size = new Size(440, 120),
            Font = new Font("Segoe UI", 10),
            Multiline = true,
            ScrollBars = ScrollBars.Vertical,
            Text = lblContent.Text
        };
        editDialog.Controls.Add(txtEditContent);

        Button btnSaveEdit = new Button
        {
            Text = "Save",
            Location = new Point(280, 250),
            Size = new Size(90, 35),
            BackColor = Color.FromArgb(0, 120, 215),
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10)
        };
        btnSaveEdit.FlatAppearance.BorderSize = 0;
        btnSaveEdit.Click += (s, e) =>
        {
            if (string.IsNullOrWhiteSpace(txtEditTitle.Text))
            {
                MessageBox.Show("Please enter a note title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblTitle.Text = txtEditTitle.Text;
            lblContent.Text = txtEditContent.Text;
            
            MessageBox.Show("Note updated successfully!", "Note Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            editDialog.DialogResult = DialogResult.OK;
            editDialog.Close();
        };
        editDialog.Controls.Add(btnSaveEdit);

        Button btnCancelEdit = new Button
        {
            Text = "Cancel",
            Location = new Point(380, 250),
            Size = new Size(80, 35),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 10)
        };
        btnCancelEdit.Click += (s, e) =>
        {
            editDialog.DialogResult = DialogResult.Cancel;
            editDialog.Close();
        };
        editDialog.Controls.Add(btnCancelEdit);

        editDialog.ShowDialog();
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

    private void InitializeNotesTab()
    {
        // The Notes tab will be populated dynamically when a contact is selected
        tabNotes.BackColor = Color.White;
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
