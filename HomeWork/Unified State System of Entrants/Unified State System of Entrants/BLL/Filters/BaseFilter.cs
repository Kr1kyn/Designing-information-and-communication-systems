using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Filters
{
    abstract class BaseFilter : IFilter
    {
        private IFilter _nextFilter;

        public IFilter SetNext(IFilter filter)
        {
            _nextFilter = filter;
            return filter;
        }

        public virtual ICollection<HEI> Filter(ICollection<HEI> collection)
        {
            if (_nextFilter != null)
            {
                return _nextFilter.Filter(collection);
            }
            else
            {
                return null;
            }
        }
    }
}
