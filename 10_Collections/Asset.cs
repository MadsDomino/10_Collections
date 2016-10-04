namespace _10_Collections
{
    public interface IAsset
    {
        double GetValue();
        string GetSymbol();
        long Id { get; }
    }
}