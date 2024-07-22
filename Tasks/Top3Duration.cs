using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class Top3Duration
    {
        public static List<Destination> GetTop3DurationDestinations(List<Category> categories)
        { 
            //var query = (from category in categories
            //           from destination in category.Destinations
            //           orderby destination.duration descending 
            //           select destination).Take(3).ToList();
            
            return categories.SelectMany(c => c.Destinations)
                             .OrderByDescending(d => d.Duration)
                             .Take(3)
                             .ToList();
        }
    }
}
