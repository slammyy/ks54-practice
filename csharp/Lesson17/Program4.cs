namespace Program4
{
    class Program
    {
        static void Main()
        {
            try
            {
                Random rand = new Random();
                int A = rand.Next(1, 26);
                int B = rand.Next(1, 26);

                while (B % A != 0 || (A == 0 || B == 0) || A > B)
                {
                    A = rand.Next(1, 26);
                    B = rand.Next(1, 26);
                }

                Console.WriteLine("Randomly generated A is {0}", A);
                Console.WriteLine("Randomly generated B is {0}", B);

                for (int i = 1; i < 25; i++)
                {
                    if (A * i == B)
                    {
                        Console.WriteLine("x is {0}", i);
                        break;
                    }
                }
            }

            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");

                Console.WriteLine("Type of error: " + e.GetType().Name);
                Console.WriteLine("Error discription: " + e.Message);
                Console.WriteLine("Program: " + e.Source);
                Console.ResetColor();
            }
            Console.Write("\nPress any key to exit the program...");
            Console.ReadKey();
        }
    }
}
