using Dto_Common_Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal_Repository
{
    public interface IDalBuy
    {
        Task<int> AddBuyAsync(BuyDto buy);
        Task<int> AddBuyDeatailsAsync(List<DeatailsDto> bd);
    }
}
