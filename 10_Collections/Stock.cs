using System;

namespace _10_Collections
{
    internal class Stock : IAsset
    {
        private string symbol;
        public string Symbol
        {
            set
            {
                symbol = value;
            }
            get
            {
                return symbol;
            }
        }

        private double pricepershare;
        public double PricePerShare
        {
            set
            {
                pricepershare = value;
            }
            get
            {
                return pricepershare;
            }
        }

        private int numshares;
        public int NumShares
        {
            set
            {
                numshares = value;
            }
            get
            {
                return numshares;
            }
        }

        public int Id;

        public string GetSymbol()
        {
            return Symbol;
        }

        public double GetValue()
        {
            return PricePerShare * NumShares;
        }

        public static double TotalValue(IAsset[] stocks)
        {
            double result = 0;
            for (int i = 0; i < stocks.Length; i++)
            {
                result = result + stocks[i].GetValue();
            }
            return result;
        }

        public override string ToString()
        {
            return "Stock[symbol="+Symbol+",pricePerShare="+PricePerShare+",numShares="+NumShares+"]";
        }

        public bool Equals(Stock comparison)
        {
            if (Symbol == comparison.Symbol && PricePerShare == comparison.PricePerShare && NumShares == comparison.NumShares)
            {
                return true;
            }
            else
                return false;
        }

        public Stock(string type, double pps, int nums)
        {
            Symbol = type;
            PricePerShare = pps;
            NumShares = nums;
        }
        public Stock()
        {

        }
    }
}