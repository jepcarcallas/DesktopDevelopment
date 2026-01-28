using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Wire up events
            if (fieldBirthDate != null)
                fieldBirthDate.ValueChanged += FieldBirthDate_ValueChanged;
            if (btnSave != null)
                btnSave.Click += BtnSave_Click;

            // Populate programs
            if (fieldProgram != null)
            {
                fieldProgram.Items.AddRange(new object[] { "BS-IT", "BS-CS", "BS-CE", "BS-IS" });
                if (fieldProgram.Items.Count > 0)
                    fieldProgram.SelectedIndex = 0;
            }

            UpdateAgeFromBirthDate();
        }

        private void FieldBirthDate_ValueChanged(object? sender, EventArgs e)
        {
            UpdateAgeFromBirthDate();
        }

        private void UpdateAgeFromBirthDate()
        {
            if (fieldBirthDate == null || fieldAge == null)
                return;

            DateTime birth = fieldBirthDate.Value.Date;
            DateTime today = DateTime.Today;

            int age = today.Year - birth.Year;
            if (birth > today.AddYears(-age)) age--;

            fieldAge.Text = age.ToString();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string firstName = fieldFirstName?.Text.Trim() ?? string.Empty;
            string lastName = fieldLastName?.Text.Trim() ?? string.Empty;
            string fullName = $"{firstName} {lastName}".Trim();

            string sex = (radioMale?.Checked == true) ? "Male" : ((radioFemale?.Checked == true) ? "Female" : "Unspecified");

            string program = fieldProgram?.SelectedItem?.ToString() ?? string.Empty;
            string birthdateFormatted = fieldBirthDate?.Value.ToString("D") ?? string.Empty;

            var hobbies = new[]
            {
                (hobbyReading?.Checked == true) ? "Reading Books" : null,
                (hobbyWatching?.Checked == true) ? "Watching Anime" : null,
                (hobbyGaming?.Checked == true) ? "Playing Video Games" : null,
                (hobbyFishing?.Checked == true) ? "Fishing" : null
            }.Where(s => s != null).Select(s => s!).ToArray();

            // Console output
            Console.WriteLine("Hello World");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Birthdate: {birthdateFormatted}");
            Console.WriteLine($"Age: {fieldAge?.Text}");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"Program: {program}");
            Console.WriteLine($"Hobbies: {string.Join(',', hobbies)}");

            // Append to DataGridView
            if (dataGridStudents != null)
            {
                dataGridStudents.Rows.Add(
                    fullName,
                    program,
                    sex,
                    birthdateFormatted,
                    string.Join(",", hobbies)
                );
            }

            MessageBox.Show("Student information saved to console and grid.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
