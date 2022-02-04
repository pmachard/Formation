using NUnit.Framework;

namespace TestUnit.Polymorphism.InheritedMetod
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
        public void TestCreatRectangleSimple()
        {
            Rectangle figRectangle = new Rectangle(1.0f, 2.0f);
            Circle fiCircle= new Circle(10.0f);

            double fRect = figRectangle.ComputeArea();
            double fCircle = fiCircle.ComputeArea();
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

