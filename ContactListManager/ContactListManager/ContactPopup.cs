using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactListManager
{
    public partial class ContactPopup : Form
    {
        public Contact Contact { get; private set; }

        public ContactPopup()
        {
            InitializeComponent();
        }

        public ContactPopup(Contact existingContact) : this()
        {
            if (existingContact != null)
            {
                txtName.Text = existingContact.Name;
                txtEmail.Text = existingContact.Email;
                txtPhoneNumber.Text = existingContact.PhoneNumber;
                this.Text = "Edit Contact";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid phone number (10-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Contact = new Contact
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string digitsOnly = new string(phone.Where(char.IsDigit).ToArray());
            return digitsOnly.Length >= 10 && digitsOnly.Length <= 15;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
