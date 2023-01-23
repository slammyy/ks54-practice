namespace Program3
{
    class Program
    {
        public static Random rand = new Random();
        public static int number = rand.Next(1000);

        static void CheckOdd()
        {
            Thread.Sleep(2000);

            if (number % 2 != 0)
            {
                Console.WriteLine("{0} is odd", number);
            }

            else
            {
                Console.WriteLine("{0} is even", number);
            }

        }

        static void CheckDivisionByThree()
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("{0} can be divided by 3", number);
            }

            else
            {
                Console.WriteLine("{0} can't be divided by 3", number);
            }
        }

        static void NotMain()
        {
            Thread FirstThread = new Thread(CheckOdd);
            FirstThread.Start();
            Thread SecondThread = new Thread(CheckDivisionByThree);
            SecondThread.Start();
        }
    }
}
