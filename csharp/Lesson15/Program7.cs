namespace Program7
{
    class Program
    {
        static int[] array;
        static int max = int.MinValue;
        static int min = int.MaxValue;

        static void FindMax()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
        }

        static void FindMin()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
        }

        static void NotMain()
        {
            // Create the array
            array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // Start two child threads
            Thread t1 = new Thread(FindMax);
            Thread t2 = new Thread(FindMin);
            t1.Start();
            t2.Start();

            // Wait for both threads to finish
            t1.Join();
            t2.Join();

            // Print the results
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Minimum value: " + min);
        }
    }
}
