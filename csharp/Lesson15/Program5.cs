namespace Program5
{
    class Program
    {
        static int[] arr = new int[10];
        static object _lock = new object();

        static void PowersOfTwo()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                lock (_lock)
                {
                    arr[i] = (int)Math.Pow(2, i);
                }
            }
        }

        static void PowersOfThree()
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                lock (_lock)
                {
                    arr[i] = (int)Math.Pow(3, i);
                }
            }
        }

        static void NotMain(string[] args)
        {
            Thread thread1 = new Thread(PowersOfTwo);
            thread1.Start();

            Thread thread2 = new Thread(PowersOfThree);
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Array: " + string.Join(", ", arr));
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
