namespace WinDisconArchDemo
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
            this.lbl_prodId = new System.Windows.Forms.Label();
            this.txt_ProdID = new System.Windows.Forms.TextBox();
            this.txt_ProdName = new System.Windows.Forms.TextBox();
            this.lbl_prodName = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_ShowProducts = new System.Windows.Forms.Button();
            this.btn_SearchProducts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_prodId
            // 
            this.lbl_prodId.AutoSize = true;
            this.lbl_prodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodId.Location = new System.Drawing.Point(44, 39);
            this.lbl_prodId.Name = "lbl_prodId";
            this.lbl_prodId.Size = new System.Drawing.Size(65, 22);
            this.lbl_prodId.TabIndex = 0;
            this.lbl_prodId.Text = "ProdID";
            // 
            // txt_ProdID
            // 
            this.txt_ProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdID.Location = new System.Drawing.Point(47, 59);
            this.txt_ProdID.Name = "txt_ProdID";
            this.txt_ProdID.Size = new System.Drawing.Size(100, 28);
            this.txt_ProdID.TabIndex = 1;
            // 
            // txt_ProdName
            // 
            this.txt_ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProdName.Location = new System.Drawing.Point(47, 126);
            this.txt_ProdName.Name = "txt_ProdName";
            this.txt_ProdName.Size = new System.Drawing.Size(100, 28);
            this.txt_ProdName.TabIndex = 3;
            // 
            // lbl_prodName
            // 
            this.lbl_prodName.AutoSize = true;
            this.lbl_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodName.Location = new System.Drawing.Point(44, 106);
            this.lbl_prodName.Name = "lbl_prodName";
            this.lbl_prodName.Size = new System.Drawing.Size(95, 22);
            this.lbl_prodName.TabIndex = 2;
            this.lbl_prodName.Text = "ProdName";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(47, 192);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 28);
            this.txt_Price.TabIndex = 5;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(44, 172);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(51, 22);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desc.Location = new System.Drawing.Point(47, 255);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(258, 60);
            this.txt_Desc.TabIndex = 7;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(44, 235);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(100, 22);
            this.lbl_desc.TabIndex = 6;
            this.lbl_desc.Text = "Description";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.Location = new System.Drawing.Point(47, 339);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(83, 31);
            this.btn_AddProduct.TabIndex = 8;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateProduct.Location = new System.Drawing.Point(159, 339);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(82, 31);
            this.btn_UpdateProduct.TabIndex = 9;
            this.btn_UpdateProduct.Text = "Update";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteProduct.Location = new System.Drawing.Point(282, 339);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(83, 31);
            this.btn_DeleteProduct.TabIndex = 10;
            this.btn_DeleteProduct.Text = "Delete";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btn_ShowProducts
            // 
            this.btn_ShowProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowProducts.Location = new System.Drawing.Point(405, 339);
            this.btn_ShowProducts.Name = "btn_ShowProducts";
            this.btn_ShowProducts.Size = new System.Drawing.Size(87, 31);
            this.btn_ShowProducts.TabIndex = 11;
            this.btn_ShowProducts.Text = "Show";
            this.btn_ShowProducts.UseVisualStyleBackColor = true;
            // 
            // btn_SearchProducts
            // 
            this.btn_SearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchProducts.Location = new System.Drawing.Point(522, 339);
            this.btn_SearchProducts.Name = "btn_SearchProducts";
            this.btn_SearchProducts.Size = new System.Drawing.Size(89, 31);
            this.btn_SearchProducts.TabIndex = 12;
            this.btn_SearchProducts.Text = "Search";
            this.btn_SearchProducts.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 276);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SearchProducts);
            this.Controls.Add(this.btn_ShowProducts);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_ProdName);
            this.Controls.Add(this.lbl_prodName);
            this.Controls.Add(this.txt_ProdID);
            this.Controls.Add(this.lbl_prodId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prodId;
        private System.Windows.Forms.TextBox txt_ProdID;
        private System.Windows.Forms.TextBox txt_ProdName;
        private System.Windows.Forms.Label lbl_prodName;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_ShowProducts;
        private System.Windows.Forms.Button btn_SearchProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

