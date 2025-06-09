using Dto_Common_Enteties;
using IBll_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class CustomerBll:IBllCustomer
    {
        IDal_Repository.IDal_Customer dalc;

        public CustomerBll(IDal_Repository.IDal_Customer b)
        {
            this.dalc = b;
        }
      
        public async Task<int> AddCustomerAsync(CustomerDto customer)
        {
            //בדיקות תקינות האם האובייקט תקין
            //  Dal_Repository.CoursesDal c = new Dal_Repository.CoursesDal();
            return await dalc.AddCustomerAsync(customer);
        }

       

        public Task<List<CustomerDto>> SelectAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerDto> SelectByIdAsync(string? email)
        {
            if (string.IsNullOrEmpty(email))
            {
                // טיפול במקרה שבו ה-email הוא null או ריק
                return null; // או החזרת אובייקט אחר במידת הצורך
            }
            var q1 = await dalc.SelectByIdAsync(email);
            //יתכן שפה תופיע לוגיקה
            return q1;
        }
        public async Task<bool> EmailExistsAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false; // או טיפול במקרה אחר במידת הצורך
            }
            return await dalc.EmailExistsAsync(email);
        }
    }
}
