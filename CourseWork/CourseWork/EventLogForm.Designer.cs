namespace CourseWork
{
    partial class EventLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventLogForm));
            this.button_Product = new System.Windows.Forms.Button();
            this.dataGridView_EventLog = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.comboBox_Tables = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Category = new System.Windows.Forms.Button();
            this.button_Seller = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_EventLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EventLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Product
            // 
            this.button_Product.BackColor = System.Drawing.SystemColors.Window;
            this.button_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Product.Location = new System.Drawing.Point(12, 171);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(119, 74);
            this.button_Product.TabIndex = 18;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = false;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // dataGridView_EventLog
            // 
            this.dataGridView_EventLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_EventLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EventLog.Location = new System.Drawing.Point(3, 78);
            this.dataGridView_EventLog.MultiSelect = false;
            this.dataGridView_EventLog.Name = "dataGridView_EventLog";
            this.dataGridView_EventLog.RowHeadersWidth = 51;
            this.dataGridView_EventLog.RowTemplate.Height = 24;
            this.dataGridView_EventLog.Size = new System.Drawing.Size(845, 462);
            this.dataGridView_EventLog.TabIndex = 18;
            this.dataGridView_EventLog.Click += new System.EventHandler(this.dataGridView_EventLog_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(294, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "RECENT EVENTS";
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.SystemColors.Window;
            this.button_Refresh.Location = new System.Drawing.Point(745, 43);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(79, 24);
            this.button_Refresh.TabIndex = 16;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // comboBox_Tables
            // 
            this.comboBox_Tables.FormattingEnabled = true;
            this.comboBox_Tables.Items.AddRange(new object[] {
            "BillLog",
            "Product",
            "Seller",
            "Category",
            "Provider"});
            this.comboBox_Tables.Location = new System.Drawing.Point(542, 43);
            this.comboBox_Tables.Name = "comboBox_Tables";
            this.comboBox_Tables.Size = new System.Drawing.Size(197, 24);
            this.comboBox_Tables.TabIndex = 15;
            this.comboBox_Tables.Text = "-select table-";
            this.comboBox_Tables.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Tables_SelectionChangeCommitted);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.button_Delete.Location = new System.Drawing.Point(249, 42);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(107, 30);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Category
            // 
            this.button_Category.BackColor = System.Drawing.SystemColors.Window;
            this.button_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Category.Location = new System.Drawing.Point(12, 251);
            this.button_Category.Name = "button_Category";
            this.button_Category.Size = new System.Drawing.Size(119, 74);
            this.button_Category.TabIndex = 16;
            this.button_Category.Text = "Category";
            this.button_Category.UseVisualStyleBackColor = false;
            this.button_Category.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // button_Seller
            // 
            this.button_Seller.BackColor = System.Drawing.SystemColors.Window;
            this.button_Seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Seller.Location = new System.Drawing.Point(12, 91);
            this.button_Seller.Name = "button_Seller";
            this.button_Seller.Size = new System.Drawing.Size(119, 74);
            this.button_Seller.TabIndex = 15;
            this.button_Seller.Text = "Seller";
            this.button_Seller.UseVisualStyleBackColor = false;
            this.button_Seller.Click += new System.EventHandler(this.button_Seller_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(46, 45);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(197, 22);
            this.textBox_ID.TabIndex = 5;
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
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.Window;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Logout.Location = new System.Drawing.Point(12, 514);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(119, 74);
            this.button_Logout.TabIndex = 17;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_Clear);
            this.panel1.Controls.Add(this.dataGridView_EventLog);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_Refresh);
            this.panel1.Controls.Add(this.comboBox_Tables);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(137, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 543);
            this.panel1.TabIndex = 14;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.Window;
            this.button_Clear.Location = new System.Drawing.Point(362, 42);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(107, 30);
            this.button_Clear.TabIndex = 19;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_EventLog
            // 
            this.button_EventLog.BackColor = System.Drawing.SystemColors.Window;
            this.button_EventLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EventLog.Location = new System.Drawing.Point(12, 331);
            this.button_EventLog.Name = "button_EventLog";
            this.button_EventLog.Size = new System.Drawing.Size(119, 74);
            this.button_EventLog.TabIndex = 19;
            this.button_EventLog.Text = "Event Log";
            this.button_EventLog.UseVisualStyleBackColor = false;
            // 
            // EventLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button_EventLog);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.button_Category);
            this.Controls.Add(this.button_Seller);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventLogForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventLogForm_FormClosing);
            this.Load += new System.EventHandler(this.EventLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EventLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.DataGridView dataGridView_EventLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ComboBox comboBox_Tables;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Category;
        private System.Windows.Forms.Button button_Seller;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_EventLog;
    }
}