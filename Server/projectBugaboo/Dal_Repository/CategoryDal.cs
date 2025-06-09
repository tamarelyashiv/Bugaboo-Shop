using Dal_Repository.models;
using Dal_Repository;

using Dto_Common_Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{

    //public class CategoryDal : IDal_Repository.IDalRepository<Dto_Common_Enteties.CategoryDto>
    //{
    //    ProjectBugabooContext db;
        //public CategoryDal(ProjectBugabooContext db)
        //{
        //    this.db = db;
        //}

        //public Task<int> AddAsync(CategoryDto t)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<CategoryDto>> SelectAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> AddAsync(CategoryDto t)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<CategoryDto>> SelectAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<CategoryDto>> SelectAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

    //    public async Task<List<Dto_Common_Enteties.CategoryDto>> SelectAllCategory()
    //    {
    //        var q = await db.Categories.ToListAsync();
    //        return Converters.CategoryConverters.ToListCategoryDto(q);
    //    }

    //    public Task<List<CategoryDto>> SelectAllModel()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
