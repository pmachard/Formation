using Market.Interface;

namespace Market.Implem
{
    public class Market : IMarket
    {
        public Market(string marketName)
        {
            MarketName = marketName;
        }

        public string MarketName { get; private set; }


        public bool Open() 
        {
            return true;
        }

        public IInstrument GetInstrument(string instName)
        {
            return null;
        }

        public IOrder CreateOrder(IInstrument inst, string way, double price, double quantity)
        {
            throw new System.NotImplementedException();
        }

        public bool ExecOrder(IOrder order)
        {
            throw new System.NotImplementedException();
        }
    }
}