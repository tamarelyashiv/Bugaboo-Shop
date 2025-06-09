using Dal_Repository.models;
using Dto_Common_Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    //public class ModelDal: IDal_Repository.IDalRepository<Dto_Common_Enteties.modelDto>
    //{
    //    ProjectBugabooContext db;
    //    public ModelDal(ProjectBugabooContext db)
    //    {
    //        this.db = db;
    //    }
        //public Task<int> AddAsync(modelDto t)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<modelDto>> SelectAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<modelDto>> SelectAllCategory()
        //{
        //    throw new NotImplementedException();
        //}

    //    public async Task<List<Dto_Common_Enteties.modelDto>> SelectAllModel()
    //    {
    //        var q = await db.Categories.ToListAsync();
    //        return Converters.ModelConverters(q);
    //    }
    //}
}
