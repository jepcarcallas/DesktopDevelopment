using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarBuko
{
    public partial class TextBoxWithLabel : UserControl
    {
        // Create a custom click event
        public event EventHandler ProductClicked;

        public TextBoxWithLabel()
        {
            InitializeComponent();
            
            // Wire up click events for all child controls
            pictureBox1.Click += ChildControl_Click;
            label2.Click += ChildControl_Click;
            label3.Click += ChildControl_Click;
            tableLayoutPanel1.Click += ChildControl_Click;
            tableLayoutPanel2.Click += ChildControl_Click;
        }

        private void ChildControl_Click(object sender, EventArgs e)
        {
            OnProductClicked();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            OnProductClicked();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            OnProductClicked();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OnProductClicked();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected virtual void OnProductClicked()
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }

        public string TextBoxName
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        public string TextBoxPrice
        {
            get => label3.Text;
            set => label3.Text = value;
        }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }
    }
}
