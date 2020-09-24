using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.DTO
{
    public class RankedList_DTO
    {
        public int HEI_Id { get; set; }
        public ICollection<PositionRecord> TankedList { get; set; }
    }
}
