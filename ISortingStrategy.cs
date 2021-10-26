using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    interface ISortingStrategy
    {
        IEnumerable<double> SortCollection(IEnumerable<double> list);
    }

    class SortAscending : ISortingStrategy
    {
        public IEnumerable<double> SortCollection(IEnumerable<double> list)
        {
            return list.OrderBy(x => x);
        }
    }

    class SortDescending : ISortingStrategy
    {
        public IEnumerable<double> SortCollection(IEnumerable<double> list)
        {
            return list.OrderByDescending(x => x);
        }
    }
}
