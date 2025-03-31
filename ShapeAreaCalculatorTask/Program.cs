namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon
            Console.WriteLine("0 for circle, 1 for triangle, 2 for rectangle, 3 for pentagon, 4 for octagon");
            string Useranswer = Console.ReadLine();
            if (Useranswer == "0")
            {
                Console.WriteLine("enter the radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"area is {areaOfCircle(radius)}");
            }
            else if (Useranswer == "1")
            {
                Console.WriteLine("enter base");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter height");
                double Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"area is {areaOfTriangle(Base, Height)}");
            }
            else if (Useranswer == "2")
            {
                Console.WriteLine("enter base");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter height");
                double Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"area is {areaOfRectangle(Base, Height)}");
            }
            else if (Useranswer == "3")
            {
                Console.WriteLine("enter length of 1 side");
                double Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter apothem");
                double Apothem = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"area is {areaOfPentagon(Length, Apothem)}");
            }
            else if (Useranswer == "4")
            {
                Console.WriteLine("enter length of 1 side");
                double Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"area is {areaOfOctagon(Length)}");
            }
            else 
            {
                Console.WriteLine("invalid option");
            }
        }
        static double areaOfCircle(double r)//Add the parameters
        {
            double area = r * r * 3.14;
            return area;
        }
        static double areaOfTriangle(double b, double h)//Add the parameters
        {
            double area = b * h / 2;
            return area;
        }
        static double areaOfRectangle(double b, double h)//Add the parameters
        {
            double area = b * h;
            return area;
        }
        static double areaOfPentagon(double l, double a)//Add the parameters
        {
            double area = l * a * 5 / 2;
            return area;
        }
        static double areaOfOctagon(double l)//Add the parameters
        {
            double area = 2 * l * l * (1 + Math.Sqrt(2));
            return area;
        }
    }
}
