namespace WinFormsApp1
{
    partial class EmployeeForm
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
            btnViewProducts = new Button();
            btnNewOrder = new Button();
            btnLogout = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(638, 59);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(221, 75);
            btnViewProducts.TabIndex = 4;
            btnViewProducts.Text = "ViewProducts";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(638, 187);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(221, 75);
            btnNewOrder.TabIndex = 5;
            btnNewOrder.Text = "ViewOrders";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(638, 330);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(221, 75);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.GridColor = SystemColors.HighlightText;
            dgvProducts.Location = new Point(319, 448);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.Size = new Size(1176, 539);
            dgvProducts.TabIndex = 7;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1809, 1020);
            Controls.Add(dgvProducts);
            Controls.Add(btnLogout);
            Controls.Add(btnNewOrder);
            Controls.Add(btnViewProducts);
            Margin = new Padding(6);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnViewProducts;
        private Button btnNewOrder;
        private Button btnLogout;
        private DataGridView dgvProducts;
    }
}