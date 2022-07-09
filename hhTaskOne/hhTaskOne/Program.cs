namespace hhTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверка на многоугольник
            Polygon figure = new Polygon();
            figure.addPoint(new MyPoint(5, 7));
            figure.addPoint(new MyPoint(1, 1));
            figure.addPoint(new MyPoint(-4, 2));
            figure.addPoint(new MyPoint(-1, -4));
            figure.addPoint(new MyPoint(4, -3));
            figure.getArea();
            Console.WriteLine(figure.ToString());
            //Круг
            Circle circle = new Circle(10);
            Console.WriteLine(circle.getArea());
            //Треугольник
            Triangle triangle = new Triangle(3,4,5); // цифры для True проверки
            Console.WriteLine(triangle.getArea());
            Console.WriteLine(triangle.isRightTriangle());
        }
    }

}
