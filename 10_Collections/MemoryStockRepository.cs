using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository
    {
        private List<IAsset> stocklist;
        private long id = 0;

        public List<IAsset> Stocklist
        {
            get
            {
                return stocklist;
            }

            set
            {
                stocklist = value;
            }
        }

        public MemoryStockRepository()
        {

        }
        public long NextId()
        {
            id++;
            return id;
        }

        public void SaveStock(Stock name)
        {
            name.Id = id;
            Stocklist.Add(name);
            NextId();
        }

        public Stock LoadStock(long id)
        {
            foreach (var item in Stocklist)
            {
                if (item.Id == id)
                return (Stock)item;
            }
            return null;
        }
    }
}