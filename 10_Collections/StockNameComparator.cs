namespace _10_Collections
{
    internal class StockNameComparator
    {
        public double Compare (IAsset first, IAsset second)
        {

            if (first.GetSymbolLength() < second.GetSymbolLength())
            {
                return -1;
            }
            else if (first.GetSymbolLength() > second.GetSymbolLength())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}