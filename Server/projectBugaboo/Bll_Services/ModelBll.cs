using Dto_Common_Enteties;
using IBll_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    //internal class ModelBll:IBll_Services.IBugabooBll
    //{
    //    IDal_Repository.IDalRepository<Dto_Common_Enteties.modelDto> dalm;
    //    public ModelBll(IDal_Repository.IDalRepository<Dto_Common_Enteties.modelDto> m)
    //    {
    //        this.dalm = m;
    //    }

    //    public Task<int> AddAsync(ProductDto t)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<List<ProductDto>> SelectAllAsync()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<List<ProductDto>> SelectAllCategory()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<List<Dto_Common_Enteties.modelDto>> SelectAllModel()
    //    {
    //        //נבטל את יצירת המופע כדי למנוע תלות
    //        // Dal_Repository.CoursesDal c= new Dal_Repository.CoursesDal();
    //        //לפעמים כאן יש לוגיקה

    //        return await dalm.SelectAllModel();
    //    }

    //    Task<List<ProductDto>> IBllServices<ProductDto>.SelectAllModel()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
