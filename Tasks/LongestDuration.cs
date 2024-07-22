using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class LongestDuration
    {
        public static Destination GetLongestDurationDestination(List<Category> categories)
        {
            var query = (from category in categories
                         from destination in category.Destinations
                         orderby destination.Duration descending
                         select destination).First();

            return query;
        }
    }
}
