namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var sum = a + b;
            Console.WriteLine(a + "+" + b + " is " + sum);
            var sub = a - b;
            Console.WriteLine(a + "-" + b + " is " + sub);
            var mul = a * b;
            Console.WriteLine(a + "x" + b + " is " + mul);
            var div = a / b;
            Console.WriteLine(a + "/" + b + " is " + div);
            var modulo = a % b;
            Console.WriteLine(a + "%" + b + " is " + modulo);

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(a + "/" + b + " is " + quotient + " remainder " + remainder);

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle is {area}");

           
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI*radius*radius;

        }
           

        


    }

}
