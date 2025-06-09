using Dto_Common_Enteties;
using IBll_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll_Services
{
    public class DetailsBll 
    {
        IDal_Repository.IdalBuyDeatails dalb;

        public DetailsBll(IDal_Repository.IdalBuyDeatails b)
        {
            this.dalb = b;
        }
        
    
               
    }
}


