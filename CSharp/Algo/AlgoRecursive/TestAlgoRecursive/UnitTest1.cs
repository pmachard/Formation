using NUnit.Framework;
using AlgoRecursive;


namespace TestAlgoRecursive
{
    public class TestAlgoRecursiveSequenceFibonacci
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FctShort()
        {
            Assert.AreEqual(0,SequenceFibonacci.fctShort(0));
            Assert.AreEqual(1, SequenceFibonacci.fctShort(1));
            Assert.AreEqual(1, SequenceFibonacci.fctShort(2));
            Assert.AreEqual(2, SequenceFibonacci.fctShort(3));
            Assert.AreEqual(3, SequenceFibonacci.fctShort(4));
            Assert.AreEqual(5, SequenceFibonacci.fctShort(5));
        }

        [Test]
        public void Fct()
        {
            Assert.AreEqual(0, SequenceFibonacci.fct(0));
            Assert.AreEqual(1, SequenceFibonacci.fct(1));
            Assert.AreEqual(1, SequenceFibonacci.fct(2));
            Assert.AreEqual(2, SequenceFibonacci.fct(3));
            Assert.AreEqual(3, SequenceFibonacci.fct(4));
            Assert.AreEqual(5, SequenceFibonacci.fct(5));
        }
    }
}