using Dal_Repository.models;
using IDal_Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository
{
    public class CustomerDal : IDal_Customer
    {
        ProjectBugabooContext db;
        public CustomerDal(ProjectBugabooContext db)
        {
            this.db = db;
        }

        public async Task<int> AddCustomerAsync(Dto_Common_Enteties.CustomerDto c)
        {
            db.Customers.Add(Converters.CustomerConverters.ToCustomer(c));
            int x = await db.SaveChangesAsync();
            return x;
        }
        public async Task<Dto_Common_Enteties.CustomerDto> SelectByIdAsync(string? email )
        {
            try
            {
                var q1 = await db.Customers.FirstOrDefaultAsync(c => c.Email == email);
                //q1[0].Depart.Name יכיל את שם המסלול של הקורס הראשון
                //DTOנרצה להמיר את האוסף מסוג האובייקט של מיקרוסופט לאוסף מסוג מחלקה שירצו בספריית ה
                //DTOנרצה להמיר את האוסף מסוג האובייקט של מיקרוסופט לאוסף מסוג מחלקה שירצו בספריית ה
                //1. שימוש בהמרה של פונקציות שאנחנו כתבנו
                return Converters.CustomerConverters.ToCustomerDto(q1);
                //2. automapper שימוש בהמרה עי ספריית 
            }
            catch (Exception ex) { throw ex; }

        }
        public async Task<bool> EmailExistsAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false; // טיפול במקרה שבו ה-email הוא null או ריק
            }
            return await db.Customers.AnyAsync(c => c.Email == email);
        }
    }
    


}

