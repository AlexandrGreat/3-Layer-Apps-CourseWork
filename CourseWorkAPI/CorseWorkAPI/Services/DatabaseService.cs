using CorseWorkAPI.Models;
using CourseWorkAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CourseWorkAPI.Services
{
    public class DatabaseService
    {
        //----------------------CATID-PROVID------------------------//
        // PROVID
        public async Task<JsonResult> GetPROV(string conLine,string provname)
        {
            SqlConnection con = new SqlConnection(conLine);
            int provID = 0;

            SqlCommand command1 = new SqlCommand($"select dbo.getProvider('{provname}')", con);
            con.Open();
            provID = (int)command1.ExecuteScalar();
            StringModel data=new StringModel();
            data.Value = provID.ToString();
            if (provID == 0)
            {
                return new JsonResult(null);
            }
            else
                return new JsonResult(data);
        }

        // CATID
        public async Task<JsonResult> GetCAT(string conLine, string catname)
        {
            SqlConnection con = new SqlConnection(conLine);
            int catID = 0;

            SqlCommand command1 = new SqlCommand($"select dbo.getCategory('{catname}')", con);
            con.Open();
            catID = (int)command1.ExecuteScalar();
            StringModel data = new StringModel();
            data.Value = catID.ToString();
            if (catID == 0)
            {
                return new JsonResult(null);
            }
            else
                return new JsonResult(data);
        }


        //----------------------PRODUCT------------------------//
        // GET PRODUCT
        public async Task<JsonResult> GetProduct(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Product", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Product> objects = new List<Product>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Product model = new Product();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    model.Category = Convert.ToInt32(dt.Rows[i]["Category"]);
                    model.Provider = Convert.ToInt32(dt.Rows[i]["Provider"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // GET PRODUCT VIEW
        public async Task<JsonResult> GetProductView(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            string selectQuery = "ProductSelect";
            SqlCommand command = new SqlCommand(selectQuery, con) { CommandType = CommandType.StoredProcedure };

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ProductView> objects = new List<ProductView>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductView model = new ProductView();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    model.Category = Convert.ToString(dt.Rows[i]["Category"]);
                    model.Provider = Convert.ToString(dt.Rows[i]["Provider"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // GET PRODUCT VIEW MIN
        public async Task<JsonResult> GetProductViewMin(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select Name,Price,DiscountPercentage from Product", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ProductMin> objects = new List<ProductMin>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductMin model = new ProductMin();
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // GET PRODUCT BY ID
        public async Task<JsonResult> GetProductByID(string conLine, string id)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Product where category='"+id+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ProductView> objects = new List<ProductView>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductView model = new ProductView();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    model.Category = Convert.ToString(dt.Rows[i]["Category"]);
                    model.Provider = Convert.ToString(dt.Rows[i]["Provider"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // GET PRODUCT BY ID MIN
        public async Task<JsonResult> GetProductByIDMin(string conLine, string id)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select Name,Price,DiscountPercentage from Product where category='" + id + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ProductMin> objects = new List<ProductMin>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductMin model = new ProductMin();
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        //POST PRODUCT
        public async Task<JsonResult> PostProduct(string conLine,string name,string desc,int price,int disc,int catID,int provID)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "InsertProduct";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@disc", SqlDbType.Int).Value = disc;
            command.Parameters.Add("@catid", SqlDbType.Int).Value = catID;
            command.Parameters.Add("@provid", SqlDbType.Int).Value = provID;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Product", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ProductView> objects = new List<ProductView>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductView model = new ProductView();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    model.Category = Convert.ToString(dt.Rows[i]["Category"]);
                    model.Provider = Convert.ToString(dt.Rows[i]["Provider"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        //PUT PRODUCT
        public async Task<JsonResult> PutProduct(string conLine, int id, string name, string desc, int price, int disc, int catID, int provID)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "UpdateProduct";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@disc", SqlDbType.Int).Value = disc;
            command.Parameters.Add("@catid", SqlDbType.Int).Value = catID;
            command.Parameters.Add("@provid", SqlDbType.Int).Value = provID;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Product", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ProductView> objects = new List<ProductView>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductView model = new ProductView();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    model.Category = Convert.ToString(dt.Rows[i]["Category"]);
                    model.Provider = Convert.ToString(dt.Rows[i]["Provider"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }
        
        //DELETE PRODUCT
        public async Task<JsonResult> DeleteProduct(string conLine, int id)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "DeleteProduct";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Product", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<ProductView> objects = new List<ProductView>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductView model = new ProductView();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Price = Convert.ToInt32(dt.Rows[i]["Price"]);
                    model.DiscountPercentage = Convert.ToInt32(dt.Rows[i]["DiscountPercentage"]);
                    model.Category = Convert.ToString(dt.Rows[i]["Category"]);
                    model.Provider = Convert.ToString(dt.Rows[i]["Provider"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }


        //----------------------CATEGORY------------------------//
        // GET CATEGORY
        public async Task<JsonResult> GetCategory(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Category> objects = new List<Category>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Category model = new Category();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // POST CATEGORY
        public async Task<JsonResult> PostCategory(string conLine, string name, string desc)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "InsertCategory";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Category> objects = new List<Category>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Category model = new Category();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // PUT CATEGORY
        public async Task<JsonResult> PutCategory(string conLine, int id, string name, string desc)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "UpdateCategory";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Category> objects = new List<Category>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Category model = new Category();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // DELETE CATGEORY
        public async Task<JsonResult> DeleteCategory(string conLine, int id)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "DeleteCategory";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Category> objects = new List<Category>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Category model = new Category();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Description = Convert.ToString(dt.Rows[i]["Description"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }


        //----------------------PROVIDER------------------------//
        // GET PROVIDER
        public async Task<JsonResult> GetProvider(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Provider", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Provider> objects = new List<Provider>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Provider model = new Provider();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }


        //----------------------SELLER------------------------//
        // GET SELLER
        public async Task<JsonResult> GetSeller(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select * from Seller", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Seller> objects = new List<Seller>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Seller model = new Seller();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    model.Phone = Convert.ToString(dt.Rows[i]["Phone"]);
                    model.Password = Convert.ToString(dt.Rows[i]["Password"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // POST SELLER
        public async Task<JsonResult> PostSeller(string conLine, string name, int age, string phone, string pass)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "InsertSeller";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Seller", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Seller> objects = new List<Seller>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Seller model = new Seller();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Phone = Convert.ToString(dt.Rows[i]["Phone"]);
                    model.Password = Convert.ToString(dt.Rows[i]["Password"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // PUT SELLER
        public async Task<JsonResult> PutSeller(string conLine, int id, string name, int age, string phone, string pass)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "UpdateSeller";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@age", SqlDbType.Int).Value = age;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Seller", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Seller> objects = new List<Seller>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Seller model = new Seller();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Phone = Convert.ToString(dt.Rows[i]["Phone"]);
                    model.Password = Convert.ToString(dt.Rows[i]["Password"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // DELETE SELLER
        public async Task<JsonResult> DeleteSeller(string conLine, int id)
        {
            SqlConnection con = new SqlConnection(conLine);
            string sql = "DeleteSeller";
            SqlCommand command = new SqlCommand(sql, con) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            con.Open();
            command.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Seller", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Seller> objects = new List<Seller>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Seller model = new Seller();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Phone = Convert.ToString(dt.Rows[i]["Phone"]);
                    model.Password = Convert.ToString(dt.Rows[i]["Password"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }


        //----------------------EVENTLOG------------------------//
        // GET EVENTLOG
        public async Task<JsonResult> GetEventLog(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("Select * from EventLog", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<EventLog> objects = new List<EventLog>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EventLog model = new EventLog();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.EventType = Convert.ToString(dt.Rows[i]["EventType"]);
                    model.EventTable = Convert.ToString(dt.Rows[i]["EventTable"]);
                    model.Rows = Convert.ToInt32(dt.Rows[i]["Rows"]);
                    model.DateTime = Convert.ToString(dt.Rows[i]["DateTime"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // DELETE EVENTLOG
        public async Task<JsonResult> DeleteEventLog(string conLine, int id)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter($"Delete from EventLog where id={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<EventLog> objects = new List<EventLog>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EventLog model = new EventLog();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.EventType = Convert.ToString(dt.Rows[i]["EventType"]);
                    model.EventTable = Convert.ToString(dt.Rows[i]["EventTable"]);
                    model.Rows = Convert.ToInt32(dt.Rows[i]["Rows"]);
                    model.DateTime = Convert.ToString(dt.Rows[i]["DateTime"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // DELETE EVENTLOG TOTAL
        public async Task<JsonResult> DeleteEventLogAll(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter($"Delete from EventLog",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<EventLog> objects = new List<EventLog>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EventLog model = new EventLog();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.EventType = Convert.ToString(dt.Rows[i]["EventType"]);
                    model.EventTable = Convert.ToString(dt.Rows[i]["EventTable"]);
                    model.Rows = Convert.ToInt32(dt.Rows[i]["Rows"]);
                    model.DateTime = Convert.ToString(dt.Rows[i]["DateTime"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // GET EVENT BY TABLE
        public async Task<JsonResult> GetEventByTable(string conLine, string name)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("select * from EventLog where EventTable='" + name + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<EventLog> objects = new List<EventLog>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EventLog model = new EventLog();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.EventType = Convert.ToString(dt.Rows[i]["EventType"]);
                    model.EventTable = Convert.ToString(dt.Rows[i]["EventTable"]);
                    model.Rows = Convert.ToInt32(dt.Rows[i]["Rows"]);
                    model.DateTime = Convert.ToString(dt.Rows[i]["DateTime"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        //----------------------BILLLOG------------------------//
        // GET BILLLOG
        public async Task<JsonResult> GetBillLog(string conLine)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("select b.Id,s.Name,b.Date,b.Total from BillLog b inner join Seller s on (b.Seller=s.Id)", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<BillLogView> objects = new List<BillLogView>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BillLogView model = new BillLogView();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Seller = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Date = Convert.ToString(dt.Rows[i]["Date"]);
                    model.Total = Convert.ToString(dt.Rows[i]["Total"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // POST BILLLOG
        public async Task<JsonResult> PostBillLog(string conLine, int id, int sellID, string date, string sum)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter($"Insert into BillLog values({id},{sellID},'{date}','{sum}')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<BillLog> objects = new List<BillLog>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BillLog model = new BillLog();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Seller = Convert.ToInt32(dt.Rows[i]["Name"]);
                    model.Date = Convert.ToString(dt.Rows[i]["Date"]);
                    model.Total = Convert.ToString(dt.Rows[i]["Total"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        // DELETE BILLLOG
        public async Task<JsonResult> DeleteBillLog(string conLine, int id)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter($"delete from BillLog where Id={id}", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<BillLog> objects = new List<BillLog>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BillLog model = new BillLog();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Seller = Convert.ToInt32(dt.Rows[i]["Name"]);
                    model.Date = Convert.ToString(dt.Rows[i]["Date"]);
                    model.Total = Convert.ToString(dt.Rows[i]["Total"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }

        //----------------------LOGIN------------------------//
        // LOGIN
        public async Task<JsonResult> Login(string conLine, string name, string password)
        {
            SqlConnection con = new SqlConnection(conLine);
            SqlDataAdapter da = new SqlDataAdapter("select * from seller where Name='" + name + "' and Password='" + password + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Seller> objects = new List<Seller>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Seller model = new Seller();
                    model.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    model.Name = Convert.ToString(dt.Rows[i]["Name"]);
                    model.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    model.Phone = Convert.ToString(dt.Rows[i]["Phone"]);
                    model.Password = Convert.ToString(dt.Rows[i]["Password"]);
                    objects.Add(model);
                }
            }
            if (objects.Count > 0)
                return new JsonResult(objects);
            else
            {
                return new JsonResult(null);
            }
        }
    }
}