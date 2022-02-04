using NUnit.Framework;

namespace TestUnit.Polymorphism.MethodParameter
{
    public class FigureRect
    {
        public double _h, _w;
        public FigureRect(double h, double w)
        {
            _h = h;
            _w = w;
        }

        public double Area()
        {
            return _h * _w;
        }

    }

    public class FigureCircle
    {
        public double _r;
        public FigureCircle(double r)
        {
            _r = r;
        }
    }

    public class TestUnitPolymorphism
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreatRectangleSimple()
        {
            FigureRect figRect = new FigureRect(1.0f, 2.0f);
            Assert.AreEqual(2.0, figRect.Area());

            FigureCircle figCircle = new FigureCircle(1.0f);
            Assert.AreEqual(2.0 * System.Math.PI , figRect.Area(),0.01);
        }
    }
}

