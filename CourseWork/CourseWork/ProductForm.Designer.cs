namespace CourseWork
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_Provider = new System.Windows.Forms.ComboBox();
            this.label_Provider = new System.Windows.Forms.Label();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Discount = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Seller = new System.Windows.Forms.Button();
            this.button_Category = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_Product = new System.Windows.Forms.Button();
            this.button_EventLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBox_Provider);
            this.panel1.Controls.Add(this.label_Provider);
            this.panel1.Controls.Add(this.dataGridView_Product);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.comboBox_Categories);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.comboBox_Category);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_Discount);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.textBox_Description);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(137, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 543);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_Provider
            // 
            this.comboBox_Provider.FormattingEnabled = true;
            this.comboBox_Provider.Location = new System.Drawing.Point(154, 236);
            this.comboBox_Provider.Name = "comboBox_Provider";
            this.comboBox_Provider.Size = new System.Drawing.Size(197, 24);
            this.comboBox_Provider.TabIndex = 20;
            // 
            // label_Provider
            // 
            this.label_Provider.AutoSize = true;
            this.label_Provider.Location = new System.Drawing.Point(20, 239);
            this.label_Provider.Name = "label_Provider";
            this.label_Provider.Size = new System.Drawing.Size(58, 16);
            this.label_Provider.TabIndex = 19;
            this.label_Provider.Text = "Provider";
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(357, 78);
            this.dataGridView_Product.MultiSelect = false;
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.RowHeadersWidth = 51;
            this.dataGridView_Product.RowTemplate.Height = 24;
            this.dataGridView_Product.Size = new System.Drawing.Size(491, 462);
            this.dataGridView_Product.TabIndex = 18;
            this.dataGridView_Product.Click += new System.EventHandler(this.dataGridView_Product_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(238, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "MANAGE PRODUCTS";
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.SystemColors.Window;
            this.button_Refresh.Location = new System.Drawing.Point(621, 44);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(79, 24);
            this.button_Refresh.TabIndex = 16;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(418, 44);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(197, 24);
            this.comboBox_Categories.TabIndex = 15;
            this.comboBox_Categories.Text = "-select category-";
            this.comboBox_Categories.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Categories_SelectionChangeCommitted);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.button_Delete.Location = new System.Drawing.Point(244, 279);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(107, 30);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.Window;
            this.button_Update.Location = new System.Drawing.Point(127, 279);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(107, 30);
            this.button_Update.TabIndex = 13;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.Window;
            this.button_Add.Location = new System.Drawing.Point(14, 279);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(107, 30);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(154, 200);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(197, 24);
            this.comboBox_Category.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category";
            // 
            // textBox_Discount
            // 
            this.textBox_Discount.Location = new System.Drawing.Point(154, 166);
            this.textBox_Discount.Name = "textBox_Discount";
            this.textBox_Discount.Size = new System.Drawing.Size(197, 22);
            this.textBox_Discount.TabIndex = 9;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(154, 138);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(197, 22);
            this.textBox_Price.TabIndex = 8;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(154, 109);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(197, 22);
            this.textBox_Description.TabIndex = 7;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(154, 78);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(197, 22);
            this.textBox_Name.TabIndex = 6;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(154, 47);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(197, 22);
            this.textBox_ID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // button_Seller
            // 
            this.button_Seller.BackColor = System.Drawing.SystemColors.Window;
            this.button_Seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Seller.Location = new System.Drawing.Point(12, 92);
            this.button_Seller.Name = "button_Seller";
            this.button_Seller.Size = new System.Drawing.Size(119, 74);
            this.button_Seller.TabIndex = 9;
            this.button_Seller.Text = "Seller";
            this.button_Seller.UseVisualStyleBackColor = false;
            this.button_Seller.Click += new System.EventHandler(this.button_Seller_Click);
            // 
            // button_Category
            // 
            this.button_Category.BackColor = System.Drawing.SystemColors.Window;
            this.button_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Category.Location = new System.Drawing.Point(12, 252);
            this.button_Category.Name = "button_Category";
            this.button_Category.Size = new System.Drawing.Size(119, 74);
            this.button_Category.TabIndex = 10;
            this.button_Category.Text = "Category";
            this.button_Category.UseVisualStyleBackColor = false;
            this.button_Category.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.Window;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Logout.Location = new System.Drawing.Point(12, 514);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(119, 74);
            this.button_Logout.TabIndex = 12;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_Product
            // 
            this.button_Product.BackColor = System.Drawing.SystemColors.Window;
            this.button_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Product.Location = new System.Drawing.Point(12, 172);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(119, 74);
            this.button_Product.TabIndex = 13;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = false;
            // 
            // button_EventLog
            // 
            this.button_EventLog.BackColor = System.Drawing.SystemColors.Window;
            this.button_EventLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EventLog.Location = new System.Drawing.Point(12, 332);
            this.button_EventLog.Name = "button_EventLog";
            this.button_EventLog.Size = new System.Drawing.Size(119, 74);
            this.button_EventLog.TabIndex = 21;
            this.button_EventLog.Text = "Event Log";
            this.button_EventLog.UseVisualStyleBackColor = false;
            this.button_EventLog.Click += new System.EventHandler(this.button_EventLog_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button_EventLog);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_Category);
            this.Controls.Add(this.button_Seller);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Discount;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.Button button_Seller;
        private System.Windows.Forms.Button button_Category;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.ComboBox comboBox_Provider;
        private System.Windows.Forms.Label label_Provider;
        private System.Windows.Forms.Button button_EventLog;
    }
}