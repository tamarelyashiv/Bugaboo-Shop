using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
    public interface IDal_Product
    {
        Task<List<Dto_Common_Enteties.ProductDto> >SelectAllAsync();
        //Task<List<Dto_Common_Enteties.ProductDto>> SelectById(int id);
    }
}
