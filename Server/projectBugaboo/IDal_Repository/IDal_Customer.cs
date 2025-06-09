using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
    public interface IDal_Customer
    {
        Task<int> AddCustomerAsync(CustomerDto customer);
        Task<Dto_Common_Enteties.CustomerDto> SelectByIdAsync(string? email);
        Task<bool> EmailExistsAsync(string email);

    }
}
