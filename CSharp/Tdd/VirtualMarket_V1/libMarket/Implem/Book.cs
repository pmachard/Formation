namespace Market.Interface
{
    public class Book : IBook
    {
        public double MinBuyPrice()
        {
            return -1.0;
        }

        public double MaxAskPrice()
        {
            return -1.0;
        }
    }
}