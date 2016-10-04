using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockNameComparator : IComparer<IAsset>
    {
        public int Compare (IAsset first, IAsset second)
        {
            return first.GetSymbol().CompareTo(second.GetSymbol());
        }
    }
}