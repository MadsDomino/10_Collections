﻿using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Collections;

namespace _10_Collections
{
    internal class Portfolio
    {
        private List<IAsset> stocks = new List<IAsset>();

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public Portfolio() { }

        public double GetTotalValue()
        {
            double result = 0;
            for (int i = 0; i < stocks.Count; i++)
            {
                result = result + stocks[i].GetValue();
            }
            return result;
        }

        public void AddAsset(IAsset stocks)
        {
            this.stocks.Add(stocks);
        }

        public IList<IAsset> GetAssets()
        {
            return stocks.AsReadOnly();
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            IComparer<IAsset> compare = new StockNameComparator();
            stocks.Sort(compare);
            return stocks;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            IComparer<IAsset> compare = new StockValueComparator();
            stocks.Sort(compare);
            return stocks;
        }

        public IAsset GetAssetByName(string name)
        {
            for (int i = 0; i < stocks.Count; i++)
            {
                if (stocks[i].GetSymbol() == name)
                {
                    return stocks[i];
                }
            }
            return null;
        }
    }
}