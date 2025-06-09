using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_Common_Enteties
{
    public class BuyDto
    {
        public int? BuyId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? DateBirth { get; set; }
        public Dictionary<int, cartItemsDto> ? CartItems { get; set; } = new();
        public string ? Remark { get; set; } = null!;
        public DateTime ? BuyDate { get; set; }
        public int? Payment { get;set; }
    }
}
