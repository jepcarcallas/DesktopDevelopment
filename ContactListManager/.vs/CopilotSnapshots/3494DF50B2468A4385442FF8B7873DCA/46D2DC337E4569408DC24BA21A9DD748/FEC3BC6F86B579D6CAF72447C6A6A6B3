using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactListManager
{
    public partial class MainForm : Form
    {
        // Store all contacts
        private List<Contact> contacts = new List<Contact>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContactsFromCSV();
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            ContactPopup popup = new ContactPopup();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                contacts.Add(popup.Contact);
                UpdateContactGrid();
            }
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to edit.");
                return;
            }

            var selectedContact = (Contact)dgvContacts.SelectedRows[0].DataBoundItem;

            ContactPopup popup = new ContactPopup(selectedContact);
            if (popup.ShowDialog() == DialogResult.OK)
            {
                int index = contacts.IndexOf(selectedContact);
                if (index >= 0)
                {
                    contacts[index] = popup.Contact;
                    UpdateContactGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadContactsFromCSV()
        {
            const string path = "contacts.csv";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Name,Email,PhoneNumber");
            }

            string[] lines = File.ReadAllLines(path);

            contacts.Clear();

            foreach (string line in lines.Skip(1)) // skip header
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(',');
                if (parts.Length < 3)
                    continue;

                contacts.Add(new Contact
                {
                    Name = parts[0].Trim(),
                    Email = parts[1].Trim(),
                    PhoneNumber = parts[2].Trim()
                });
            }

            UpdateContactGrid();
        }

        private void UpdateContactGrid()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = contacts;
        }

        private void SaveContactsToCSV()
        {
            var lines = new List<string> { "Name,Email,PhoneNumber" };
            foreach (var contact in contacts)
            {
                lines.Add($"{contact.Name},{contact.Email},{contact.PhoneNumber}");
            }
            File.WriteAllLines("contacts.csv", lines);
            MessageBox.Show("Contacts saved successfully!");
        }

        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {
            SaveContactsToCSV();
        }
    }
}
