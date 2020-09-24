using System;
using System.Collections.Generic;
using System.Text;

namespace Unified_State_System_of_Entrants.BLL.DTO
{
    public class Entrant_DTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? SecondName { get; set; }
        public string Sex { get; set; }
        public string Citizenship { get; set; }
        public string IdentityDocument { get; set; }
        public string ResidentialAddress { get; set; }
        public string Phone { get; set; }
        public string About { get; set; }
    }
}
