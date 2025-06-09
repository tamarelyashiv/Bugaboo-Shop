using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Converters
{
    internal class CategoryConverters
    {
        public static Dto_Common_Enteties.CategoryDto ToCategoryDto(models.Category c)
        {
            Dto_Common_Enteties.CategoryDto cNew = new Dto_Common_Enteties.CategoryDto();
           cNew.CategoryId = c.CategoryId;
            cNew.NameCategory = c.NameCategory;

            return cNew;
        }
        public static List<Dto_Common_Enteties.CategoryDto> ToListCategoryDto(List<models.Category> lc)
        {
            List<Dto_Common_Enteties.CategoryDto> lnew = new List<Dto_Common_Enteties.CategoryDto>();
            foreach (models.Category c in lc)
            {
                lnew.Add(ToCategoryDto(c));
            }
            return lnew;
        }
        public static models.Category ToCategory(Dto_Common_Enteties.CategoryDto c)
        {
            models.Category cNew = new models.Category();
            cNew.CategoryId = c.CategoryId;
            cNew.NameCategory = c.NameCategory;

            return cNew;
        }
    }
}
