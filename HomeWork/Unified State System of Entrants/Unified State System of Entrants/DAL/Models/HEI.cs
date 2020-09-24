using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Unified_State_System_of_Entrants.DAL.Interfaces;

namespace Unified_State_System_of_Entrants.DAL.Models
{
    public class HEI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string LocationsJson
        {
            get { return JsonConvert.SerializeObject(this.Locations); }
            set { this.Locations = JsonConvert.DeserializeObject<string[]>(value); }
        }
        [NotMapped]
        public string[] Locations { get; set; }
        public string TagsForFilterJson
        {
            get { return JsonConvert.SerializeObject(this.TagsForFilter); }
            set { this.TagsForFilter = JsonConvert.DeserializeObject<string[]>(value); }
        }
        [NotMapped]
        public string[] TagsForFilter { get; set; }
        public string InformationLinksJson
        {
            get { return JsonConvert.SerializeObject(this.InformationLinks); }
            set { this.InformationLinks = JsonConvert.DeserializeObject<string[]>(value); }
        }
        [NotMapped]
        public string[] InformationLinks { get; set; }
    }
}
