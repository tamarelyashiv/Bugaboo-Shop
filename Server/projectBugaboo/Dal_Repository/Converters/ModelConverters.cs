using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal_Repository.Converters
{
    internal class ModelConverters
    {
        public static Dto_Common_Enteties.modelDto ToModelDto(models.Model m)
        {
            Dto_Common_Enteties.modelDto mNew = new Dto_Common_Enteties.modelDto();
            mNew.ModelId = m.ModelId;
           mNew.NameModel =m.NameModel;

            return mNew;
        }
        public static List<Dto_Common_Enteties.modelDto> ToListModelDto(List<models.Model> lc)
        {
            List<Dto_Common_Enteties.modelDto> lnew = new List<Dto_Common_Enteties.modelDto>();
            foreach (models.Model c in lc)
            {
                lnew.Add(ToModelDto(c));
            }
            return lnew;
        }
    }
}
