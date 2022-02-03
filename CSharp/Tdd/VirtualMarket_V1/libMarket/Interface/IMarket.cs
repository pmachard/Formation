namespace Market.Interface
{
    public interface IMarket
    {
        string MarketName { get; }

        bool Open();
        IInstrument GetInstrument(string instrName);
        IOrder CreateOrder(IInstrument inst, string way, double price, double quantity);
        bool ExecOrder(IOrder order);
    }
}