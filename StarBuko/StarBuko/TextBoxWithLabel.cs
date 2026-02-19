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
        
        // Store primitives instead of domain object (Tip #3: Never store domain objects)
        private string _productName;
        private decimal _basePrice;

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

        // Keep for backward compatibility but decompose internally
        public Product Product
        {
            get => new Product 
            { 
                Name = _productName, 
                BasePrice = _basePrice,
                ProductImage = pictureBox1.Image
            };
            set
            {
                if (value != null)
                {
                    _productName = value.Name;
                    _basePrice = value.BasePrice;
                    TextBoxName = value.Name;
                    TextBoxPrice = "₱ " + value.BasePrice.ToString("F2");
                    ProductImage = value.ProductImage;
                }
            }
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

        // Tip #4: Raise events - Don't perform actions
        protected virtual void OnProductClicked()
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }

        // Tip #2: Expose UI-Friendly properties - Prefer primitives
        public string TextBoxName
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        // Tip #5: Keep formatting inside the control
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

        // Additional primitive properties for direct access
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                TextBoxName = value;
            }
        }

        public decimal BasePrice
        {
            get => _basePrice;
            set
            {
                _basePrice = value;
                TextBoxPrice = "₱ " + value.ToString("F2");
            }
        }
    }
}
