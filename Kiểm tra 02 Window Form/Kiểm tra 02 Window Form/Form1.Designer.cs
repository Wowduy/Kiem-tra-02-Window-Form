namespace Kiểm_tra_02_Window_Form
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(49, 370);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(131, 32);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.Text = "THÊM VÀO GIỎ HÀNG";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(225, 370);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(138, 32);
            this.btnRemoveFromCart.TabIndex = 2;
            this.btnRemoveFromCart.Text = "XÓA KHỎI GIỎ HÀNG";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Image,
            this.Name,
            this.Price,
            this.Quantity});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(49, 47);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(304, 317);
            this.listViewProducts.TabIndex = 4;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(406, 253);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(66, 13);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "TỔNG TIỀN";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(409, 283);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(138, 41);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "THANH TOÁN";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // Image
            // 
            this.Image.Text = "Hình Ảnh";
            // 
            // Name
            // 
            this.Name.Text = "Tên Sản Phẩm";
            // 
            // Price
            // 
            this.Price.Text = "Đơn Giá";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Số Lượng";
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Nam,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(388, 47);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(333, 176);
            this.listViewCart.TabIndex = 7;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HÌNH ẢNH";
            // 
            // Nam
            // 
            this.Nam.Text = "TÊN";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GIÁ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SỐ LG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
           
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader Image;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Nam;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

