using CourseWork.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
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
    public partial class EventLogForm : Form
    {
        DBConnect conn = new DBConnect();

        public EventLogForm()
        {
            InitializeComponent();
        }

        private async void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/eventlog";
                var client = new HttpClient();
                EventLog data = new EventLog();
                data.ID = Convert.ToInt32(textBox_ID.Text);
                data.EventTable = "";
                data.EventType = "";
                data.DateTime = "";
                data.Rows = 0;

                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var request = new HttpRequestMessage { Method = HttpMethod.Delete, RequestUri = new Uri(url), Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json") };
                var response = await client.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Event was deleted successfully!");
                    GetTable();
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

        private async void GetTable()
        {
            var url = "https://localhost:7104/Database/eventlog";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<EventLog>>(json);
            dataGridView_EventLog.DataSource = res;
        }

        private void dataGridView_EventLog_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_ID.Text = dataGridView_EventLog.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            GetTable();
        }

        private async void button_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:7104/Database/eventlogall";
                var client = new HttpClient();
                var response = await client.DeleteAsync(url);
                var json = await response.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<List<EventLog>>(json);
                dataGridView_EventLog.DataSource = res;
            }
            catch { }
        }

        private void button_Seller_Click(object sender, EventArgs e)
        {
            SellerForm seller=new SellerForm();
            seller.Show();
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

        private void EventLogForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void EventLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void comboBox_Tables_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string tabName = comboBox_Tables.SelectedItem.ToString();
            var url = "https://localhost:7104/Database/eventlogtable";
            var client = new HttpClient();
            StringModel tab = new StringModel();
            tab.Value =comboBox_Tables.SelectedItem.ToString();
            var content = JsonConvert.SerializeObject(tab);
            var buff = System.Text.Encoding.UTF8.GetBytes(content);
            var byteCon = new ByteArrayContent(buff);
            byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await client.PostAsync(url, byteCon);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<EventLog>>(json);
            dataGridView_EventLog.DataSource = res;
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            LoginForm login=new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
