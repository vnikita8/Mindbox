namespace hhTaskOne
{

    interface IGetArea // Для удобства на случай будущих улучшений
    {
        double getArea(); //получитьПлощадь
    }

    /*
     * Класс Triangle по заданию (по трём сторонам + проверка на прямоугольный)
     * Класс 
     * Класс Polygon - универсальное решение по точкам для любого многноугольника
     */
    public class Circle : IGetArea
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            if (radius < 0) { return -1; }
            return Math.PI * radius;
        }
    }


    public class Triangle : IGetArea
    {
        private double area;
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        
        public double getArea()
        {
            if (a < 0 || b < 0 || c < 0)
            {
                return -1;
            }
            double p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) + (p - b) * (p - c));
            return area;
        }

        public bool isRightTriangle() // Проверка на прямоугольный
        {
            if ((a*a == (b*b + c * c)) || (b * b == (a * a + c * c)) || (c * c == (b * b + a * a)))
            {
                return true;
            }
            return false;
        }
    }

    public class MyPoint //Для многоугольника
    {
        public double x;
        public double y;

        public MyPoint(double x, double y) {this.x = x; this.y = y;}
            }

    public class Polygon : IGetArea // Любой многоугольник по координатам точек
    {
        List<MyPoint> points = new List<MyPoint>();
        private double area;

        public void addPoint(MyPoint point) { points.Add(point);}

        public double getArea()
        {
            if (points.Count < 1) { return 0; }
            
            double abscises = 0;
            double ordinates = 0;
            for (int i = 0; i < points.Count-1; i++)
            {
                abscises += points[i].x * points[i+1].y;
                ordinates += points[i].y * points[i+1].x;
            }
            abscises += points[points.Count-1].x * points[0].y;
            ordinates += points[points.Count - 1].y * points[0].x;
            double area = (abscises - ordinates)/2;
            this.area = area;
            return area;
        }

        public override string? ToString() {return $"Площадь {points.Count}-угольника: {area}";}
    }
}
