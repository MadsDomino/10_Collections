﻿namespace _10_Collections
{
    internal interface IStockRepository
    {
        long NextId();
        void SaveStock(Stock name);
        Stock LoadStock(long id);
    }
}