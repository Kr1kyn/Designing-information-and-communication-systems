using System;
using System.Collections.Generic;
using System.Text;

namespace Unified_State_System_of_Entrants.BLL.DTO
{
    public class HEI_DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Locations { get; set; }
        public string[] TagsForFilter { get; set; }
        public string[] InformationLinks { get; set; }
    }
}
