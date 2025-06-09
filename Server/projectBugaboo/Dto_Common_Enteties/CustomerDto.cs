using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto_Common_Enteties
{
    public partial class CustomerDto
    {
        public int CustomerId { get; set; }

        public string? NameCustomer { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public DateTime? DateBirth { get; set; }

        //public virtual ICollection<Buy> Buys { get; } = new List<Buy>();
    }
}
