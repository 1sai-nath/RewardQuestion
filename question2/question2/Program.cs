namespace question2
{
    internal class Program
    {
        abstract class Shape
        {
            public string shapeName;

            public abstract double findArea();
            public abstract double findPerimeter();
        }

        class Circle : Shape
        {
            public double radius;

            public Circle(double r)
            {
                radius = r;
                shapeName = "Circle";
            }

            public override double findArea()
            {
                return 3.14 * radius * radius;
            }

            public override double findPerimeter()
            {
                return 2 * 3.14 * radius;
            }
        }

        class Rectangle : Shape
        {
            public double length, width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
                shapeName = "Rectangle";
            }

            public override double findArea()
            {
                return length * width;
            }

            public override double findPerimeter()
            {
                return 2 * (length + width);
            }
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
                Circle circle = new Circle(5);
                Console.WriteLine("Area of " + circle.shapeName + ": " + circle.findArea());
                Console.WriteLine("Perimeter of " + circle.shapeName + ": " + circle.findPerimeter());

                Rectangle rectangle = new Rectangle(5, 10);
                Console.WriteLine("Area of " + rectangle.shapeName + ": " + rectangle.findArea());
                Console.WriteLine("Perimeter of " + rectangle.shapeName + ": " + rectangle.findPerimeter());
            }
        }
    }
}