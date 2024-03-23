namespace OnlineStore
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            CustomersPage = new TabPage();
            label1 = new Label();
            middleNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            customerInsertButton = new Button();
            customerUpdateButton = new Button();
            label3 = new Label();
            customerDeleteButton = new Button();
            label2 = new Label();
            lastNameTextBox = new TextBox();
            ProductsPage = new TabPage();
            label6 = new Label();
            priceTextBox = new NumericUpDown();
            productInsertButton = new Button();
            productUpdateButton = new Button();
            productDeleteButton = new Button();
            label7 = new Label();
            nameTextBox = new TextBox();
            OrdersPage = new TabPage();
            label18 = new Label();
            OrdersProductsPage = new TabPage();
            label16 = new Label();
            Report = new TabPage();
            label5 = new Label();
            ReportProduct = new Button();
            ReportWorker = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            CustomersPage.SuspendLayout();
            ProductsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceTextBox).BeginInit();
            OrdersPage.SuspendLayout();
            OrdersProductsPage.SuspendLayout();
            Report.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CustomersPage);
            tabControl1.Controls.Add(ProductsPage);
            tabControl1.Controls.Add(OrdersPage);
            tabControl1.Controls.Add(OrdersProductsPage);
            tabControl1.Controls.Add(Report);
            tabControl1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ItemSize = new Size(150, 25);
            tabControl1.Location = new Point(34, 48);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(909, 391);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 12;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // CustomersPage
            // 
            CustomersPage.BackColor = Color.Snow;
            CustomersPage.Controls.Add(label1);
            CustomersPage.Controls.Add(middleNameTextBox);
            CustomersPage.Controls.Add(firstNameTextBox);
            CustomersPage.Controls.Add(customerInsertButton);
            CustomersPage.Controls.Add(customerUpdateButton);
            CustomersPage.Controls.Add(label3);
            CustomersPage.Controls.Add(customerDeleteButton);
            CustomersPage.Controls.Add(label2);
            CustomersPage.Controls.Add(lastNameTextBox);
            CustomersPage.Location = new Point(4, 29);
            CustomersPage.Margin = new Padding(3, 4, 3, 4);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3, 4, 3, 4);
            CustomersPage.Size = new Size(901, 358);
            CustomersPage.TabIndex = 0;
            CustomersPage.Text = "Покупатели";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 146);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Отчество:";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameTextBox.Location = new Point(189, 143);
            middleNameTextBox.Margin = new Padding(3, 4, 3, 4);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(180, 27);
            middleNameTextBox.TabIndex = 12;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(189, 87);
            firstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(180, 27);
            firstNameTextBox.TabIndex = 11;
            // 
            // customerInsertButton
            // 
            customerInsertButton.BackColor = Color.FromArgb(0, 192, 0);
            customerInsertButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerInsertButton.Location = new Point(280, 229);
            customerInsertButton.Margin = new Padding(3, 4, 3, 4);
            customerInsertButton.Name = "customerInsertButton";
            customerInsertButton.Size = new Size(127, 45);
            customerInsertButton.TabIndex = 2;
            customerInsertButton.Text = "Добавить";
            customerInsertButton.UseVisualStyleBackColor = false;
            customerInsertButton.Click += customerInsertButton_Click;
            // 
            // customerUpdateButton
            // 
            customerUpdateButton.BackColor = Color.Yellow;
            customerUpdateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerUpdateButton.Location = new Point(413, 229);
            customerUpdateButton.Margin = new Padding(3, 4, 3, 4);
            customerUpdateButton.Name = "customerUpdateButton";
            customerUpdateButton.Size = new Size(127, 45);
            customerUpdateButton.TabIndex = 3;
            customerUpdateButton.Text = "Изменить ()";
            customerUpdateButton.UseVisualStyleBackColor = false;
            customerUpdateButton.Click += customerUpdateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 87);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "Имя:";
            // 
            // customerDeleteButton
            // 
            customerDeleteButton.BackColor = Color.Red;
            customerDeleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            customerDeleteButton.Location = new Point(546, 229);
            customerDeleteButton.Margin = new Padding(3, 4, 3, 4);
            customerDeleteButton.Name = "customerDeleteButton";
            customerDeleteButton.Size = new Size(127, 45);
            customerDeleteButton.TabIndex = 4;
            customerDeleteButton.Text = "Удалить ()";
            customerDeleteButton.UseVisualStyleBackColor = false;
            customerDeleteButton.Click += deleteButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 38);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Фамилия:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(189, 35);
            lastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(180, 27);
            lastNameTextBox.TabIndex = 6;
            // 
            // ProductsPage
            // 
            ProductsPage.BackColor = Color.Snow;
            ProductsPage.Controls.Add(label6);
            ProductsPage.Controls.Add(priceTextBox);
            ProductsPage.Controls.Add(productInsertButton);
            ProductsPage.Controls.Add(productUpdateButton);
            ProductsPage.Controls.Add(productDeleteButton);
            ProductsPage.Controls.Add(label7);
            ProductsPage.Controls.Add(nameTextBox);
            ProductsPage.Location = new Point(4, 29);
            ProductsPage.Margin = new Padding(3, 4, 3, 4);
            ProductsPage.Name = "ProductsPage";
            ProductsPage.Padding = new Padding(3, 4, 3, 4);
            ProductsPage.Size = new Size(901, 358);
            ProductsPage.TabIndex = 1;
            ProductsPage.Text = "Продукты";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(28, 85);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 25;
            label6.Text = "Цена:";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(128, 82);
            priceTextBox.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(116, 23);
            priceTextBox.TabIndex = 24;
            // 
            // productInsertButton
            // 
            productInsertButton.BackColor = Color.FromArgb(0, 192, 0);
            productInsertButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productInsertButton.Location = new Point(277, 229);
            productInsertButton.Margin = new Padding(3, 4, 3, 4);
            productInsertButton.Name = "productInsertButton";
            productInsertButton.Size = new Size(127, 45);
            productInsertButton.TabIndex = 21;
            productInsertButton.Text = "Добавить";
            productInsertButton.UseVisualStyleBackColor = false;
            productInsertButton.Click += productInsertButton_Click;
            // 
            // productUpdateButton
            // 
            productUpdateButton.BackColor = Color.Yellow;
            productUpdateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productUpdateButton.Location = new Point(410, 229);
            productUpdateButton.Margin = new Padding(3, 4, 3, 4);
            productUpdateButton.Name = "productUpdateButton";
            productUpdateButton.Size = new Size(127, 45);
            productUpdateButton.TabIndex = 22;
            productUpdateButton.Text = "Изменить ()";
            productUpdateButton.UseVisualStyleBackColor = false;
            productUpdateButton.Click += productUpdateButton_Click;
            // 
            // productDeleteButton
            // 
            productDeleteButton.BackColor = Color.Red;
            productDeleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productDeleteButton.Location = new Point(543, 229);
            productDeleteButton.Margin = new Padding(3, 4, 3, 4);
            productDeleteButton.Name = "productDeleteButton";
            productDeleteButton.Size = new Size(127, 45);
            productDeleteButton.TabIndex = 23;
            productDeleteButton.Text = "Удалить ()";
            productDeleteButton.UseVisualStyleBackColor = false;
            productDeleteButton.Click += deleteButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(28, 41);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 18;
            label7.Text = "Название:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(128, 38);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(115, 27);
            nameTextBox.TabIndex = 15;
            // 
            // OrdersPage
            // 
            OrdersPage.BackColor = Color.Snow;
            OrdersPage.Controls.Add(label18);
            OrdersPage.Location = new Point(4, 29);
            OrdersPage.Margin = new Padding(3, 4, 3, 4);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Size = new Size(901, 358);
            OrdersPage.TabIndex = 2;
            OrdersPage.Text = "Договоры";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(25, 34);
            label18.Name = "label18";
            label18.Size = new Size(528, 100);
            label18.TabIndex = 20;
            label18.Text = "    Таблица заказы служит для хранения заказов и имеет следующие поля:\r\n- Id\r\n-Id покупателя\r\n-Количество товаров\r\n-Сумма\r\n";
            // 
            // OrdersProductsPage
            // 
            OrdersProductsPage.BackColor = Color.Snow;
            OrdersProductsPage.Controls.Add(label16);
            OrdersProductsPage.Location = new Point(4, 29);
            OrdersProductsPage.Margin = new Padding(3, 4, 3, 4);
            OrdersProductsPage.Name = "OrdersProductsPage";
            OrdersProductsPage.Size = new Size(901, 358);
            OrdersProductsPage.TabIndex = 3;
            OrdersProductsPage.Text = "Накладные";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(25, 34);
            label16.Name = "label16";
            label16.Size = new Size(562, 120);
            label16.TabIndex = 20;
            label16.Text = "    Таблица OrdersProducts служит для хранения товаров в заказе и имеет поля:\r\n- Id договора\r\n- Id продукта\r\n- Количество\r\n- Сумма\r\n-Предоплата(чекбокс)";
            // 
            // Report
            // 
            Report.Controls.Add(label5);
            Report.Controls.Add(ReportProduct);
            Report.Controls.Add(ReportWorker);
            Report.Location = new Point(4, 29);
            Report.Name = "Report";
            Report.Padding = new Padding(3);
            Report.Size = new Size(901, 358);
            Report.TabIndex = 4;
            Report.Text = "Отчеты";
            Report.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 25);
            label5.Name = "label5";
            label5.Size = new Size(326, 20);
            label5.TabIndex = 21;
            label5.Text = "Создание отчетов по покупателям и товарам";
            // 
            // ReportProduct
            // 
            ReportProduct.BackColor = Color.FromArgb(0, 0, 64);
            ReportProduct.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ReportProduct.ForeColor = Color.White;
            ReportProduct.Location = new Point(226, 130);
            ReportProduct.Margin = new Padding(3, 4, 3, 4);
            ReportProduct.Name = "ReportProduct";
            ReportProduct.Size = new Size(176, 91);
            ReportProduct.TabIndex = 4;
            ReportProduct.Text = "Отчет по \r\nПродуктам";
            ReportProduct.UseVisualStyleBackColor = false;
            ReportProduct.Click += ReportProduct_Click;
            // 
            // ReportWorker
            // 
            ReportWorker.BackColor = Color.FromArgb(0, 0, 64);
            ReportWorker.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ReportWorker.ForeColor = Color.White;
            ReportWorker.Location = new Point(25, 130);
            ReportWorker.Margin = new Padding(3, 4, 3, 4);
            ReportWorker.Name = "ReportWorker";
            ReportWorker.Size = new Size(175, 91);
            ReportWorker.TabIndex = 5;
            ReportWorker.Text = "Отчет по \r\nПокупателям\r\n";
            ReportWorker.UseVisualStyleBackColor = false;
            ReportWorker.Click += ReportWorker_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 764);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(982, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = SystemColors.Highlight;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(129, 20);
            toolStripStatusLabel1.Text = "Number of row(s):";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 900);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 457);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(905, 279);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(982, 790);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "(задание 2)";
            tabControl1.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            CustomersPage.PerformLayout();
            ProductsPage.ResumeLayout(false);
            ProductsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceTextBox).EndInit();
            OrdersPage.ResumeLayout(false);
            OrdersPage.PerformLayout();
            OrdersProductsPage.ResumeLayout(false);
            OrdersProductsPage.PerformLayout();
            Report.ResumeLayout(false);
            Report.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customerInsertButton;
        private System.Windows.Forms.Button customerUpdateButton;
        private System.Windows.Forms.Button customerDeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomersPage;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage OrdersProductsPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button productInsertButton;
        private System.Windows.Forms.Button productUpdateButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private TabPage Report;
        private Button ReportProduct;
        private Button ReportWorker;
        private Label label5;
        private Label label6;
        private NumericUpDown priceTextBox;
        private Label label1;
        private TextBox middleNameTextBox;
        private TextBox firstNameTextBox;
    }
}

