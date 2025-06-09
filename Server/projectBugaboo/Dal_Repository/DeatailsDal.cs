//using Dal_Repository.models;
//using Dto_Common_Enteties;
//using IDal_Repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dal_Repository
//{
//    public class DeatailsDal:IdalBuyDeatails
//    {
//        ProjectBugabooContext db;
//        public DeatailsDal(ProjectBugabooContext db)
//        {
//            this.db = db;
//        }
//        public async Task<DeatailsDto> AddBuyDeatailsAsync(DeatailsDto b)
//        {
//            var buyEntity = Converters.BuyDeatailConverters.ToBuyDeatails(b);
//            db.BuyDetails.Add(buyEntity);
//            await db.SaveChangesAsync();

//            return Converters.BuyDeatailConverters.ToBuyDetailDto(buyEntity);
//        }


//    }

//}
