using NUnit.Framework;
using UnitTestMarket.Mock;
using Market.Interface;
using Market.Implem;
using System.Collections.Generic;

namespace UnitTestMarket
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static readonly string _MarketEuronext = "Euronext";
        private static readonly string _Lse = "LSE";

        [Test]
        public void TestPlanOpenMarket()
        {
            IMarket market = Markets.NewMarcket(_MarketEuronext);
            Assert.NotNull(market);
            Assert.AreEqual(_MarketEuronext,market.MarketName);

            if (market.Open())
            {
            }
            else 
            {
                Assert.True(false);
            }
        }


        [Test]
        public void TestPlanExec()
        {
            IMarket market = Markets.NewMarcket(_MarketEuronext);

            if (market.Open())
            {
                IInstrument instSg = market.GetInstrument("societe general");
                Assert.NotNull(instSg);

                IBook bookSg = instSg.GetBook();
                Assert.NotNull(bookSg);

                double price = (bookSg.MinBuyPrice() + bookSg.MaxAskPrice()) / 2.0;
                double quantity = 1000.0;
                IOrder order = market.CreateOrder(instSg, "BUY", price, quantity);
                Assert.NotNull(order);

                market.ExecOrder(order);
            }
        }

        [Test]
        public void TestInstrumentBook()
        {
            IInstrument inst = new MockInstrument();
            string name = inst.Name;
            string cisin = inst.CodeIsin;
            int quotity = inst.Quotity;
        }
    }
}

