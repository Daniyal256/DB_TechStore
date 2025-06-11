namespace WinFormsApp1
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MyProfile = new TabControl();
            My_Profile = new TabPage();
            btnUpdate = new Button();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Shop = new TabPage();
            tbId = new TextBox();
            label14 = new Label();
            btnCheckout = new Button();
            tbTotal = new TextBox();
            label6 = new Label();
            dgvCart = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            cartPrice = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnCart = new Button();
            Quantity = new NumericUpDown();
            label5 = new Label();
            dgvProducts = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            My_Orders = new TabPage();
            panelOrderDetails = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dgvOrders = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            PaymentStatus = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            label8 = new Label();
            cmdFilterStatus = new ComboBox();
            txtSearchOrders = new TextBox();
            label7 = new Label();
            Repairs = new TabPage();
            MyProfile.SuspendLayout();
            My_Profile.SuspendLayout();
            Shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            My_Orders.SuspendLayout();
            panelOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // MyProfile
            // 
            MyProfile.Controls.Add(My_Profile);
            MyProfile.Controls.Add(Shop);
            MyProfile.Controls.Add(My_Orders);
            MyProfile.Controls.Add(Repairs);
            MyProfile.Dock = DockStyle.Fill;
            MyProfile.Location = new Point(0, 0);
            MyProfile.Margin = new Padding(6);
            MyProfile.Name = "MyProfile";
            MyProfile.SelectedIndex = 0;
            MyProfile.Size = new Size(1711, 1348);
            MyProfile.TabIndex = 0;
            // 
            // My_Profile
            // 
            My_Profile.Controls.Add(btnUpdate);
            My_Profile.Controls.Add(tbPhone);
            My_Profile.Controls.Add(tbAddress);
            My_Profile.Controls.Add(tbEmail);
            My_Profile.Controls.Add(tbName);
            My_Profile.Controls.Add(label4);
            My_Profile.Controls.Add(label3);
            My_Profile.Controls.Add(label2);
            My_Profile.Controls.Add(label1);
            My_Profile.Location = new Point(8, 46);
            My_Profile.Margin = new Padding(6);
            My_Profile.Name = "My_Profile";
            My_Profile.Padding = new Padding(6);
            My_Profile.Size = new Size(1695, 1294);
            My_Profile.TabIndex = 0;
            My_Profile.Text = "My Profile";
            My_Profile.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(650, 546);
            btnUpdate.Margin = new Padding(6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 83);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(773, 309);
            tbPhone.Margin = new Padding(6);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(182, 39);
            tbPhone.TabIndex = 7;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(773, 399);
            tbAddress.Margin = new Padding(6);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(182, 39);
            tbAddress.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(773, 230);
            tbEmail.Margin = new Padding(6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(182, 39);
            tbEmail.TabIndex = 5;
            // 
            // tbName
            // 
            tbName.Location = new Point(773, 143);
            tbName.Margin = new Padding(6);
            tbName.Name = "tbName";
            tbName.Size = new Size(182, 39);
            tbName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 399);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 3;
            label4.Text = "Address:  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 309);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 230);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 1;
            label2.Text = "Email:  ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 160);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 0;
            label1.Text = "Name:  ";
            // 
            // Shop
            // 
            Shop.Controls.Add(tbId);
            Shop.Controls.Add(label14);
            Shop.Controls.Add(btnCheckout);
            Shop.Controls.Add(tbTotal);
            Shop.Controls.Add(label6);
            Shop.Controls.Add(dgvCart);
            Shop.Controls.Add(btnCart);
            Shop.Controls.Add(Quantity);
            Shop.Controls.Add(label5);
            Shop.Controls.Add(dgvProducts);
            Shop.Location = new Point(8, 46);
            Shop.Margin = new Padding(6);
            Shop.Name = "Shop";
            Shop.Padding = new Padding(6);
            Shop.Size = new Size(1695, 1294);
            Shop.TabIndex = 1;
            Shop.Text = "Shop";
            Shop.UseVisualStyleBackColor = true;
            // 
            // tbId
            // 
            tbId.Location = new Point(268, 406);
            tbId.Name = "tbId";
            tbId.Size = new Size(200, 39);
            tbId.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 407);
            label14.Name = "label14";
            label14.Size = new Size(193, 32);
            label14.TabIndex = 8;
            label14.Text = "Enter ProductID: ";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(613, 817);
            btnCheckout.Margin = new Padding(6);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(214, 96);
            btnCheckout.TabIndex = 7;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(201, 565);
            tbTotal.Margin = new Padding(6);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(182, 39);
            tbTotal.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 565);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 32);
            label6.TabIndex = 5;
            label6.Text = "TotalAmount:  ";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { Product, Qty, cartPrice, SubTotal });
            dgvCart.Location = new Point(748, 424);
            dgvCart.Margin = new Padding(6);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 82;
            dgvCart.Size = new Size(894, 292);
            dgvCart.TabIndex = 4;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 10;
            Product.Name = "Product";
            Product.Width = 200;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 10;
            Qty.Name = "Qty";
            Qty.Width = 200;
            // 
            // cartPrice
            // 
            cartPrice.HeaderText = "Price";
            cartPrice.MinimumWidth = 10;
            cartPrice.Name = "cartPrice";
            cartPrice.Width = 200;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Subtotal";
            SubTotal.MinimumWidth = 10;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 200;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(372, 470);
            btnCart.Margin = new Padding(6);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(139, 49);
            btnCart.TabIndex = 3;
            btnCart.Text = "AddToCart";
            btnCart.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(178, 470);
            Quantity.Margin = new Padding(6);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(104, 39);
            Quantity.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 470);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 1;
            label5.Text = "Quantity:  ";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Brand, Category, Stock, Price });
            dgvProducts.Location = new Point(7, 4);
            dgvProducts.Margin = new Padding(6);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.Size = new Size(1292, 382);
            dgvProducts.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Width = 200;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 10;
            Name.Name = "Name";
            Name.Width = 200;
            // 
            // Brand
            // 
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 10;
            Brand.Name = "Brand";
            Brand.Width = 200;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 10;
            Category.Name = "Category";
            Category.Width = 200;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 10;
            Stock.Name = "Stock";
            Stock.Width = 200;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 10;
            Price.Name = "Price";
            Price.Width = 200;
            // 
            // My_Orders
            // 
            My_Orders.Controls.Add(panelOrderDetails);
            My_Orders.Controls.Add(dgvOrders);
            My_Orders.Controls.Add(label8);
            My_Orders.Controls.Add(cmdFilterStatus);
            My_Orders.Controls.Add(txtSearchOrders);
            My_Orders.Controls.Add(label7);
            My_Orders.Location = new Point(8, 46);
            My_Orders.Margin = new Padding(6);
            My_Orders.Name = "My_Orders";
            My_Orders.Size = new Size(1695, 1294);
            My_Orders.TabIndex = 2;
            My_Orders.Text = "My Orders";
            My_Orders.UseVisualStyleBackColor = true;
            // 
            // panelOrderDetails
            // 
            panelOrderDetails.Controls.Add(label13);
            panelOrderDetails.Controls.Add(label12);
            panelOrderDetails.Controls.Add(label11);
            panelOrderDetails.Controls.Add(label10);
            panelOrderDetails.Controls.Add(label9);
            panelOrderDetails.Location = new Point(28, 452);
            panelOrderDetails.Margin = new Padding(6);
            panelOrderDetails.Name = "panelOrderDetails";
            panelOrderDetails.Size = new Size(1367, 819);
            panelOrderDetails.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 343);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(177, 32);
            label13.TabIndex = 4;
            label13.Text = "Total Amount:  ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 282);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(203, 32);
            label12.TabIndex = 3;
            label12.Text = "Payment Status :  ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 215);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(97, 32);
            label11.TabIndex = 2;
            label11.Text = "Status:  ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 137);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(151, 32);
            label10.TabIndex = 1;
            label10.Text = "Order Date:  ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 62);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 32);
            label9.TabIndex = 0;
            label9.Text = "Order ID:  ";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderDate, Column1, Status, TotalAmount, PaymentStatus, Actions });
            dgvOrders.Location = new Point(15, 115);
            dgvOrders.Margin = new Padding(6);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 82;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1483, 311);
            dgvOrders.TabIndex = 4;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 10;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Width = 200;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "OrderDate";
            OrderDate.MinimumWidth = 10;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 200;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 10;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 200;
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "TotalAmount";
            TotalAmount.MinimumWidth = 10;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Width = 200;
            // 
            // PaymentStatus
            // 
            PaymentStatus.HeaderText = "PaymentStatus";
            PaymentStatus.MinimumWidth = 10;
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.ReadOnly = true;
            PaymentStatus.Width = 200;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 10;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Width = 200;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 41);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 32);
            label8.TabIndex = 3;
            label8.Text = "Filter:  ";
            // 
            // cmdFilterStatus
            // 
            cmdFilterStatus.FormattingEnabled = true;
            cmdFilterStatus.Items.AddRange(new object[] { "All", "Pending", "Shipped", "Delivered", "Cancelled" });
            cmdFilterStatus.Location = new Point(423, 34);
            cmdFilterStatus.Margin = new Padding(6);
            cmdFilterStatus.Name = "cmdFilterStatus";
            cmdFilterStatus.Size = new Size(143, 40);
            cmdFilterStatus.TabIndex = 2;
            // 
            // txtSearchOrders
            // 
            txtSearchOrders.Location = new Point(130, 28);
            txtSearchOrders.Margin = new Padding(6);
            txtSearchOrders.Name = "txtSearchOrders";
            txtSearchOrders.Size = new Size(151, 39);
            txtSearchOrders.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 34);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 32);
            label7.TabIndex = 0;
            label7.Text = "Search:  ";
            // 
            // Repairs
            // 
            Repairs.Location = new Point(8, 46);
            Repairs.Margin = new Padding(6);
            Repairs.Name = "Repairs";
            Repairs.Size = new Size(1695, 1294);
            Repairs.TabIndex = 3;
            Repairs.Text = "Repairs";
            Repairs.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 1348);
            Controls.Add(MyProfile);
            Margin = new Padding(6);
            this.Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            MyProfile.ResumeLayout(false);
            My_Profile.ResumeLayout(false);
            My_Profile.PerformLayout();
            Shop.ResumeLayout(false);
            Shop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            My_Orders.ResumeLayout(false);
            My_Orders.PerformLayout();
            panelOrderDetails.ResumeLayout(false);
            panelOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MyProfile;
        private TabPage My_Profile;
        private TabPage Shop;
        private Button btnUpdate;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage My_Orders;
        private TabPage Repairs;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Price;
        private Button btnCart;
        private NumericUpDown Quantity;
        private Label label5;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn cartPrice;
        private DataGridViewTextBoxColumn SubTotal;
        private Button btnCheckout;
        private TextBox tbTotal;
        private Label label6;
        private DataGridView dgvOrders;
        private Label label8;
        private ComboBox cmdFilterStatus;
        private TextBox txtSearchOrders;
        private Label label7;
        private Panel panelOrderDetails;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn PaymentStatus;
        private DataGridViewButtonColumn Actions;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox tbId;
        private Label label14;
    }
}