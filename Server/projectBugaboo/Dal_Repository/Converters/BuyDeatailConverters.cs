using Dal_Repository.models;
using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Converters
{
    internal class BuyDeatailConverters
    {

        public static DeatailsDto ToBuyDetailDto(models.BuyDetail d)
        {
            DeatailsDto DetailsDto = new DeatailsDto();
            //BuyDto.BuyId = b.BuyId;

            DetailsDto.BuyDetailsId = d.BuyDetailsId;
            DetailsDto.Amount = d.Amount;
            DetailsDto.BuyId = d.BuyId;
            DetailsDto.ProductId = d.ProductId;




            if (d.Buy != null)
                //פה אנחנו נהנות משדה הניווט שלא דרש קש"ג מסובך אלא אפשר גישה ישירה לשדות טבלת המפתח זר
                //Depart = null אחרת שדה הinclude חובה בשלב השליפה לדאוג לבצע פעולת 
                DetailsDto.BuyId = d.Buy.BuyId;

            if (d.Product != null)
                //פה אנחנו נהנות משדה הניווט שלא דרש קש"ג מסובך אלא אפשר גישה ישירה לשדות טבלת המפתח זר
                //Depart = null אחרת שדה הinclude חובה בשלב השליפה לדאוג לבצע פעולת 
                DetailsDto.ProductId = d.Product.ProductId;
            return DetailsDto;





            //BuyDto.CustomerId = b.CustomerId;
            //BuyDto.BuyDate = new DateTime();
            //BuyDto.Remark = b.Remark;
            //BuyDto.Payment = b.Payment;
        }
        public static models.BuyDetail ToBuyDeatails(DeatailsDto d)
        {
            models.BuyDetail buy1 = new models.BuyDetail();
            //buy1.BuyDetailsId = d.BuyDetailsId;
            buy1.Amount = d.Amount;
            buy1.BuyId = d.BuyId;
            buy1.ProductId = d.ProductId;

            return buy1;
        }
        public static List<DeatailsDto> ToListBuyDto(List<models.BuyDetail> lbuy)
        {
            List<DeatailsDto> lNew = new List<DeatailsDto>();
            foreach (models.BuyDetail l in lbuy)
            {
                lNew.Add(ToBuyDetailDto(l));
            }
            return lNew;

        }


        public static List<models.BuyDetail>ToBuyDetailsDtoList(List<Dto_Common_Enteties.DeatailsDto> lbuy) 
        { /*return new List<BuyDetail>();*/
          List<models.BuyDetail> buy1 = new List<models.BuyDetail>();
            foreach (Dto_Common_Enteties.DeatailsDto  l in lbuy)
            {
                buy1.Add(ToBuyDeatails(l));
            }
            return buy1;

        }
    }
}
