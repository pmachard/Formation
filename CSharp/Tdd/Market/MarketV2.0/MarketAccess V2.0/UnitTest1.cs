using NUnit.Framework;

namespace Market.Access.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MarketAccessUnitTestNew()
        {

            IMarket market = new Market("Euronext");
            Assert.True(market.Open());

            Instrument instr = market.getInstrument();

            string way = "BUY";
            double price = 10.30;
            int quantity = 1000;

            Order instOrder = market.CreateOrder(instr, way, price, quantity);
        }
    }
}