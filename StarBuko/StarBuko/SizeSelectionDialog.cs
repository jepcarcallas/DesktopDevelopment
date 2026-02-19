using System;
using System.Drawing;
using System.Windows.Forms;

namespace StarBuko
{
    public class SizeSelectionDialog : Form
    {
        private Button btnYes;
        private Button btnNo;
        private Button btnCancel;
        private Label lblMessage;
        private PictureBox pictureBox;

        public string SelectedSize { get; private set; }
        private bool buttonClicked = false;

        public SizeSelectionDialog()
        {
            InitializeComponent();
            this.FormClosing += SizeSelectionDialog_FormClosing;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (pictureBox?.Image != null)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }
                btnYes?.Dispose();
                btnNo?.Dispose();
                btnCancel?.Dispose();
                lblMessage?.Dispose();
                pictureBox?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void SizeSelectionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If form is closing and no button was clicked, it's the X button
            if (!buttonClicked)
            {
                SelectedSize = null;
            }
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            SelectedSize = "Grande";
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            SelectedSize = "Venti";
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            SelectedSize = "Regular";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SizeSelectionDialog));
            btnYes = new Button();
            btnNo = new Button();
            btnCancel = new Button();
            lblMessage = new Label();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Location = new Point(84, 105);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(75, 23);
            btnYes.TabIndex = 2;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += BtnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(165, 105);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 23);
            btnNo.TabIndex = 3;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += BtnNo_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(246, 105);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(60, 12);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 80);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Choose Cup Size:\n\n\tYes for Grande (+₱20)\n\tNo for Venti (+₱30)\n\tCancel for Regular";
            lblMessage.Click += lblMessage_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(32, 32);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // SizeSelectionDialog
            // 
            ClientSize = new Size(380, 145);
            Controls.Add(btnCancel);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblMessage);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SizeSelectionDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Cup Size";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
