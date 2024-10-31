using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiểm_tra_02_Window_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public Image Image { get; set; }

            public Product(string name, decimal price, int quantity, Image image)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Image = image;
            }
        }
        public class ShoppingCart
        {
            public List<Product> Items { get; private set; } = new List<Product>();

            public void AddProduct(Product product)
            {
                Items.Add(product);
            }

            public void RemoveProduct(Product product)
            {
                Items.Remove(product);
            }

            public decimal CalculateTotal()
            {
                return Items.Sum(item => item.Price * item.Quantity);
            }

            public void ClearCart()
            {
                Items.Clear();
            }
        }
        private ShoppingCart cart = new ShoppingCart();
        private List<Product> products = new List<Product>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách sản phẩm ví dụ
            products.Add(new Product("Sản phẩm A", 100, 1, Properties.Resources.imageA));
            products.Add(new Product("Sản phẩm B", 200, 1, Properties.Resources.imageB));

            // Hiển thị sản phẩm lên ListView
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem();
                item.Text = product.Name;
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());
                item.Tag = product; // Lưu trữ đối tượng Product trong Tag để sử dụng sau

                // Thêm vào ListView
                listViewProducts.Items.Add(item);
            }
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                var selectedProduct = (Product)listViewProducts.SelectedItems[0].Tag;
                cart.AddProduct(selectedProduct);
                UpdateCart();
            }
        }
        private void UpdateCart()
        {
            listViewCart.Items.Clear();
            foreach (var item in cart.Items)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.Tag = item;

                listViewCart.Items.Add(listViewItem);
            }

            lblTotalPrice.Text = "Tổng giá trị: " + cart.CalculateTotal().ToString("C");
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đơn hàng của bạn đã được xác nhận!");
            cart.ClearCart();
            UpdateCart();
        }


    }
}
