using Dto_Common_Enteties;
using Microsoft.AspNetCore.Mvc;

namespace projectBugaboo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyController : ControllerBase
    {


        //public BuyController(IBll_Services.IBllBuy b)
        //{
        //    this.c = c;
        //}
        //IBll_Services.IBllCustomer c;

        //[HttpPost]
        //public async Task<int> postBuy(Dto_Common_Enteties.BuyDto customer)
        //{
        //    return await c.AddAsync(customer);
        //}
        public BuyController(IBll_Services.IBllBuy b)
        {
            this.b = b;
        }
        IBll_Services.IBllBuy b;
        //[HttpPost]
        //public async Task<List<Dto_Common_Enteties.CustomerDto>> postCustomer(Dto_Common_Enteties.CustomerDto customer)
        //{
        //    return await c.AddCustomerAsync(customer);
        //}

        //[HttpPost]
        //public async Task<ActionResult> postBuy(BuyDto buy) 
        //{
            //if (buy == null)
            //{
            //    return BadRequest("BuyDto cannot be null");
            //}

            //try
            //{
            //    var result = await b.AddBuyAsync(buy);
            //    return CreatedAtAction(nameof(postBuy), new { id = result.BuyDate }, result);
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(500, $"Internal server error: {ex.Message}");
            //}

            



        //}

        [HttpPost]
        public async Task<int> postBuy(Dto_Common_Enteties.BuyDto buy)
        {
            int result=await  b.AddBuyAsync(buy);
            return result;
        }
        //[HttpPost("sum")]
        //public async Task<ActionResult<BuyDto>> postBuySum(BuyDto buy)
        //{
        //    if (buy == null)
        //    {
        //        return BadRequest("BuyDto cannot be null");
        //    }

        //    try
        //    {
        //        var result = await b.sump(buy);
        //        return CreatedAtAction(nameof(postBuy), new { id = result.BuyDate }, result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }




        //}
        //[HttpPost("sum")]
        //public async Task<ActionResult<int>> postBuySum(BuyDto buy)
        //{
        //    if (buy == null)
        //    {
        //        return BadRequest("BuyDto cannot be null");
        //    }

        //    try
        //    {
        //        var sum = await b.sump(buy); // סכום הוא int
        //        return Ok(sum); // מחזיר את הסכום
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}




    }
}
