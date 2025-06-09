using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_Common_Enteties
{
    public class DeatailsDto
    {
        //מייצג אובייקט בסל הקניות כפי שנשמק/ישמר במסד
        public int? BuyDetailsId { get; set; }

        public int? BuyId { get; set; }

        public int? ProductId { get; set; }

        public int? Amount { get; set; }

        //public DateTime? BuyDate { get; set; } = null;

        //public string? ProductName { get; set; } = null;
    }
}
