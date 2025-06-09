using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_Common_Enteties
{
    public class cartItemsDto
    {
        //מייצג אובייקט בסל הקניות כפי שמגיע מהאנגולר
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}
