using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBll_Services
{
    public interface IBllBuy
    {
        Task<int> AddBuyAsync(Dto_Common_Enteties.BuyDto b);
        int sump(Dto_Common_Enteties.BuyDto b);



    }
}
