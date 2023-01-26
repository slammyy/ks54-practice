namespace Program2
{
    class Program
    {
        static void NotMain()
        {
            try
            {
                Console.Write("Enter the size of array: ");
                int arraySize = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    Random rand = new Random();
                    int randomNum = rand.Next(0, 100);
                    arr[i] = randomNum;
                }

                Console.WriteLine("Randomly generated array: ");
                for (int i = 0; i < arraySize; i++)
                {
                    Console.Write("|" + arr[i]);
                }
                Console.WriteLine("|");
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
