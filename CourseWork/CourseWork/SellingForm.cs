using CourseWork.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SellingForm : Form
    {
        DBConnect conn = new DBConnect();

        public SellingForm()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void GetCategory()
        {
            var url = "https://localhost:7104/Database/category";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<Category>>(json);
            comboBox_Category.DataSource = res;
            comboBox_Category.ValueMember = "Name";
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_seller.Text = LoginForm.seller;
            label_date.Text = DateTime.Now.ToString();
            GetCategory();
            GetTable();
            GetBillLogTable();
        }

        private async void GetTable()
        {
            var url = "https://localhost:7104/Database/productviewmin";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<ProductMin>>(json);
            dataGridView_Product.DataSource = res;
        }

        private async void GetBillLogTable()
        {
            var url = "https://localhost:7104/Database/billlog";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<BillLogView>>(json);
            dataGridView_bills.DataSource = res;
        }

        private void dataGridView_Product1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Name.Text = dataGridView_Product.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Price.Text = dataGridView_Product.SelectedRows[0].Cells[1].Value.ToString();
                textBox_Discount.Text = dataGridView_Product.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch { }
        }

        float sum = 0;
        int n = 0;

        private async void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/billlog";
                var client = new HttpClient();
                BillLog data = new BillLog();
                data.ID = Convert.ToInt32(textBox_ID.Text);
                data.Seller = LoginForm.sellerID;
                data.Date = label_date.Text;
                data.Total = sum.ToString();

            var content = JsonConvert.SerializeObject(data);
            var buff = System.Text.Encoding.UTF8.GetBytes(content);
            var byteCon = new ByteArrayContent(buff);
            byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(url, byteCon);

            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json);
            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Order was added successfully!");
                GetTable();
                GetBillLogTable();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
                GetTable();
            }
            }
            catch { }
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            string fileName = $"SellList_{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}_{DateTime.Now.Hour}-{DateTime.Now.Minute}.txt";
            using (StreamWriter writeLog = new StreamWriter(fileName))
            {
                writeLog.WriteLine("My Little Friend Sellings");
                writeLog.WriteLine($"\nLogged: {DateTime.Now.ToString()}\n");
                writeLog.WriteLine("\nID Seller Date Total");
                for (int i = 0; i < dataGridView_bills.RowCount-1; i++)
                {
                    writeLog.Write(dataGridView_bills.Rows[i].Cells[0].Value.ToString() + " ");
                    writeLog.Write(dataGridView_bills.Rows[i].Cells[1].Value.ToString() + " ");
                    writeLog.Write(dataGridView_bills.Rows[i].Cells[2].Value.ToString() + " ");
                    writeLog.Write(dataGridView_bills.Rows[i].Cells[3].Value.ToString() + "\n");
                }
            }
            MessageBox.Show("Log file printed!");
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private async void comboBox_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int catID = 0;
            var url2 = "https://localhost:7104/Database/catid";
            var client2 = new HttpClient();
            StringModel cat = new StringModel();
            cat.Value = comboBox_Category.SelectedValue.ToString();
            var content2 = JsonConvert.SerializeObject(cat);
            var buff2 = System.Text.Encoding.UTF8.GetBytes(content2);
            var byteCon2 = new ByteArrayContent(buff2);
            byteCon2.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response2 = await client2.PostAsync(url2, byteCon2);
            var json2 = await response2.Content.ReadAsStringAsync();
            cat = JsonConvert.DeserializeObject<StringModel>(json2);
            catID = Convert.ToInt32(cat.Value);
            if (catID == 0)
            {
                MessageBox.Show("Wrong category");
            }

            StringModel cat2 = new StringModel();
            cat2.Value = catID.ToString();
            content2 = JsonConvert.SerializeObject(cat2);
            buff2 = System.Text.Encoding.UTF8.GetBytes(content2);
            byteCon2 = new ByteArrayContent(buff2);
            byteCon2.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var url = "https://localhost:7104/Database/productidmin";
            var client = new HttpClient();
            var response = await client.PostAsync(url, byteCon2);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<ProductMin>>(json);
            dataGridView_Product.DataSource = res;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetTable();
        }

        private async void button_Delete_Click(object sender, EventArgs e)
        {
            var url = "https://localhost:7104/Database/billlog";
            var client = new HttpClient();
            BillLog data = new BillLog();
            data.ID = Convert.ToInt32(textBox_ID.Text);
            data.Seller = LoginForm.sellerID;
            data.Date = label_date.Text;
            data.Total = sum.ToString();

            var content = JsonConvert.SerializeObject(data);
            var buff = System.Text.Encoding.UTF8.GetBytes(content);
            var byteCon = new ByteArrayContent(buff);
            byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var request = new HttpRequestMessage { Method = HttpMethod.Delete, RequestUri = new Uri(url), Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json") };
            var response = await client.SendAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Order was deleted successfully!");
                GetTable();
                GetBillLogTable();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
                GetTable();
            }
        }

        private void SellingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_Quantity.Text == "")
            {
                MessageBox.Show("Please input all fields");
            }
            else
            {
                try
                {
                    double total = (Convert.ToInt32(textBox_Price.Text) * Convert.ToInt32(textBox_Quantity.Text)) / 100.0 * (100 - Convert.ToInt32(textBox_Discount.Text));
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView_Order);
                    newRow.Cells[0].Value = ++n;
                    newRow.Cells[1].Value = textBox_Name.Text;
                    newRow.Cells[2].Value = textBox_Price.Text;
                    newRow.Cells[3].Value = textBox_Quantity.Text;
                    newRow.Cells[4].Value = total;
                    dataGridView_Order.Rows.Add(newRow);
                    sum += (float)total;
                    label_Amount.Text = "Amount: " + sum + "$";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
