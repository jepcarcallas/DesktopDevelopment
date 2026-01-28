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

    private void InitializeControls()
    {
        PopulateStates();
        PopulateCountries();
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
            FirstName = "Sarah",
            LastName = "Johnson",
            Email = "sarah.j@email.com",
            PhoneNumber = "(555) 123-4567",
            MobileNumber = "(555) 987-6543",
            Address = "123 Main Street",
            City = "Seattle",
            State = "WA",
            ZipCode = "98101",
            Country = "United States",
            Company = "Tech Solutions Inc.",
            JobTitle = "Software Engineer",
            Department = "Engineering",
            Birthday = new DateTime(1990, 3, 15)
        });

        contacts.Add(new Contact
        {
            FirstName = "Michael",
            LastName = "Chen",
            Email = "m.chen@email.com",
            PhoneNumber = "(555) 234-5678",
            MobileNumber = "(555) 876-5432",
            City = "San Francisco",
            State = "CA",
            Country = "United States"
        });

        contacts.Add(new Contact
        {
            FirstName = "Emily",
            LastName = "Rodriguez",
            Email = "emily.r@email.com",
            PhoneNumber = "(555) 345-6789",
            MobileNumber = "(555) 765-4321",
            City = "Austin",
            State = "TX",
            Country = "United States"
        });

        contacts.Add(new Contact
        {
            FirstName = "David",
            LastName = "Thompson",
            Email = "d.thompson@email.com",
            PhoneNumber = "(555) 456-7890",
            MobileNumber = "(555) 654-3210",
            City = "Boston",
            State = "MA",
            Country = "United States"
        });

        contacts.Add(new Contact
        {
            FirstName = "Jessica",
            LastName = "Williams",
            Email = "j.williams@email.com",
            PhoneNumber = "(555) 567-8901",
            MobileNumber = "(555) 543-2109",
            City = "Denver",
            State = "CO",
            Country = "United States"
        });

        contacts.Add(new Contact
        {
            FirstName = "Robert",
            LastName = "Martinez",
            Email = "r.martinez@email.com",
            PhoneNumber = "(555) 678-9012",
            MobileNumber = "(555) 432-1098",
            City = "Miami",
            State = "FL",
            Country = "United States"
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

        using (SolidBrush circleBrush = new SolidBrush(Color.FromArgb(200, 200, 200)))
        {
            e.Graphics.FillEllipse(circleBrush, e.Bounds.Left + padding, imageY, imageSize, imageSize);
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

        if (!string.IsNullOrEmpty(contact.ImageName) && File.Exists(contact.ImageName))
        {
            pictureBoxProfile.Image = Image.FromFile(contact.ImageName);
        }
        else
        {
            pictureBoxProfile.Image = null;
        }
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
}
}
