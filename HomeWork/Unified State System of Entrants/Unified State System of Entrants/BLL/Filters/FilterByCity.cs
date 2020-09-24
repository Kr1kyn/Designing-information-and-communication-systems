using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Filters
{
    class FilterByCity :BaseFilter
    {
        private ICollection<string> cities;
        public FilterByCity(ICollection<string> cities)
        {
            this.cities = cities;
        }
        public override ICollection<HEI> Filter(ICollection<HEI> collection)
        {
            
            if (cities.Count != 0)
            {
                var newCollection = new List<HEI>();
                foreach (var city in cities)
                {
                    var subCollectionHEIs = collection.Where(item => item.Locations.Contains(city));
                    foreach (var hei in subCollectionHEIs)
                    {
                        if (!newCollection.Contains(hei))
                        {
                            newCollection.Add(hei);
                        }
                    }
                }
                return base.Filter(newCollection);
            }
            return collection;
        }
    }
}
