namespace Program2
{
    class Program
    {
        static void NotMain()
        {
            int firstNum = 6, secondNum = 9;
            Swap(firstNum, secondNum);
        }

        static void Swap<T>(T firstArg, T secondArg)
        {
            Console.WriteLine("Nums before swap");
            Console.WriteLine("First arg: " + firstArg + "\nSecond arg: " + secondArg);

            (firstArg , secondArg) = (secondArg, firstArg);

            Console.WriteLine("\nNums after swap");
            Console.WriteLine("First arg: " + firstArg + "\nSecond arg: " + secondArg);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
