using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_Common_Enteties
{
    public partial class ProductDto
    {
        public int ProductId { get; set; }

        public string NameProduct { get; set; } = null!;

        public int? ModelId { get; set; }

        public int? CategoryId { get; set; }


        public string? Descriptions { get; set; }

        public int? Price { get; set; }

        public string? Picture { get; set; }

        public int? Quantity { get; set; }

        public DateTime? LastUpdate { get; set; }

        //public  ICollection<BuyDetails> BuyDetails { get; } = new List<BuyDetail>();
        public string? NameCategory { get; set; } = null;
        public string? NameModel { get; set; } = null;

    }
}
