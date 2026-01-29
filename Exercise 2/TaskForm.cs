namespace Exercise2
{
    public partial class TaskForm : Form
    {
        public ContactsManager.models.Task Task { get; private set; }

        public TaskForm()
        {
            InitializeComponent();
            Task = new ContactsManager.models.Task
            {
                DueDate = DateTime.Today.AddDays(7),
                Priority = 3,
                Status = ContactsManager.models.TaskStatus.NotStarted,
                IsCompleted = false
            };
            LoadInitialData();
        }

        public TaskForm(ContactsManager.models.Task existingTask)
        {
            InitializeComponent();
            Task = existingTask;
            LoadTaskData();
        }

        private void LoadInitialData()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(ContactsManager.models.TaskStatus));
            cmbStatus.SelectedItem = ContactsManager.models.TaskStatus.NotStarted;
            
            // Add priority items with filled and empty stars
            cmbPriority.Items.Add("\u2b50\u2606\u2606\u2606\u2606 (Lowest)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2606\u2606\u2606 (Low)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2b50\u2606\u2606 (Medium)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2b50\u2b50\u2606 (High)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2b50\u2b50\u2b50 (Highest)");
            cmbPriority.SelectedIndex = 2; // Medium priority default
            
            dtpDueDate.Value = DateTime.Today.AddDays(7);
        }

        private void LoadTaskData()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(ContactsManager.models.TaskStatus));
            
            // Add priority items with filled and empty stars
            cmbPriority.Items.Add("\u2b50\u2606\u2606\u2606\u2606 (Lowest)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2606\u2606\u2606 (Low)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2b50\u2606\u2606 (Medium)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2b50\u2b50\u2606 (High)");
            cmbPriority.Items.Add("\u2b50\u2b50\u2b50\u2b50\u2b50 (Highest)");

            txtDescription.Text = Task.Description;
            dtpDueDate.Value = Task.DueDate;
            cmbPriority.SelectedIndex = Task.Priority - 1;
            cmbStatus.SelectedItem = Task.Status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a task description.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }

            Task.Description = txtDescription.Text.Trim();
            Task.DueDate = dtpDueDate.Value;
            Task.Priority = cmbPriority.SelectedIndex + 1;
            Task.Status = (ContactsManager.models.TaskStatus)cmbStatus.SelectedItem;
            Task.IsCompleted = Task.Status == ContactsManager.models.TaskStatus.Completed;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Task";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(20, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(131, 19);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Task Description: *";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(20, 87);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(440, 80);
            txtDescription.TabIndex = 2;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDueDate.Location = new Point(20, 185);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(73, 19);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Segoe UI", 10F);
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(20, 207);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 25);
            dtpDueDate.TabIndex = 4;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPriority.Location = new Point(260, 185);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(63, 19);
            lblPriority.TabIndex = 5;
            lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Font = new Font("Segoe UI", 10F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(260, 207);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(200, 25);
            cmbPriority.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.Location = new Point(20, 250);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 19);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(20, 272);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 25);
            cmbStatus.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(260, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(370, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // TaskForm
            // 
            ClientSize = new Size(484, 381);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(dtpDueDate);
            Controls.Add(lblDueDate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Task";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblPriority;
        private ComboBox cmbPriority;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}
