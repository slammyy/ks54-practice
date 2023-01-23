namespace Program4
{
    class Program
    {
        static char[] arr = new char[10];
        static Random random = new Random();
        static object _lock = new object();

        static void EvenIndex()
        {
            for (int i = 0; i < arr.Length; i += 2)
            {
                lock (_lock)
                {
                    arr[i] = (char)('a' + random.Next(0, 26));
                }
            }
        }

        static void OddIndex()
        {
            for (int i = 1; i < arr.Length; i += 2)
            {
                lock (_lock)
                {
                    arr[i] = (char)('а' + random.Next(0, 33));
                }
            }
        }

        static void NotMain(string[] args)
        {
            Thread thread1 = new Thread(EvenIndex);
            thread1.Start();

            Thread thread2 = new Thread(OddIndex);
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Array: " + new string(arr));
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
