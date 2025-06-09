using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Converters
{
    public class BuyConverters
    {


        public static Dto_Common_Enteties.BuyDto toBuyDto( models.Buy b)
        {
            BuyDto BuyDto = new BuyDto();
            //BuyDto.BuyId = b.BuyId;
            //BuyDto.CustomerId = b.CustomerId;
            BuyDto.BuyDate = new DateTime();
            BuyDto.Remark = b.Remark;
            BuyDto.Payment = b.Payment;

            if (b.Customer != null)
                //פה אנחנו נהנות משדה הניווט שלא דרש קש"ג מסובך אלא אפשר גישה ישירה לשדות טבלת המפתח זר
                //Depart = null אחרת שדה הinclude חובה בשלב השליפה לדאוג לבצע פעולת 
                BuyDto.CustomerId = b.Customer.CustomerId;
            return BuyDto;

        }
        public static async Task<models.Buy> ToBuy(BuyDto b)
        {
            models.Buy buy1 = new models.Buy();
            buy1.CustomerId = b.CustomerId;
            buy1.BuyDate = b.BuyDate;
            buy1.Remark = b.Remark;
            buy1.Payment = b.Payment;
            return buy1;
        }
        public static List<BuyDto> ToListBuyDto(List<models.Buy> lbuy)
        {
            List<BuyDto> lNew = new List<BuyDto>();
            foreach (models.Buy l in lbuy)
            {
                lNew.Add(toBuyDto(l));
            }
            return lNew;

        }


    }


}