using Dal_Repository.models;
using Dto_Common_Enteties;
using IDal_Repository;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace Dal_Repository
{
  


        public class BugabooDal :IDal_Product
    {
            ProjectBugabooContext db;
            public BugabooDal(ProjectBugabooContext db)
            {
                this.db = db;
            }

        public Task<int> AddAsync(ProductDto t)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Dto_Common_Enteties.ProductDto>> SelectAllAsync()
            {
            var q = await db.Products.ToListAsync();
            //var q1 = await db..Include(c => c.Depart).FirstOrDefaultAsync(c => c.Courseid == id);

            return Converters.BugabooConverters.ToListProductDto(q);
            }

        public Task<List<ProductDto>> SelectAllCategory()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> SelectAllModel()
        {
            throw new NotImplementedException();
        }
        public async Task<ProductDto> SelectByIdAsync(int id)
        {
            try
            {
                //var q1 = db.Customers.FirstOrDefault(c => c.Email == id);
                var q1=await db.Products.Include(c=>c.Category).Include(m=>m.Model).FirstOrDefaultAsync(c=>c.ProductId==id);
                //q1[0].Depart.Name יכיל את שם המסלול של הקורס הראשון
                //DTOנרצה להמיר את האוסף מסוג האובייקט של מיקרוסופט לאוסף מסוג מחלקה שירצו בספריית ה
                //1. שימוש בהמרה של פונקציות שאנחנו כתבנו
                return Converters.BugabooConverters.ToProductDto(q1);
                //2. automapper שימוש בהמרה עי ספריית 
            }
            catch (Exception ex) { throw ex; }

        }

        //public Task<List<ProductDto>> SelectAllCategory()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<int> AddAsync(Dto_Common_Enteties.CustomerDto c)
        //{

        //    db.Products.Add(Converters.BugabooConverters.ToProductDto(c));
        //    int x = await db.SaveChangesAsync();
        //    return x;
        //}


        //public async Task<Dto_Common_Enteties.ProductDto> SelectByIdAsync(int id)
        //{
        //    try
        //    {
        //        var q1 = await db.Products.Include(c => c.Category).FirstOrDefaultAsync(c => c.CategoryId == id);
        //        //q1[0].Depart.Name יכיל את שם המסלול של הקורס הראשון

        //        //DTOנרצה להמיר את האוסף מסוג האובייקט של מיקרוסופט לאוסף מסוג מחלקה שירצו בספריית ה
        //        //1. שימוש בהמרה של פונקציות שאנחנו כתבנו
        //        return Converters.BugabooConverters.ToProductDto(q1);
        //        //2. automapper שימוש בהמרה עי ספריית 
        //    }
        //    catch (Exception ex) { throw ex; }
        //}

    }
}

