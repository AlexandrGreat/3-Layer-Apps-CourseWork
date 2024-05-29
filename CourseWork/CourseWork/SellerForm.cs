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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CourseWork
{
    public partial class SellerForm : Form
    {
        DBConnect conn = new DBConnect();

        public SellerForm()
        {
            InitializeComponent();
        }

        private async void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/seller";
                var client = new HttpClient();
                Seller data = new Seller();
                data.Name = textBox_Name.Text;
                data.Age = Convert.ToInt32(textBox_Age.Text);
                data.Phone = textBox_Phone.Text;
                data.Password = textBox_Password.Text;



                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(url, byteCon);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Seller was added successfully!");
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

        private async void GetTable()
        {
            var url = "https://localhost:7104/Database/seller";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<Seller>>(json);
            dataGridView_Seller.DataSource = res;
        }

        private void ClearFields()
        {
            textBox_ID.Clear();
            textBox_Name.Clear();
            textBox_Age.Clear();
            textBox_Phone.Clear();
            textBox_Password.Clear();
        }

        private async void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/seller";
                var client = new HttpClient();
                Seller data = new Seller();
                data.ID = Convert.ToInt32(textBox_ID.Text);
                data.Name = textBox_Name.Text;
                data.Age = Convert.ToInt32(textBox_Age.Text);
                data.Phone = textBox_Phone.Text;
                data.Password = textBox_Password.Text;


                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = await client.PutAsync(url, byteCon);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Seller was updated successfully!");
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
                var url = "https://localhost:7104/Database/seller";
                var client = new HttpClient();
                Seller data = new Seller();
                data.ID = Convert.ToInt32(textBox_ID.Text);
                data.Name = textBox_Name.Text;
                data.Age = Convert.ToInt32(textBox_Age.Text);
                data.Phone = textBox_Phone.Text;
                data.Password = textBox_Password.Text;

                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var request = new HttpRequestMessage { Method = HttpMethod.Delete, RequestUri = new Uri(url), Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json") };
                var response = await client.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Seller was deleted successfully!");
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
                textBox_ID.Text = dataGridView_Seller.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Name.Text = dataGridView_Seller.SelectedRows[0].Cells[1].Value.ToString();
                textBox_Age.Text = dataGridView_Seller.SelectedRows[0].Cells[2].Value.ToString();
                textBox_Phone.Text = dataGridView_Seller.SelectedRows[0].Cells[3].Value.ToString();
                textBox_Password.Text = dataGridView_Seller.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }
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

        private void button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void SellerForm_FormClosing(object sender, FormClosingEventArgs e)
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
