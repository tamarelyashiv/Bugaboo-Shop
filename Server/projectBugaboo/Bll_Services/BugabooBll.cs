using Dto_Common_Enteties;

namespace Bll_Services
{
    public class BugabooBll :IBll_Services.IBugabooBll
    {
        IDal_Repository.IDal_Product dalP;
        //IDal_Repository.IDalRepository<Dto_Common_Enteties.CustomerDto> dalc;

        public BugabooBll(IDal_Repository.IDal_Product b)
        {
            this.dalP = b;
        }
       
        public async Task<List<Dto_Common_Enteties.ProductDto>> SelectAllAsync()
        {
            //נבטל את יצירת המופע כדי למנוע תלות
            // Dal_Repository.CoursesDal c= new Dal_Repository.CoursesDal();
            //לפעמים כאן יש לוגיקה

            return await dalP.SelectAllAsync();
        }


        //public async Task<Dto_Common_Enteties.ProductDto> SelectByIdAsync(int id)
        //{
        //    var q1 = await dalP.SelectByIdAsync(id);
        //    //יתכן שפה תופיע לוגיקה
        //    return q1;
        //}
        //public async Task<ProductDto> SelectById(int id)
        //{
        //    var q1 = await dalP.SelectById(id);
        //    //יתכן שפה תופיע לוגיקה
        //    return q1;
        //}
        public async Task<List<Dto_Common_Enteties.ProductDto>> SelectByCategoryAndModelAsync(int? categoryId, int? modelId)
        {
            var q1 = await SelectAllAsync();

            if (categoryId.HasValue)
                q1 = q1.Where(c => c.CategoryId == categoryId.Value).ToList();

            if (modelId.HasValue)
                q1 = q1.Where(c => c.ModelId == modelId.Value).ToList();

            return q1;
        }
    }
}