using CourseWorkAPI.Services;
using CourseWorkAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;

namespace CourseWorkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DatabaseService _databaseService;

        public DatabaseController(IConfiguration configuration, DatabaseService databaseService)
        {
            _configuration = configuration;
            _databaseService = databaseService;
        }

        //----------------------CATID-PROVID------------------------//
        [HttpPost("catid")]
        public Task<JsonResult> GetCAT([FromBody] StringModel catname)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetCAT(conLine,catname.Value);
        }

        [HttpPost("provid")]
        public Task<JsonResult> GetPROV([FromBody] StringModel provname)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetPROV(conLine,provname.Value);
        }

        //----------------------PRODUCT------------------------//
        [HttpGet("product")]
        public Task<JsonResult> GetProduct()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetProduct(conLine);
        }

        [HttpGet("productview")]
        public Task<JsonResult> GetProductView()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetProductView(conLine);
        }

        [HttpGet("productviewmin")]
        public Task<JsonResult> GetProductViewMin()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetProductViewMin(conLine);
        }

        [HttpPost("product")]
        public Task<JsonResult> PostProduct([FromBody] Product product)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.PostProduct(conLine,product.Name,product.Description,product.Price,product.DiscountPercentage,product.Category,product.Provider);
        }

        [HttpPost("productid")]
        public Task<JsonResult> GetProductByID([FromBody] StringModel id)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetProductByID(conLine, id.Value);
        }

        [HttpPost("productidmin")]
        public Task<JsonResult> GetProductByIDMin([FromBody] StringModel id)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetProductByIDMin(conLine, id.Value);
        }

        [HttpPut("product")]
        public Task<JsonResult> PutProduct([FromBody] Product product)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.PutProduct(conLine, product.ID, product.Name, product.Description, product.Price, product.DiscountPercentage, product.Category, product.Provider);
        }

        [HttpDelete("product")]
        public Task<JsonResult> DeleteProduct([FromBody] Product product)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.DeleteProduct(conLine,product.ID);
        }

        //----------------------CATEGORY------------------------//
        [HttpGet("category")]
        public Task<JsonResult> GetCategory()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetCategory(conLine);
        }

        [HttpPost("category")]
        public Task<JsonResult> PostCategory([FromBody] Category category)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.PostCategory(conLine, category.Name, category.Description);
        }

        [HttpPut("category")]
        public Task<JsonResult> PutCategory([FromBody] Category category)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.PutCategory(conLine, category.ID,category.Name,category.Description);
        }

        [HttpDelete("category")]
        public Task<JsonResult> DeleteCategory([FromBody] Category category)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.DeleteCategory(conLine, category.ID);
        }

        //----------------------PROVIDER------------------------//
        [HttpGet("provider")]
        public Task<JsonResult> GetProvider()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetProvider(conLine);
        }

        //----------------------SELLER------------------------//
        [HttpGet("seller")]
        public Task<JsonResult> GetSeller()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetSeller(conLine);
        }

        [HttpPost("seller")]
        public Task<JsonResult> PostSeller([FromBody] Seller seller)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.PostSeller(conLine, seller.Name,seller.Age,seller.Phone,seller.Password);
        }

        [HttpPut("seller")]
        public Task<JsonResult> PutSeller([FromBody] Seller seller)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.PutSeller(conLine, seller.ID,seller.Name,seller.Age,seller.Phone,seller.Password);
        }

        [HttpDelete("seller")]
        public Task<JsonResult> DeleteSeller([FromBody] Seller seller)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.DeleteSeller(conLine, seller.ID);
        }

        //----------------------EVENTLOG------------------------//
        [HttpGet("eventlog")]
        public Task<JsonResult> GetEventLog()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetEventLog(conLine);
        }

        [HttpDelete("eventlog")]
        public Task<JsonResult> DeleteEventLog([FromBody] EventLog eventLog)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.DeleteEventLog(conLine, eventLog.ID);
        }

        [HttpDelete("eventlogall")]
        public Task<JsonResult> DeleteEventLogAll()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.DeleteEventLogAll(conLine);
        }

        [HttpPost("eventlogtable")]
        public Task<JsonResult> GetEventByTable([FromBody] StringModel name)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetEventByTable(conLine, name.Value);
        }

        //----------------------BILLLOG------------------------//
        [HttpGet("billlog")]
        public Task<JsonResult> GetBillLog()
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.GetBillLog(conLine);
        }

        [HttpPost("billlog")]
        public Task<JsonResult> PostBillLog([FromBody] BillLog bill)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.PostBillLog(conLine, bill.ID, bill.Seller, bill.Date, bill.Total);
        }

        [HttpDelete("billlog")]
        public Task<JsonResult> DeleteBillLog([FromBody] BillLog bill)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.DeleteBillLog(conLine, bill.ID);
        }

        //----------------------LOGIN------------------------//
        [HttpPost("login")]
        public Task<JsonResult> Login([FromBody] Login login)
        {
            string conLine = _configuration.GetConnectionString("DatabaseCon").ToString();
            return _databaseService.Login(conLine, login.Name, login.Password);
        }
    }
}