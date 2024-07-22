using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class FilterDestinations
    {

        public static List<Destination> GetFilteredDestinations(List<Category> categories)
        {
            var query = from category in categories
                        from destination in category.Destinations
                        where destination.Duration < 100
                        select destination;

            return query.ToList();
        }
    }
    }
