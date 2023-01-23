namespace Program8
{
    class Program
    {
        static int[,] array;
        static int rows;
        static int cols;
        static Thread[] threads;

        static void NotMain()
        {
            rows = 5;
            cols = 5;
            array = new int[rows, cols];
            threads = new Thread[rows];

            for (int i = 0; i < rows; i++)
            {
                int row = i;
                threads[i] = new Thread(() => FillArray(row));
                threads[i].Start();
            }

            for (int i = 0; i < rows; i++)
            {
                threads[i].Join();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void FillArray(int row)
        {
            for (int j = 0; j < cols; j++)
            {
                if (row % 2 == 0)
                    array[row, j] = (int)Math.Pow(2, j);
                else
                    array[row, j] = (int)Math.Pow(3, j);
            }
        }
    }
}
