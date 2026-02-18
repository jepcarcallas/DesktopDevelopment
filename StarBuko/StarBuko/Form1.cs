namespace StarBuko
{
    public partial class Form1 : Form
    {
        private decimal totalAmount = 0;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            // Set default cell style for data rows to black text
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

            // If columns already exist:
            if (dataGridView1.Columns.Contains("Qty"))
                dataGridView1.Columns["Qty"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            if (dataGridView1.Columns.Contains("Price"))
            {
                dataGridView1.Columns["Price"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["Price"].DefaultCellStyle.Format = "N2";
            }

            if (dataGridView1.Columns.Contains("TotalPrice"))
            {
                dataGridView1.Columns["TotalPrice"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dataGridView1.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += (s, e) => AddNewTransaction();
            
            // Add ProductClicked event handlers for all product boxes
            textBoxWithLabel1.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel1.TextBoxName, textBoxWithLabel1.TextBoxPrice);
            textBoxWithLabel2.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel2.TextBoxName, textBoxWithLabel2.TextBoxPrice);
            textBoxWithLabel3.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel3.TextBoxName, textBoxWithLabel3.TextBoxPrice);
            textBoxWithLabel4.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel4.TextBoxName, textBoxWithLabel4.TextBoxPrice);
            textBoxWithLabel5.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel5.TextBoxName, textBoxWithLabel5.TextBoxPrice);
            textBoxWithLabel6.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel6.TextBoxName, textBoxWithLabel6.TextBoxPrice);
            textBoxWithLabel7.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel7.TextBoxName, textBoxWithLabel7.TextBoxPrice);
            textBoxWithLabel8.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel8.TextBoxName, textBoxWithLabel8.TextBoxPrice);
            
            // Add text changed event for amount tendered
            textBox1.TextChanged += (s, e) => CalculateChange();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public DialogResult ShowSizeSelectionPopup(out string size)
        {
            using (var dialog = new SizeSelectionDialog())
            {
                var result = dialog.ShowDialog(this);
                size = dialog.SelectedSize;
                return result;
            }
        }

        private void AddProductToCart(string productName, string priceText)
        {
            // Show size selection popup
            var result = ShowSizeSelectionPopup(out string size);
            
            // If user closed the dialog without selecting (X button), return without adding to cart
            if (size == null)
                return;
            
            // Parse price (remove ₱ and spaces)
            string cleanPrice = priceText.Replace("₱", "").Trim();
            if (!decimal.TryParse(cleanPrice, out decimal basePrice))
                return;

            // Add size premium
            decimal priceWithSize = basePrice;
            if (size == "Grande")
                priceWithSize += 20;
            else if (size == "Venti")
                priceWithSize += 30;

            // Format product name with size
            string fullProductName = $"{productName} ({size})";

            // Check if product already exists in cart
            bool productExists = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column1"].Value != null && 
                    row.Cells["Column1"].Value.ToString() == fullProductName)
                {
                    // Increment quantity
                    int currentQty = (int)row.Cells["Column2"].Value;
                    row.Cells["Column2"].Value = currentQty + 1;
                    
                    // Recalculate total for this row
                    decimal rowTotal = priceWithSize * (currentQty + 1);
                    row.Cells["Column4"].Value = rowTotal.ToString("F2");
                    
                    productExists = true;
                    break;
                }
            }

            // If product doesn't exist, add new row
            if (!productExists)
            {
                dataGridView1.Rows.Add(
                    fullProductName,
                    1,
                    size,
                    priceWithSize.ToString("F2"),
                    priceWithSize.ToString("F2")
                );
            }

            // Update total amount
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column4"].Value != null && 
                    decimal.TryParse(row.Cells["Column4"].Value.ToString(), out decimal rowTotal))
                {
                    totalAmount += rowTotal;
                }
            }
            label5.Text = "₱ " + totalAmount.ToString("F2");
            CalculateChange();
        }

        private void CalculateChange()
        {
            if (decimal.TryParse(textBox1.Text, out decimal amountTendered))
            {
                decimal change = amountTendered - totalAmount;
                if (change < 0)
                    label6.Text = "₱ 0.00";
                else
                    label6.Text = "₱ " + change.ToString("F2");
            }
            else
            {
                label6.Text = "₱ 0.00";
            }
        }

        private void AddNewTransaction()
        {
            dataGridView1.Rows.Clear();
            label5.Text = "₱ 0.00";
            textBox1.Clear();
            label6.Text = "₱ 0.00";
            totalAmount = 0;
        }
    }
}


