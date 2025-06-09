using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Converters
{
    internal class CustomerConverters
    {

        //הוספת לקוח
        public static Dto_Common_Enteties.CustomerDto ToCustomerDto(models.Customer c)
        {
            Dto_Common_Enteties.CustomerDto cNew = new Dto_Common_Enteties.CustomerDto();
            if (c != null) {
                cNew.NameCustomer = c.NameCustomer;
                cNew.Phone = c.Phone;
                cNew.Email = c.Email;
                cNew.DateBirth = c.DateBirth;
                return cNew;
            }
            return null;
        }
        public static List<Dto_Common_Enteties.CustomerDto> ToListCustomerDto(List<models.Customer> lc)
        {
            List<Dto_Common_Enteties.CustomerDto> lnew = new List<Dto_Common_Enteties.CustomerDto>();
            foreach (models.Customer c in lc)
            {
                lnew.Add(ToCustomerDto(c));
            }
            return lnew;
        }
        public static models.Customer ToCustomer(Dto_Common_Enteties.CustomerDto c)
        {
            models.Customer cNew = new models.Customer();
            cNew.NameCustomer = c.NameCustomer;
            cNew.Phone = c.Phone;
            cNew.Email = c.Email;
            cNew.DateBirth = c.DateBirth;
            return cNew;
        }
    }
}

