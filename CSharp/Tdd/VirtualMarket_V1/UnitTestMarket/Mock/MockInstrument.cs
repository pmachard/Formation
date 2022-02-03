using System;
using System.Collections.Generic;
using Market.Interface;
using Market.Implem;

namespace UnitTestMarket.Mock
{
    class MockInstrument : IInstrument
    {
        public string Name { get; set; }
        public string CodeIsin { get; set; }
        public int Quotity { get; set; }

        public IBook GetBook()
        {
            return new Book();
        }
    }
}
