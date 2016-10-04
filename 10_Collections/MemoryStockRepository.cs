namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository
    {
        private long id;
        public MemoryStockRepository()
        {

        }
        public long NextId()
        {
            id++;
            return id;
        }
    }
}