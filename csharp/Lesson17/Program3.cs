namespace Program3
{
    class Program
    {
        static void NotMain()
        {
            try
            {
                Console.Write("Enter first number: ");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                if (firstNum >= secondNum)
                    Console.WriteLine("Remainder of the devision is {0}",
                            firstNum % secondNum);

                else
                    Console.WriteLine("Remainder of the devision is {0}",
                            secondNum % firstNum);
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
