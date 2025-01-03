// See https://aka.ms/new-console-template for more information
namespace StaticInstance
{
    public class Program
    {
        static void Main(String[] args)

        {
            Circle1 circles = new Circle1(12);
            circles.Add();
            Circle1 circless = new Circle1(12);
            //circles.update();
            Circle1.update();
            Circle1.update();
            Circle circle = new Circle(12);
            float Area = circle.Area();
            Console.WriteLine(Area);
            Circle circle2 = new Circle(5);
            float Area1 = circle2.Area();
            Console.WriteLine(Area1);
            Console.ReadLine();
        }
    }
    public class Circle
    {
        //instance members{
        float pi = 3.14F;
        int radius;
        public Circle(int _radius)
        {
            this.radius = _radius;
        }
        public float Area()
        {
            return pi * radius * radius;
        }
        //}
     
    }

    public class Circle1{
        static float pi ;
        int radius;

     static Circle1()
        {
            pi = 3.14F;
            Console.WriteLine("Static Constructor");
      
        }
        public Circle1(int _radius)
        {
            Console.WriteLine("instance Constructor");
            this.radius = _radius;
        }
        public void Add()
        {

        }
        public static void update()
        {

        }

        public float Area()
        {
            //return this.pi * radius * radius;
            return Circle1.pi * radius * radius;
        }
    }
}