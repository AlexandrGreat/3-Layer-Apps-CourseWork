using CourseWork.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class CategoryForm : Form
    {
        DBConnect conn=new DBConnect();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private async void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/category";
                var client = new HttpClient();
                Category data = new Category();
                data.Name = textBox_Name.Text;
                data.Description = textBox_Description.Text;



                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(url, byteCon);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Category was added successfully!");
                    GetTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error" + response.StatusCode);
                    GetTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void GetTable() 
        {
            var url = "https://localhost:7104/Database/category";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<Category>>(json);
            dataGridView_Category.DataSource = res;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private async void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/category";
                var client = new HttpClient();
                Category data = new Category();
                data.Id = Convert.ToInt32(textBox_ID.Text);
                data.Name = textBox_Name.Text;
                data.Description = textBox_Description.Text;
                

                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = await client.PutAsync(url, byteCon);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Category was updated successfully!");
                    GetTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error" + response.StatusCode);
                    GetTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/category";
                var client = new HttpClient();
                Category data = new Category();
                data.Id = Convert.ToInt32(textBox_ID.Text);
                data.Name = textBox_Name.Text;
                data.Description = textBox_Description.Text;

                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var request = new HttpRequestMessage { Method = HttpMethod.Delete, RequestUri = new Uri(url), Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json") };
                var response = await client.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Category was deleted successfully!");
                    GetTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                    GetTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Category_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_ID.Text = dataGridView_Category.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Name.Text = dataGridView_Category.SelectedRows[0].Cells[1].Value.ToString();
                textBox_Description.Text = dataGridView_Category.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void ClearFields()
        {
            textBox_ID.Clear(); 
            textBox_Name.Clear(); 
            textBox_Description.Clear();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_Seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();    
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_EventLog_Click(object sender, EventArgs e)
        {
            EventLogForm logForm = new EventLogForm();
            logForm.Show();
            this.Hide();
        }
    }
}
