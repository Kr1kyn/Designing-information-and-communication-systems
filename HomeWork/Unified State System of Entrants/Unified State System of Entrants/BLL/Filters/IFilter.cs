using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Filters
{
    public interface IFilter
    {
        public ICollection<HEI> Filter(ICollection<HEI> collection);
        public IFilter SetNext(IFilter filter);
    }
}
