using NUnit.Framework;

namespace PolymorphismeTest
{
    public class Figure
    {
        protected double _h, _w;
        public Figure(double h, double w)
        {
            _h = h;
            _w = w;
        }
        public virtual double ComputeArea() => -1.0;
    }
    public class Point : Figure
    {
        public Point() : base(0.0, 0.0) { }
    }
    public class Circle : Figure
    {
        public Circle(double r) : base(r, r) { }
        public override double ComputeArea() => 2.0 * _h * 3.14159;
    }
    public class Rectangle : Figure
    {
        public Rectangle(double h, double w) : base(h, w) { }
        public override double ComputeArea() => _h * _w;
    }
    public class Square : Rectangle
    {
        public Square(double w) : base(w, w) { }
        public override double ComputeArea() => base.ComputeArea();
    }

    public class TestUnitPolymorphism
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreatCircle()
        {
            Figure f = new Circle(1.0f);
            Assert.IsNotNull(f);
        }

        [Test]
        public void TestCreatRectangle()
        {
            Figure f = new Rectangle(1.0f,2.0f);
            Assert.IsNotNull(f);
        }

        [Test]
        public void TestCreatSqare()
        {
            Figure f = new Square(1.0f);
            Assert.IsNotNull(f);
        }

        [Test]
        public void TestCreatePoint()
        {
            Figure f = new Point();
            Assert.IsNotNull(f);
        }
    }
}

