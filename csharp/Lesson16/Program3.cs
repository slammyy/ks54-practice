namespace Program3
{
    class Program
    {
        static void NotMain()
        {
            int[] arr = { 4, 9, 1, 0, 2, 5 };
            showOrig(arr);
            showMod(arr);
        }

        static void showOrig<T>(T[] arr)
        {
            Console.WriteLine("Original array:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("|" + arr[i]);
            }
            Console.WriteLine("|");
        }

        static void showMod<T>(T[] arr)
        {
            Console.WriteLine("Modificated array:");

            for (int i = 0; i <= arr.Length + 1; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write("|" + arr[0]);
                    break;
                }
                else
                    Console.Write("|" + arr[i + 1]);

            }
            Console.WriteLine("|");
        }
    }
}
