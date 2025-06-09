using Bll_Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectBugaboo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustController : ControllerBase
    {
        public CustController(IBll_Services.IBllCustomer c)
        {
            this.c = c;
        }
        IBll_Services.IBllCustomer c;
        //[HttpPost]
        //public async Task<List<Dto_Common_Enteties.CustomerDto>> postCustomer(Dto_Common_Enteties.CustomerDto customer)
        //{
        //    return await c.AddCustomerAsync(customer);
        //}

        [HttpPost]
        public async Task<int> postCustomer(Dto_Common_Enteties.CustomerDto customer)
        {
            return await c.AddCustomerAsync(customer);
        }
      
        [HttpGet]
        public async Task<Dto_Common_Enteties.CustomerDto> GetAsync(string? email)
        {
            //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
            return await c.SelectByIdAsync(email);
        }
        [HttpPost("check-email")]
        public async Task<IActionResult> CheckEmail(string email)
        {
            var exists = await c.EmailExistsAsync(email); // השתמש ב-c במקום CustomerBll
            return Ok(new { EmailExists = exists });
        }
    }
}
