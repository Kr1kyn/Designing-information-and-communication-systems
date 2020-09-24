using iTextSharp.text.io;
using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Interfaces;
using Unified_State_System_of_Entrants.DAL.Models;
using Unified_State_System_of_Entrants.DAL.Repositories;

namespace Unified_State_System_of_Entrants.BLL.Filters
{
    class HEIsFilterBilder
    {
        private ICollection<HEI> heis;
        public HEIsFilterBilder(ICollection<HEI> heis)
        {
            this.heis = heis;
        }

        public ICollection<HEI> Filter(BaseFilter filter)
        {
            var result = filter.Filter(heis);
            return result;
        }
    }
}
