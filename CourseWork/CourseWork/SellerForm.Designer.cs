namespace CourseWork
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.button_Category = new System.Windows.Forms.Button();
            this.dataGridView_Seller = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.button_Product = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Seller = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_EventLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seller)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Category
            // 
            this.button_Category.BackColor = System.Drawing.SystemColors.Window;
            this.button_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Category.Location = new System.Drawing.Point(12, 252);
            this.button_Category.Name = "button_Category";
            this.button_Category.Size = new System.Drawing.Size(119, 74);
            this.button_Category.TabIndex = 26;
            this.button_Category.Text = "Category";
            this.button_Category.UseVisualStyleBackColor = false;
            this.button_Category.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // dataGridView_Seller
            // 
            this.dataGridView_Seller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Seller.Location = new System.Drawing.Point(357, 47);
            this.dataGridView_Seller.MultiSelect = false;
            this.dataGridView_Seller.Name = "dataGridView_Seller";
            this.dataGridView_Seller.RowHeadersWidth = 51;
            this.dataGridView_Seller.RowTemplate.Height = 24;
            this.dataGridView_Seller.Size = new System.Drawing.Size(491, 462);
            this.dataGridView_Seller.TabIndex = 18;
            this.dataGridView_Seller.Click += new System.EventHandler(this.dataGridView_Category_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(238, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "MANAGE SELLERS\r\n";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.button_Delete.Location = new System.Drawing.Point(244, 196);
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
            this.button_Update.Location = new System.Drawing.Point(127, 196);
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
            this.button_Add.Location = new System.Drawing.Point(14, 196);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(107, 30);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(154, 109);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(197, 22);
            this.textBox_Age.TabIndex = 7;
            // 
            // button_Product
            // 
            this.button_Product.BackColor = System.Drawing.SystemColors.Window;
            this.button_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Product.Location = new System.Drawing.Point(12, 172);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(119, 74);
            this.button_Product.TabIndex = 23;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = false;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox_Password);
            this.panel1.Controls.Add(this.textBox_Phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView_Seller);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.textBox_Age);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(137, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 543);
            this.panel1.TabIndex = 20;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(154, 168);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(197, 22);
            this.textBox_Password.TabIndex = 26;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(154, 137);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(197, 22);
            this.textBox_Phone.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phone";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
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
            this.button_Seller.TabIndex = 22;
            this.button_Seller.Text = "Seller";
            this.button_Seller.UseVisualStyleBackColor = false;
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.Window;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Logout.Location = new System.Drawing.Point(12, 514);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(119, 74);
            this.button_Logout.TabIndex = 25;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_EventLog
            // 
            this.button_EventLog.BackColor = System.Drawing.SystemColors.Window;
            this.button_EventLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EventLog.Location = new System.Drawing.Point(12, 332);
            this.button_EventLog.Name = "button_EventLog";
            this.button_EventLog.Size = new System.Drawing.Size(119, 74);
            this.button_EventLog.TabIndex = 27;
            this.button_EventLog.Text = "Event Log";
            this.button_EventLog.UseVisualStyleBackColor = false;
            this.button_EventLog.Click += new System.EventHandler(this.button_EventLog_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button_EventLog);
            this.Controls.Add(this.button_Category);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Seller);
            this.Controls.Add(this.button_Logout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellerForm_FormClosing);
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seller)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Category;
        private System.Windows.Forms.DataGridView dataGridView_Seller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Seller;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_EventLog;
    }
}