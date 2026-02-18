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

        private void SizeSelectionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If form is closing and no button was clicked, it's the X button
            if (!buttonClicked)
            {
                SelectedSize = null;
            }
        }

        private void InitializeComponent()
        {
            this.btnYes = new Button();
            this.btnNo = new Button();
            this.btnCancel = new Button();
            this.lblMessage = new Label();
            this.pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new Size(32, 32);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Image = SystemIcons.Question.ToBitmap();
            
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = false;
            this.lblMessage.Location = new Point(60, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new Size(300, 80);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Choose Cup Size:\n\n\tYes for Grande (+20)\n\tNo for Venti (+30)\n\tCancel for Regular";
            
            // 
            // btnYes
            // 
            this.btnYes.Location = new Point(84, 105);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new Size(75, 23);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += (s, e) => {
                buttonClicked = true;
                SelectedSize = "Grande";
                this.DialogResult = DialogResult.Yes;
                this.Close();
            };
            
            // 
            // btnNo
            // 
            this.btnNo.Location = new Point(165, 105);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new Size(75, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += (s, e) => {
                buttonClicked = true;
                SelectedSize = "Venti";
                this.DialogResult = DialogResult.No;
                this.Close();
            };
            
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(246, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += (s, e) => {
                buttonClicked = true;
                SelectedSize = "Regular";
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
            
            // 
            // SizeSelectionDialog
            // 
            this.ClientSize = new Size(380, 145);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SizeSelectionDialog";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Select Cup Size";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
