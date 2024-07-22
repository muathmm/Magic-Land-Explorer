using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class SortByName
    {
        public static List<Destination> GetSortedDestinations(List<Category> categories)
        {
            var query = from category in categories
                        from destination in category.Destinations
                        orderby destination.Name
                        select destination;
            return query.ToList();
        }
        //public static List<Destination> Fantasyland(List<Category> categories)
        //{
        //    var query = from category in categories
        //                from destination in category.Destinations
        //                where destination.Location == "Fantasyland"
        //                select destination;
        //    return query.ToList();
        //}
    }
}
