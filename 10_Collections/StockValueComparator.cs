using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset first, IAsset second)
        {
            return second.GetValue().CompareTo(first.GetValue());
        }
    }
}