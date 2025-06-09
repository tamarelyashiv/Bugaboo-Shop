using Dal_Repository.models;
using Dto_Common_Enteties;
using IDal_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class BuyDal : IDalBuy
    {
        ProjectBugabooContext db;
        public BuyDal(ProjectBugabooContext db)
        {
            this.db = db;
        }


        public async Task<int> AddBuyAsync(BuyDto bd)
        {
            models.Buy buyEntity = await Converters.BuyConverters.ToBuy(bd);
            var x = db.Buys.Add(buyEntity);
            await db.SaveChangesAsync();
            int f = 5;
            if(x.Entity.BuyId.GetType()==f.GetType())
                return x.Entity.BuyId;
            //int id = await Converters.BuyConverters.toBuyDto(x);
            
            else return -1;
        }
        public async Task<int> AddBuyDeatailsAsync(List<DeatailsDto> bd)
        {

            var buyEntity = Converters.BuyDeatailConverters.ToBuyDetailsDtoList(bd);
            foreach (var item in buyEntity)
            {
                db.BuyDetails.Add(item);
            }

            return await db.SaveChangesAsync();


        }

        //Task<DeatailsDto> IDalBuy.AddBuyDeatailsAsync(List<DeatailsDto> d)
        //{
        //    foreach(DeatailsDto detail in d)
        //    {
        //        db.
        //    }
        //}
    }
}
