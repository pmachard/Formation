using Market.Interface;

namespace Market.Implem
{
    // singleton
    public class Markets
    {
        public static IMarket NewMarcket(string marketName)
        {
            if (marketName == "Euronext")
            {
                return new Market(marketName);
            }
            return null;
        }
    }
}