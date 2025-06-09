using Dto_Common_Enteties;
using IBll_Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bll_Services
{
    public class BuyBll : IBll_Services.IBllBuy
    {

        IDal_Repository.IDalBuy dalb;
       
        public BuyBll(IDal_Repository.IDalBuy b)
        {
            this.dalb = b;
        }
        public async Task<int> AddBuyAsync(BuyDto buy)
        {
            //טיפול בקניה
            // בדיקות תקינות
            if (buy == null)
            {
                throw new ArgumentNullException(nameof(buy), "BuyDto cannot be null");
            }
            buy.DateBirth = buy.DateBirth;

            buy.Payment = this.sump(buy);


             int r= await dalb.AddBuyAsync(buy);
            //BuyDto buySavedInDb = await dalb.AddBuyAsync(buy);


            //טיפול בפרטי קניה

            List<DeatailsDto> savedCartItems = new List<DeatailsDto>(); // רשימה לשמירת פריטי העגלה

            //int sum = 0;
            foreach (var item in buy.CartItems)
            {
                if (item.Value != null && item.Value.Product != null)
                {


                    var d = new DeatailsDto
                    {//קוד הקניה הגיעה לנו מהוספת קניה שנשמרה
                        BuyId = r,
                        ProductId = item.Value.Product.ProductId, // הנח שיש לך את המאפיינים האלה ב-cartItemsDto
                        Amount = item.Value.Quantity // הנח שיש לך את המאפיינים האלה ב-cartItemsDto
                    };
                    savedCartItems.Add(d);

                }
            }
             var q=   await dalb.AddBuyDeatailsAsync(savedCartItems);
            //חסר טיפול בשמירת הקניה או שמירת פרטי הקניה לא הצליחו




            return r;

        }
        public int sump(BuyDto buyy){
            int sum = 0;
            foreach (var item in buyy.CartItems)
            {
                if (item.Value != null && item.Value.Product != null)
                {
                    sum += ((int)item.Value.Product.Price * item.Value.Quantity);
                }
                else
                {
                    // טיפול במקרה של item.Value או item.Value.Product הוא null
                    throw new InvalidOperationException("Item or Product cannot be null");
                }

            }
            if (buyy.DateBirth?.Month == DateTime.Now.Month)
            {
                sum = (sum * 80) / 100;
            }
            //buyy.Payment = sum;
            return  sum;

        }

        
    }
}