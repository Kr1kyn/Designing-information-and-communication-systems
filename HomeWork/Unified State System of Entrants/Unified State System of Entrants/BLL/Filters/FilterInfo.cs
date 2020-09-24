using System;
using System.Collections.Generic;
using System.Text;

namespace Unified_State_System_of_Entrants.BLL.Filters
{
   public class FilterInfo
   {
        public ICollection<string> tagsForFilter { get; set; }
        public ICollection<string> cictiesForFilter { get; set; }
   }
}
