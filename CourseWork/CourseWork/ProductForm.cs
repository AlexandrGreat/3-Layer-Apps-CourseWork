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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ProductForm : Form
    {
        DBConnect conn = new DBConnect();

        public ProductForm()
        {
            InitializeComponent();
        }

        private async void button_Add_Click(object sender, EventArgs e)
        {
            //GET CATEGORY AND PROVIDER ID
            int catID=0,provID=0;
            var url1 = "https://localhost:7104/Database/provid";
            var url2 = "https://localhost:7104/Database/catid";
            var client1 = new HttpClient();
            var client2 = new HttpClient();
            StringModel cat = new StringModel();
            StringModel prov = new StringModel();
            cat.Value=comboBox_Category.Text;
            prov.Value = comboBox_Provider.Text;
            var content1 = JsonConvert.SerializeObject(prov);
            var buff1 = System.Text.Encoding.UTF8.GetBytes(content1);
            var byteCon1 = new ByteArrayContent(buff1);
            byteCon1.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response1 = await client1.PostAsync(url1, byteCon1);
            var content2 = JsonConvert.SerializeObject(cat);
            var buff2 = System.Text.Encoding.UTF8.GetBytes(content2);
            var byteCon2 = new ByteArrayContent(buff2);
            byteCon2.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response2 = await client2.PostAsync(url2, byteCon2);
            var json1 = await response1.Content.ReadAsStringAsync();
            var json2 = await response2.Content.ReadAsStringAsync();
            prov = JsonConvert.DeserializeObject<StringModel>(json1);
            cat = JsonConvert.DeserializeObject<StringModel>(json2);
            provID = Convert.ToInt32(prov.Value);
            catID = Convert.ToInt32(cat.Value);
            if (catID == 0)
            {
                MessageBox.Show("Wrong category");
            }
            if (provID == 0)
            {
                MessageBox.Show("Wrong provider");
            }

            try
            {
                var url = "https://localhost:7104/Database/product";
                var client = new HttpClient();
                Product data = new Product();
                data.Name = textBox_Name.Text;
                data.Description = textBox_Description.Text;
                data.Price = Convert.ToInt32(textBox_Price.Text);
                data.DiscountPercentage = Convert.ToInt32(textBox_Discount.Text);
                data.Category = catID;
                data.Provider = provID;



                var content=JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType=new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(url, byteCon);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Product was added successfully!");
                    GetTable();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error"+response.StatusCode);
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

        private void button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm category=new CategoryForm();
            category.Show();
            this.Hide();
        }

        private async void GetTable()
        {
            var url = "https://localhost:7104/Database/productview";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res=JsonConvert.DeserializeObject<List<ProductView>>(json);
            dataGridView_Product.DataSource = res;
        }

        private void ClearFields()
        {
            textBox_ID.Clear();
            textBox_Name.Clear();
            textBox_Description.Clear();
            textBox_Price.Clear();
            textBox_Discount.Clear();
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
            comboBox_Categories.DataSource = res;
            comboBox_Categories.ValueMember = "Name";
        }

        private async void GetProvider()
        {
            var url = "https://localhost:7104/Database/provider";
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<Provider>>(json);
            comboBox_Provider.DataSource = res;
            comboBox_Provider.ValueMember = "Name";
        }

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            GetCategory();
            GetProvider();
            GetTable();
        }

        private async void button_Update_Click(object sender, EventArgs e)
        {
            //GET CATEGORY AND PROVIDER ID
            int catID = 0, provID = 0;
            var url1 = "https://localhost:7104/Database/provid";
            var url2 = "https://localhost:7104/Database/catid";
            var client1 = new HttpClient();
            var client2 = new HttpClient();
            StringModel cat = new StringModel();
            StringModel prov = new StringModel();
            cat.Value = comboBox_Category.Text;
            prov.Value = comboBox_Provider.Text;
            var content1 = JsonConvert.SerializeObject(prov);
            var buff1 = System.Text.Encoding.UTF8.GetBytes(content1);
            var byteCon1 = new ByteArrayContent(buff1);
            byteCon1.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response1 = await client1.PostAsync(url1, byteCon1);
            var content2 = JsonConvert.SerializeObject(cat);
            var buff2 = System.Text.Encoding.UTF8.GetBytes(content2);
            var byteCon2 = new ByteArrayContent(buff2);
            byteCon2.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response2 = await client2.PostAsync(url2, byteCon2);
            var json1 = await response1.Content.ReadAsStringAsync();
            var json2 = await response2.Content.ReadAsStringAsync();
            prov = JsonConvert.DeserializeObject<StringModel>(json1);
            cat = JsonConvert.DeserializeObject<StringModel>(json2);
            provID = Convert.ToInt32(prov.Value);
            catID = Convert.ToInt32(cat.Value);
            if (catID == 0)
            {
                MessageBox.Show("Wrong category");
            }
            if (provID == 0)
            {
                MessageBox.Show("Wrong provider");
            }

            try
            {
                var url = "https://localhost:7104/Database/product";
                var client = new HttpClient();
                Product data = new Product();
                data.ID = Convert.ToInt32(textBox_ID.Text);
                data.Name = textBox_Name.Text;
                data.Description = textBox_Description.Text;
                data.Price = Convert.ToInt32(textBox_Price.Text);
                data.DiscountPercentage = Convert.ToInt32(textBox_Discount.Text);
                data.Category = catID;
                data.Provider = provID;


                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = await client.PutAsync(url, byteCon);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Product was updated successfully!");
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
                var url = "https://localhost:7104/Database/product";
                var client = new HttpClient();
                Product data = new Product();
                data.ID = Convert.ToInt32(textBox_ID.Text);
                data.Name = textBox_Name.Text;
                data.Description = textBox_Description.Text;
                data.Price = Convert.ToInt32(textBox_Price.Text);
                data.DiscountPercentage = Convert.ToInt32(textBox_Discount.Text);
                data.Category = 0;
                data.Provider = 0;

                var content = JsonConvert.SerializeObject(data);
                var buff = System.Text.Encoding.UTF8.GetBytes(content);
                var byteCon = new ByteArrayContent(buff);
                byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                
                var request=new HttpRequestMessage { Method=HttpMethod.Delete, RequestUri=new Uri(url), Content=new StringContent(JsonConvert.SerializeObject(data),Encoding.UTF8,"application/json") };
                var response=await client.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Product was deleted successfully!");
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

        private void button_Logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void dataGridView_Product_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_ID.Text = dataGridView_Product.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Name.Text = dataGridView_Product.SelectedRows[0].Cells[1].Value.ToString();
                textBox_Description.Text = dataGridView_Product.SelectedRows[0].Cells[2].Value.ToString();
                textBox_Price.Text = dataGridView_Product.SelectedRows[0].Cells[3].Value.ToString();
                textBox_Discount.Text = dataGridView_Product.SelectedRows[0].Cells[4].Value.ToString();
                comboBox_Category.SelectedValue = dataGridView_Product.SelectedRows[0].Cells[5].Value.ToString();
                comboBox_Provider.SelectedValue = dataGridView_Product.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch { }
        }

        private async void comboBox_Categories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int catID = 0;
            var url2 = "https://localhost:7104/Database/catid";
            var client2 = new HttpClient();
            StringModel cat = new StringModel();
            cat.Value = comboBox_Categories.SelectedValue.ToString();
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

            StringModel cat2=new StringModel();
            cat2.Value = catID.ToString();
            content2 = JsonConvert.SerializeObject(cat2);
            buff2 = System.Text.Encoding.UTF8.GetBytes(content2);
            byteCon2 = new ByteArrayContent(buff2);
            byteCon2.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var url = "https://localhost:7104/Database/productid";
            var client = new HttpClient();
            var response = await client.PostAsync(url,byteCon2);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<ProductView>>(json);
            dataGridView_Product.DataSource = res;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            GetTable();
        }

        private void button_Seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
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
