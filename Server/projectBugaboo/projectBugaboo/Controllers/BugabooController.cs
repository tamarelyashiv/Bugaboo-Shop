using Dto_Common_Enteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugabooController : ControllerBase
    {
        //IBll_Services.IBllCustomer c;
        public BugabooController(IBll_Services.IBugabooBll b)
        {
            this.b = b;
        }
        IBll_Services.IBugabooBll b;
        //public BugabooController(IBll_Services.IBllCustomer c)
        //{
        //    this.c = c;
        //}
        [HttpGet]
        public async Task<List<Dto_Common_Enteties.ProductDto>> GetAsync()
        {
            return await b.SelectAllAsync();
        }
        //[HttpGet("{id}")]
        //public async Task<Dto_Common_Enteties.ProductDto> GetAsync(int id)
        //{
        //    //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
        //    return await b.SelectById(id);
        //}
        //[HttpGet]
        //public async Task<List<Dto_Common_Enteties.CategoryDto>> GetCategory()
        //{
        //    return await b.SelectAllCategory();
        //}
        //  [HttpGet]
        //public async Task<List<Dto_Common_Enteties.ProductDto>> GetAsyncById(Dto_Common_Enteties.ProductDto p)
        //{
        //    return await b.SelectByIdAsync();
        //}
        //public async Task<int> PostAsync(Dto_Common_Enteties.CustomerDto customer)
        //{
        //    return await b.AddAsync(customer);
        [HttpGet("byModel")]
        public async Task<List<Dto_Common_Enteties.ProductDto>> GetByModelAndCategoryAsync(int? categoryId, int? modelId)
        {
            return await b.SelectByCategoryAndModelAsync(categoryId, modelId);
        }
    


    }
}
