namespace StarBuko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();
            Product product4 = new Product();
            Product product5 = new Product();
            Product product6 = new Product();
            Product product7 = new Product();
            Product product8 = new Product();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxWithLabel8 = new TextBoxWithLabel();
            textBoxWithLabel3 = new TextBoxWithLabel();
            textBoxWithLabel7 = new TextBoxWithLabel();
            textBoxWithLabel1 = new TextBoxWithLabel();
            textBoxWithLabel6 = new TextBoxWithLabel();
            textBoxWithLabel2 = new TextBoxWithLabel();
            textBoxWithLabel5 = new TextBoxWithLabel();
            textBoxWithLabel4 = new TextBoxWithLabel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 45);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(1159, 459);
            splitContainer1.SplitterDistance = 501;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(textBoxWithLabel8, 1, 3);
            tableLayoutPanel2.Controls.Add(textBoxWithLabel3, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxWithLabel7, 0, 3);
            tableLayoutPanel2.Controls.Add(textBoxWithLabel1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxWithLabel6, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxWithLabel2, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxWithLabel5, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxWithLabel4, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.4897957F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.5102043F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Size = new Size(494, 398);
            tableLayoutPanel2.TabIndex = 8;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // textBoxWithLabel8
            // 
            textBoxWithLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel8.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel8.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel8.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel8.Location = new Point(250, 300);
            textBoxWithLabel8.Name = "textBoxWithLabel8";
            product1.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product1.Name = null;
            product1.ProductImage = Properties.Resources.dark_caramel_frappucino;
            textBoxWithLabel8.Product = product1;
            textBoxWithLabel8.ProductImage = Properties.Resources.dark_caramel_frappucino;
            textBoxWithLabel8.Size = new Size(241, 94);
            textBoxWithLabel8.TabIndex = 7;
            textBoxWithLabel8.TextBoxName = "Dark Caramel Coffee Frappuccino";
            textBoxWithLabel8.TextBoxPrice = "₱ 170.00";
            // 
            // textBoxWithLabel3
            // 
            textBoxWithLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel3.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel3.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel3.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel3.Location = new Point(3, 100);
            textBoxWithLabel3.Name = "textBoxWithLabel3";
            product2.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product2.Name = null;
            product2.ProductImage = Properties.Resources.strawberry_acai;
            textBoxWithLabel3.Product = product2;
            textBoxWithLabel3.ProductImage = Properties.Resources.strawberry_acai;
            textBoxWithLabel3.Size = new Size(241, 93);
            textBoxWithLabel3.TabIndex = 2;
            textBoxWithLabel3.TextBoxName = "Strawberry Açaí with Lemonade";
            textBoxWithLabel3.TextBoxPrice = "₱ 160.00";
            // 
            // textBoxWithLabel7
            // 
            textBoxWithLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel7.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel7.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel7.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel7.Location = new Point(3, 300);
            textBoxWithLabel7.Name = "textBoxWithLabel7";
            product3.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product3.Name = null;
            product3.ProductImage = Properties.Resources.chocolate_chip;
            textBoxWithLabel7.Product = product3;
            textBoxWithLabel7.ProductImage = Properties.Resources.chocolate_chip;
            textBoxWithLabel7.Size = new Size(241, 94);
            textBoxWithLabel7.TabIndex = 6;
            textBoxWithLabel7.TextBoxName = "Chocolate Chip Cream Frappuccino";
            textBoxWithLabel7.TextBoxPrice = "₱ 180.00";
            // 
            // textBoxWithLabel1
            // 
            textBoxWithLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel1.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel1.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel1.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel1.Location = new Point(3, 3);
            textBoxWithLabel1.Name = "textBoxWithLabel1";
            product4.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product4.Name = null;
            product4.ProductImage = Properties.Resources.matcha_latte;
            textBoxWithLabel1.Product = product4;
            textBoxWithLabel1.ProductImage = Properties.Resources.matcha_latte;
            textBoxWithLabel1.Size = new Size(241, 91);
            textBoxWithLabel1.TabIndex = 0;
            textBoxWithLabel1.TextBoxName = "Creamy Pure Matcha Latte";
            textBoxWithLabel1.TextBoxPrice = "₱ 180.00";
            // 
            // textBoxWithLabel6
            // 
            textBoxWithLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel6.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel6.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel6.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel6.Location = new Point(250, 199);
            textBoxWithLabel6.Name = "textBoxWithLabel6";
            product5.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product5.Name = null;
            product5.ProductImage = Properties.Resources.strawberries_cream;
            textBoxWithLabel6.Product = product5;
            textBoxWithLabel6.ProductImage = Properties.Resources.strawberries_cream;
            textBoxWithLabel6.Size = new Size(241, 94);
            textBoxWithLabel6.TabIndex = 5;
            textBoxWithLabel6.TextBoxName = "Strawberries Cream Frappuccino";
            textBoxWithLabel6.TextBoxPrice = "₱ 175.00";
            // 
            // textBoxWithLabel2
            // 
            textBoxWithLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel2.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel2.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel2.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel2.Location = new Point(250, 3);
            textBoxWithLabel2.Name = "textBoxWithLabel2";
            product6.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product6.Name = null;
            product6.ProductImage = Properties.Resources.xoxo_frappucino;
            textBoxWithLabel2.Product = product6;
            textBoxWithLabel2.ProductImage = Properties.Resources.xoxo_frappucino;
            textBoxWithLabel2.Size = new Size(241, 91);
            textBoxWithLabel2.TabIndex = 1;
            textBoxWithLabel2.TextBoxName = "XOXO Frappuccino";
            textBoxWithLabel2.TextBoxPrice = "₱ 150.00";
            // 
            // textBoxWithLabel5
            // 
            textBoxWithLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel5.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel5.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel5.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel5.Location = new Point(3, 199);
            textBoxWithLabel5.Name = "textBoxWithLabel5";
            product7.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product7.Name = null;
            product7.ProductImage = Properties.Resources.dragon_drink;
            textBoxWithLabel5.Product = product7;
            textBoxWithLabel5.ProductImage = Properties.Resources.dragon_drink;
            textBoxWithLabel5.Size = new Size(241, 94);
            textBoxWithLabel5.TabIndex = 4;
            textBoxWithLabel5.TextBoxName = "Dragon Drink with Mango Dragonfruit";
            textBoxWithLabel5.TextBoxPrice = "₱ 170.00";
            // 
            // textBoxWithLabel4
            // 
            textBoxWithLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWithLabel4.BackColor = Color.FromArgb(3, 53, 44);
            textBoxWithLabel4.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            textBoxWithLabel4.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithLabel4.Location = new Point(250, 100);
            textBoxWithLabel4.Name = "textBoxWithLabel4";
            product8.BasePrice = new decimal(new int[] { 0, 0, 0, 0 });
            product8.Name = null;
            product8.ProductImage = Properties.Resources.pink_drink;
            textBoxWithLabel4.Product = product8;
            textBoxWithLabel4.ProductImage = Properties.Resources.pink_drink;
            textBoxWithLabel4.Size = new Size(241, 93);
            textBoxWithLabel4.TabIndex = 3;
            textBoxWithLabel4.TextBoxName = "Pink Drink with Strawberry Açaí";
            textBoxWithLabel4.TextBoxPrice = "₱ 165.00";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 362);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(3, 53, 44);
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            dataGridView1.GridColor = Color.FromArgb(3, 53, 44);
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(648, 356);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(3, 53, 44);
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "Product Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 112;
            // 
            // Column2
            // 
            Column2.HeaderText = "Qty";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 52;
            // 
            // Column5
            // 
            Column5.HeaderText = "Upsize";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 69;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 60;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total Price";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 90;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.7358475F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.2641525F));
            tableLayoutPanel1.Controls.Add(label6, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 371);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(654, 88);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(596, 60);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 5;
            label6.Text = "₱ 0.00";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(596, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 30);
            label5.TabIndex = 4;
            label5.Text = "₱ 0.00";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(394, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            label2.Location = new Point(130, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 0;
            label2.Text = "Total Amount";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 30);
            label3.Name = "label3";
            label3.Size = new Size(142, 30);
            label3.TabIndex = 1;
            label3.Text = "Amount Tendered";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(178, 60);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 3;
            label4.Text = "Change";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1035, 16);
            button1.Name = "button1";
            button1.Size = new Size(133, 26);
            button1.TabIndex = 1;
            button1.Text = "Add New Transaction";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 1;
            label1.Text = "StarBuko";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 53, 44);
            ClientSize = new Size(1183, 516);
            Controls.Add(button1);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "StarBuko";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBoxWithLabel textBoxWithLabel1;
        private TextBoxWithLabel textBoxWithLabel2;
        private TextBoxWithLabel textBoxWithLabel8;
        private TextBoxWithLabel textBoxWithLabel7;
        private TextBoxWithLabel textBoxWithLabel6;
        private TextBoxWithLabel textBoxWithLabel5;
        private TextBoxWithLabel textBoxWithLabel4;
        private TextBoxWithLabel textBoxWithLabel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
