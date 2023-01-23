namespace Program9
{
    class Program
    {
        static char[,] arr;
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int rows = 10;
            int cols = 20;
            arr = new char[rows, cols];

            for (int i = 0; i < cols; i++)
            {
                int index = i;
                new Thread(() => FillColumn(index)).Start();
            }

            while (Thread.ActiveThreadsCount > 1)
            {
                Thread.Sleep(1000);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void FillColumn(int col)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i, col] = (char)rand.Next('A', 'Z');
            }
        }
    }   
}
