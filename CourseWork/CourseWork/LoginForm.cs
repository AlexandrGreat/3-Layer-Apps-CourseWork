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
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        DBConnect conn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Username.Clear();
            textBox_Password.Clear();
        }

        public static string seller;
        public static int sellerID;

        private async void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "" || textBox_Password.Text == ""||comboBox_Role.Text=="-select role-")
            {
                MessageBox.Show("Please input all fields");
            }
            else
            {
                if (comboBox_Role.SelectedItem.ToString() == "Admin")
                {
                    if (textBox_Username.Text == "Alex" && textBox_Password.Text == "123123")
                    {
                        ProductForm product = new ProductForm();
                        product.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
                else
                {
                    Login login=new Login();
                    login.Name= textBox_Username.Text;
                    login.Password= textBox_Password.Text;
                    var content = JsonConvert.SerializeObject(login);
                    var buff = System.Text.Encoding.UTF8.GetBytes(content);
                    var byteCon = new ByteArrayContent(buff);
                    byteCon.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    var url = "https://localhost:7104/Database/login";
                    var client = new HttpClient();
                    var response = await client.PostAsync(url, byteCon);
                    var json = await response.Content.ReadAsStringAsync();
                    var res = JsonConvert.DeserializeObject<List<Seller>>(json);
                    Console.WriteLine(json);
                    try
                    {
                        if (res != null)
                        {
                            sellerID = res[0].ID;
                            seller = textBox_Username.Text;
                            SellingForm selling = new SellingForm();
                            selling.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("invalid username or password");
                        }
                    }
                    catch{ }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn=new DBConnect();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
