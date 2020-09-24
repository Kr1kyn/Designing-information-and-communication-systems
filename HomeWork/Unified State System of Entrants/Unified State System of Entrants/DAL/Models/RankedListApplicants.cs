using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Unified_State_System_of_Entrants.DAL.Models
{
    public class RankedListApplicants
    {
        public int Id { get; set; }
        public int HEI_Id { get; set; }
        [NotMapped]
        public ICollection<PositionRecord> TankedList { get; set; }

        public string TankedListJson
        {
            get { return JsonConvert.SerializeObject(this.TankedList); }
            set { this.TankedList = JsonConvert.DeserializeObject<ICollection<PositionRecord>>(value); }
        }
    }
}
