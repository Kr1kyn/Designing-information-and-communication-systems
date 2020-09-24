using System;
using System.Collections.Generic;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Interfaces;

namespace Unified_State_System_of_Entrants.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
    }
}
