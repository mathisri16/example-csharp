
using C_sharp;


namespace cSharp
{
    


    class program:student
    {
        // Inheritance is a mechanism in which one class 
        // acquires the property of another class

        // Using inheritance , you can create a general class
        // that defines traits common to a set of related items.


        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.height= 10;
            rect.width = 7;
            rect.shapeName = "Rectangle";
            rect.printDimension();
            rect.Area(); 
            
         
            Triangle triangle = new Triangle();
            triangle.height = 20;
            triangle.width = 5;
            triangle.shapeName = "Triangle";
            triangle.printDimension();
            triangle.Area();
            Console.ReadKey();

            student s = new student();
            s.ID = 1;
            s.Name = "test";
            Console.WriteLine($"id:{s.ID} name:{s.Name}");

            //Calculator calcobject = new Calculator();
            //calcobject.add(10, 10);
            //calcobject.add(3.4, 7.5);

            //Shape sqaureshape= new Shape(10);
            //Shape rectangleshape = new Rectangle(10,6);

            //sqaureshape.Area();
            //rectangleshape.Area();

           // System.Console.ReadKey();   


        }

        public class Shape//base class
        {
            public int height;
            public int width;
            public string shapeName;

            public void printDimension()
            {
                Console.WriteLine(shapeName+ " width is : " + width + " And Height is : " +height);
            }
        }

        public class Rectangle : Shape//derived class
        {

            public void Area()
            {
                Console.WriteLine("Area of Rectangle is :" + height * width);
            }
        }
        public class Triangle : Shape//derived class
        {

            public void Area()
            {
                Console.WriteLine("Area of Triangle is :" + (height * width /2));
            }
        }
    

        //class Calculator
        //{
        //    public int add(int x, int y)
        //    {
        //        return x + y;
        //    }

        //    public double add(double x, double y)
        //    {
        //        return x + y;
        //    }
        //}

        //class shape
        //{
        //    public virtual double Area()
        //    {
        //        return 0.0;
        //    }
        //}
        
        //class square:shape
        //{
        //    double a;

        //    public square(double a)
        //    {
        //        this.a = a;
        //    }   

        //    public override double Area()
        //    {

        //        System.Console.WriteLine("square area called..");
        //         return a*a;
        //    }


        //}

      // class p
    }
}

