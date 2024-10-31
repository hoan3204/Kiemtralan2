namespace Baikiemtralan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Product> productList = new List<Product>();
        private ShoppingCart shoppingCart = new ShoppingCart();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            SetupProductGridView();
            UpdateProductGridView();
            SetupCartGridView();
        }

        private void LoadProducts()
        {
            productList.Add(new Product("Sản phẩm 1", 100000, 10));
            productList.Add(new Product("Sản phẩm 2", 200000, 5));
            productList.Add(new Product("Sản phẩm 3", 150000, 8));
        }

        private void SetupProductGridView()
        {
            dgvProducts.ColumnCount = 3;
            dgvProducts.Columns[0].Name = "Tên Sản Phẩm";
            dgvProducts.Columns[1].Name = "Giá";
            dgvProducts.Columns[2].Name = "Số Lượng";
        }

        private void UpdateProductGridView()
        {
            dgvProducts.Rows.Clear();
            foreach (var product in productList)
            {
                dgvProducts.Rows.Add(product.Name, product.Price, product.Quantity);
            }
        }

        private void SetupCartGridView()
        {
            dgvCart.ColumnCount = 3;
            dgvCart.Columns[0].Name = "Tên Sản Phẩm";
            dgvCart.Columns[1].Name = "Số Lượng";
            dgvCart.Columns[2].Name = "Tổng Giá";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var row = dgvProducts.SelectedRows[0];
                string name = row.Cells[0].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells[1].Value);
                int stockQuantity = Convert.ToInt32(row.Cells[2].Value);

                var selectedProduct = productList.FirstOrDefault(p => p.Name == name);
                if (selectedProduct != null)
                {
                    int quantityToAdd = 1; // Thêm 1 sản phẩm
                    shoppingCart.AddToCart(selectedProduct, quantityToAdd);
                    UpdateCartGridView();
                }
            }
        }

        private void UpdateCartGridView()
        {
            dgvCart.Rows.Clear();
            foreach (var item in shoppingCart.Items)
            {
                dgvCart.Rows.Add(item.Product.Name, item.Quantity, item.TotalPrice);
            }

            lblTotalPrice.Text = $"Tổng giá: {shoppingCart.CalculateTotalPrice():C}";
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                var row = dgvCart.SelectedRows[0];
                string productName = row.Cells[0].Value.ToString();

                shoppingCart.RemoveFromCart(productName);
                UpdateCartGridView();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Đơn hàng đã thanh toán! Tổng giá trị: {shoppingCart.CalculateTotalPrice():C}", "Thông báo");

            shoppingCart.ClearCart();
            UpdateCartGridView();
        }

    }
}
