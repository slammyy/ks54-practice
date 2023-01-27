namespace Program6
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
            }

            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.WriteLine("Type of error: " + e.GetType().Name);
                Console.WriteLine("Error discription: " + e.Message);
                Console.WriteLine("In program: " + e.Source);
                Console.ResetColor();
            }

            Console.Write("\nPress any key to exit the program...");
            Console.ReadKey();
        }

        static void checkForNumberInArray(int[] arr, int number)
        {
            try
            {
                // show index of number
                for (int i = 0; i < 10; i++)
                {
                    if (number == arr[i])
                    {
                        Console.WriteLine("Index of a number: {0}", i + 1);
                        break;
                        throw new ArithmeticException("There is no such number in array");
                    }
                }
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
