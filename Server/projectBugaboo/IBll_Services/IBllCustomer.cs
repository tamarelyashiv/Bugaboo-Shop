using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
    public interface IBllCustomer
    {
         Task<int> AddCustomerAsync(Dto_Common_Enteties.CustomerDto customer); // מקבל לקוח להוספה
        Task<Dto_Common_Enteties.CustomerDto> SelectByIdAsync(string? email);
        Task<bool> EmailExistsAsync(string email);

    }
}
