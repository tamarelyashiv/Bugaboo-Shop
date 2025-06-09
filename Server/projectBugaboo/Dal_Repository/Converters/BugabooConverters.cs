using Dal_Repository.models;
using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Converters
{
    internal class BugabooConverters
    {
        //שליפת כל המוצרים
        public static Dto_Common_Enteties.ProductDto ToProductDto(models.Product p)
        {
            Dto_Common_Enteties.ProductDto pNew = new Dto_Common_Enteties.ProductDto();
            pNew.ProductId = p.ProductId;
            pNew.NameProduct = p.NameProduct;
            pNew.Descriptions = p.Descriptions;
            pNew.Price = p.Price;
            pNew.Picture = p.Picture;
            pNew.Quantity = p.Quantity;
            pNew.LastUpdate = p.LastUpdate;
            pNew.CategoryId = p.CategoryId;
            pNew.ModelId = p.ModelId;

            //if (p.Category != null)
            //    //פה אנחנו נהנות משדה הניווט שלא דרש קש"ג מסובך אלא אפשר גישה ישירה לשדות טבלת המפתח זר
            //    //Depart = null אחרת שדה הinclude חובה בשלב השליפה לדאוג לבצע פעולת 
            //    pNew.CategoryId = p.Category.CategoryId;

            //if (p.Model != null)
            //    //פה אנחנו נהנות משדה הניווט שלא דרש קש"ג מסובך אלא אפשר גישה ישירה לשדות טבלת המפתח זר
            //    //Depart = null אחרת שדה הinclude חובה בשלב השליפה לדאוג לבצע פעולת 
            //    pNew.ModelId = p.Model.ModelId;
            //return pNew;
            if (p.Category != null)
            {
                pNew.NameCategory = p.Category.NameCategory;
                pNew.CategoryId = p.Category.CategoryId;
            }
            //pNew.CategoryId = p.Category.NameCategory;
            if (p.Model != null) { 
                pNew.NameModel = p.Model.NameModel;
                pNew.ModelId = p.Model.ModelId; }
            return pNew;
        }
        public static List<Dto_Common_Enteties.ProductDto> ToListProductDto(List<models.Product> lc)
        {
            List<Dto_Common_Enteties.ProductDto> lnew = new List<Dto_Common_Enteties.ProductDto>();
            foreach (models.Product c in lc)
            {
                lnew.Add(ToProductDto(c));
            }
            return lnew;
        }
        public static models.Product ToProduct(Dto_Common_Enteties.ProductDto product)
        {
            models.Product product1 = new models.Product();
            product1.ProductId = product.ProductId;
            product1.Picture = product.Picture;
            product1.Quantity = product.Quantity;
            product1.NameProduct = product.NameProduct;
            product1.Descriptions = product.Descriptions;
            product1.Price = product.Price;
            product1.LastUpdate = product.LastUpdate;
            return product1;
        }


    }

}




