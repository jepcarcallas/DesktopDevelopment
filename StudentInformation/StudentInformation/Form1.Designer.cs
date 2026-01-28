namespace StudentInformation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox fieldFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox fieldLastName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker fieldBirthDate;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox fieldAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.ComboBox fieldProgram;
        private System.Windows.Forms.GroupBox groupHobbies;
        private System.Windows.Forms.CheckBox hobbyReading;
        private System.Windows.Forms.CheckBox hobbyWatching;
        private System.Windows.Forms.CheckBox hobbyGaming;
        private System.Windows.Forms.CheckBox hobbyFishing;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridStudents;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxProfile = new PictureBox();
            labelFirstName = new Label();
            fieldFirstName = new TextBox();
            labelLastName = new Label();
            fieldLastName = new TextBox();
            labelBirthDate = new Label();
            fieldBirthDate = new DateTimePicker();
            labelAge = new Label();
            fieldAge = new TextBox();
            labelSex = new Label();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            labelProgram = new Label();
            fieldProgram = new ComboBox();
            groupHobbies = new GroupBox();
            hobbyReading = new CheckBox();
            hobbyWatching = new CheckBox();
            hobbyGaming = new CheckBox();
            hobbyFishing = new CheckBox();
            btnSave = new Button();
            dataGridStudents = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colProgram = new DataGridViewTextBoxColumn();
            colSex = new DataGridViewTextBoxColumn();
            colBirth = new DataGridViewTextBoxColumn();
            colHobbies = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            groupHobbies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProfile.Location = new Point(16, 16);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(200, 220);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(247, 20);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            // 
            // fieldFirstName
            // 
            fieldFirstName.Location = new Point(247, 42);
            fieldFirstName.Name = "fieldFirstName";
            fieldFirstName.Size = new Size(220, 27);
            fieldFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(496, 20);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last Name";
            // 
            // fieldLastName
            // 
            fieldLastName.Location = new Point(496, 42);
            fieldLastName.Name = "fieldLastName";
            fieldLastName.Size = new Size(251, 27);
            fieldLastName.TabIndex = 2;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(247, 84);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(76, 20);
            labelBirthDate.TabIndex = 3;
            labelBirthDate.Text = "Birth Date";
            // 
            // fieldBirthDate
            // 
            fieldBirthDate.Location = new Point(247, 107);
            fieldBirthDate.Name = "fieldBirthDate";
            fieldBirthDate.Size = new Size(287, 27);
            fieldBirthDate.TabIndex = 3;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(563, 107);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(36, 20);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age";
            // 
            // fieldAge
            // 
            fieldAge.Location = new Point(618, 104);
            fieldAge.Name = "fieldAge";
            fieldAge.ReadOnly = true;
            fieldAge.Size = new Size(60, 27);
            fieldAge.TabIndex = 4;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(247, 148);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(32, 20);
            labelSex.TabIndex = 5;
            labelSex.Text = "Sex";
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(247, 171);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(63, 24);
            radioMale.TabIndex = 5;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(359, 171);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(78, 24);
            radioFemale.TabIndex = 6;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // labelProgram
            // 
            labelProgram.AutoSize = true;
            labelProgram.Location = new Point(247, 210);
            labelProgram.Name = "labelProgram";
            labelProgram.Size = new Size(66, 20);
            labelProgram.TabIndex = 7;
            labelProgram.Text = "Program";
            // 
            // fieldProgram
            // 
            fieldProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            fieldProgram.Location = new Point(247, 233);
            fieldProgram.Name = "fieldProgram";
            fieldProgram.Size = new Size(220, 28);
            fieldProgram.TabIndex = 7;
            fieldProgram.SelectedIndexChanged += fieldProgram_SelectedIndexChanged;
            // 
            // groupHobbies
            // 
            groupHobbies.Controls.Add(hobbyReading);
            groupHobbies.Controls.Add(hobbyWatching);
            groupHobbies.Controls.Add(hobbyGaming);
            groupHobbies.Controls.Add(hobbyFishing);
            groupHobbies.Location = new Point(753, 20);
            groupHobbies.Name = "groupHobbies";
            groupHobbies.Size = new Size(300, 175);
            groupHobbies.TabIndex = 8;
            groupHobbies.TabStop = false;
            groupHobbies.Text = "What are your hobbies?";
            groupHobbies.Enter += groupHobbies_Enter;
            // 
            // hobbyReading
            // 
            hobbyReading.AutoSize = true;
            hobbyReading.Location = new Point(14, 34);
            hobbyReading.Name = "hobbyReading";
            hobbyReading.Size = new Size(130, 24);
            hobbyReading.TabIndex = 0;
            hobbyReading.Text = "Reading Books";
            hobbyReading.UseVisualStyleBackColor = true;
            // 
            // hobbyWatching
            // 
            hobbyWatching.AutoSize = true;
            hobbyWatching.Location = new Point(14, 64);
            hobbyWatching.Name = "hobbyWatching";
            hobbyWatching.Size = new Size(140, 24);
            hobbyWatching.TabIndex = 1;
            hobbyWatching.Text = "Watching Anime";
            hobbyWatching.UseVisualStyleBackColor = true;
            // 
            // hobbyGaming
            // 
            hobbyGaming.AutoSize = true;
            hobbyGaming.Location = new Point(14, 94);
            hobbyGaming.Name = "hobbyGaming";
            hobbyGaming.Size = new Size(171, 24);
            hobbyGaming.TabIndex = 2;
            hobbyGaming.Text = "Playing Video Games";
            hobbyGaming.UseVisualStyleBackColor = true;
            // 
            // hobbyFishing
            // 
            hobbyFishing.AutoSize = true;
            hobbyFishing.Location = new Point(14, 124);
            hobbyFishing.Name = "hobbyFishing";
            hobbyFishing.Size = new Size(77, 24);
            hobbyFishing.TabIndex = 3;
            hobbyFishing.Text = "Fishing";
            hobbyFishing.UseVisualStyleBackColor = true;
            hobbyFishing.CheckedChanged += hobbyFishing_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(753, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(258, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save Student Information";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridStudents
            // 
            dataGridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudents.Columns.AddRange(new DataGridViewColumn[] { colName, colProgram, colSex, colBirth, colHobbies });
            dataGridStudents.Location = new Point(16, 293);
            dataGridStudents.Name = "dataGridStudents";
            dataGridStudents.RowHeadersWidth = 51;
            dataGridStudents.Size = new Size(860, 247);
            dataGridStudents.TabIndex = 10;
            // 
            // colName
            // 
            colName.HeaderText = "Student Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 220;
            // 
            // colProgram
            // 
            colProgram.HeaderText = "Program";
            colProgram.MinimumWidth = 6;
            colProgram.Name = "colProgram";
            colProgram.Width = 120;
            // 
            // colSex
            // 
            colSex.HeaderText = "Sex";
            colSex.MinimumWidth = 6;
            colSex.Name = "colSex";
            colSex.Width = 80;
            // 
            // colBirth
            // 
            colBirth.HeaderText = "Birthdate";
            colBirth.MinimumWidth = 6;
            colBirth.Name = "colBirth";
            colBirth.Width = 180;
            // 
            // colHobbies
            // 
            colHobbies.HeaderText = "Hobbies";
            colHobbies.MinimumWidth = 6;
            colHobbies.Name = "colHobbies";
            colHobbies.Width = 220;
            // 
            // Form1
            // 
            ClientSize = new Size(1146, 560);
            Controls.Add(pictureBoxProfile);
            Controls.Add(labelFirstName);
            Controls.Add(fieldFirstName);
            Controls.Add(labelLastName);
            Controls.Add(fieldAge);
            Controls.Add(fieldLastName);
            Controls.Add(labelBirthDate);
            Controls.Add(fieldBirthDate);
            Controls.Add(labelAge);
            Controls.Add(labelSex);
            Controls.Add(radioMale);
            Controls.Add(radioFemale);
            Controls.Add(labelProgram);
            Controls.Add(fieldProgram);
            Controls.Add(groupHobbies);
            Controls.Add(btnSave);
            Controls.Add(dataGridStudents);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            groupHobbies.ResumeLayout(false);
            groupHobbies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colProgram;
        private DataGridViewTextBoxColumn colSex;
        private DataGridViewTextBoxColumn colBirth;
        private DataGridViewTextBoxColumn colHobbies;
    }
}
