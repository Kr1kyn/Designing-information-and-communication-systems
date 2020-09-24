using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unified_State_System_of_Entrants.BLL.DTO;
using Unified_State_System_of_Entrants.DAL.Models;

namespace Unified_State_System_of_Entrants.BLL.Filters
{
    class FilterByTags : BaseFilter
    {
        private ICollection<string> tags;
        public FilterByTags(ICollection<string> tags)
        {
            this.tags = tags;
        }
        public override ICollection<HEI> Filter(ICollection<HEI> collection)
        {
            
            if (tags.Count != 0)
            {
                var newCollection = new List<HEI>();
                foreach (var tag in tags)
                {
                    var subCollectionHEIs = collection.Where(item => item.TagsForFilter.Contains(tag));
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
