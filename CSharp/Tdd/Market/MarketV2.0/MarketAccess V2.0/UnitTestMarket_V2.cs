using NUnit.Framework;

namespace Market.Access.UnitTest
{
    public class UnitTestMarket_V2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateOrder()
        {

            IMarket market = new Market("Euronext");
            Assert.True(market.Open());

            IInstrument instr = market.getInstrument();
            IOrder instOrder = market.CreateOrder(instr, "BUY", 10.350,1000);
        }
    }
}