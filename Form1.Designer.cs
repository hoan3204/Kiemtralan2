namespace Baikiemtralan2
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
            dgvProducts = new DataGridView();
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            btnCheckout = new Button();
            lblTotalPrice = new Label();
            dgvCart = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(121, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(834, 306);
            dgvProducts.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(12, 46);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 29);
            btnAddToCart.TabIndex = 1;
            btnAddToCart.Text = "Thêm";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(12, 104);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(94, 29);
            btnRemoveFromCart.TabIndex = 2;
            btnRemoveFromCart.Text = "Xóa";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(12, 168);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Thanh toán";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(36, 411);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(50, 20);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Tổng :";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(401, 353);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(554, 188);
            dgvCart.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 553);
            Controls.Add(dgvCart);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnCheckout;
        private Label lblTotalPrice;
        private DataGridView dgvCart;
    }
}
