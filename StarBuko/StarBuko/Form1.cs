namespace StarBuko
{
    public partial class Form1 : Form
    {
        private decimal totalAmount = 0;
        private ProductService productService;

        public Form1()
        {
            InitializeComponent();
            
            productService = new ProductService();
            InitializeDataGridView();
            AssignProductsToControls();
        }

        private void AssignProductsToControls()
        {
            var products = productService.GetAllProducts();
            
            if (products.Count >= 8)
            {
                textBoxWithLabel1.Product = products[0];
                textBoxWithLabel2.Product = products[1];
                textBoxWithLabel3.Product = products[2];
                textBoxWithLabel4.Product = products[3];
                textBoxWithLabel5.Product = products[4];
                textBoxWithLabel6.Product = products[5];
                textBoxWithLabel7.Product = products[6];
                textBoxWithLabel8.Product = products[7];
            }
        }

        private void InitializeDataGridView()
        {
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

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

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

            textBoxWithLabel1.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel1.Product);
            textBoxWithLabel2.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel2.Product);
            textBoxWithLabel3.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel3.Product);
            textBoxWithLabel4.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel4.Product);
            textBoxWithLabel5.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel5.Product);
            textBoxWithLabel6.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel6.Product);
            textBoxWithLabel7.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel7.Product);
            textBoxWithLabel8.ProductClicked += (s, e) => AddProductToCart(textBoxWithLabel8.Product);

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

        private void AddProductToCart(Product product)
        {
            if (product == null)
                return;

            var result = ShowSizeSelectionPopup(out string size);

            if (size == null)
                return;

            decimal priceWithSize = product.GetPriceForSize(size);

            bool productExists = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column1"].Value != null &&
                    row.Cells["Column1"].Value.ToString() == product.Name &&
                    row.Cells["Column5"].Value != null &&
                    row.Cells["Column5"].Value.ToString() == size)
                {
                    int currentQty = (int)row.Cells["Column2"].Value;
                    row.Cells["Column2"].Value = currentQty + 1;

                    decimal rowTotal = priceWithSize * (currentQty + 1);
                    row.Cells["Column4"].Value = rowTotal.ToString("F2");

                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                dataGridView1.Rows.Add(
                    product.Name,
                    1,
                    size,
                    priceWithSize.ToString("F2"),
                    priceWithSize.ToString("F2")
                );
            }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


