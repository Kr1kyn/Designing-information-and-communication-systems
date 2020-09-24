using System;
using System.Collections.Generic;
using System.Text;

namespace Unified_State_System_of_Entrants.BLL.DTO
{
    public class User_DTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
    }
}
