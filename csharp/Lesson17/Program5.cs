namespace Program5
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Input A: ");
                double A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input B: ");
                double B = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input C: ");
                double C = Convert.ToInt32(Console.ReadLine());
                double x1plus;
                double x2minus;
                x1plus = ((B * (-1)) + Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);
                x2minus = ((B * (-1)) - Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);
                if (x1plus.GetType() != typeof(double) || x2minus.GetType() != typeof(double))
                {
                    Console.WriteLine("The solution does not exist with current input");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey();
                }
                Console.WriteLine("Results: x1 = {0}, x2 = {1}", x1plus, x2minus);
            }

            catch (FormatException)
            {
                Console.WriteLine("Wrong input format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big or too small");
            }

            Console.Write("\nPress any key to exit the program...");
            Console.ReadKey();
        }
    }
}
