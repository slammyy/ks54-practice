class MyClass
{
    public int[] intArray;
    public char[] charArray;

    public MyClass(int size)
    {
        intArray = new int[size];
        charArray = new char[size];
    }
}

class Program
{
    static MyClass obj;
    static object _lock = new object();

    static void FillIntArray()
    {
        Random rand = new Random();
        for (int i = 0; i < obj.intArray.Length; i++)
        {
            lock (_lock)
            {
                obj.intArray[i] = rand.Next();
            }
        }
    }

    static void FillCharArray()
    {
        Random rand = new Random();
        for (int i = 0; i < obj.charArray.Length; i++)
        {
            lock (_lock)
            {
                obj.charArray[i] = (char)rand.Next(65, 90);
            }
        }
    }

    static void NotMain(string[] args)
    {
        obj = new MyClass(10);

        Thread thread1 = new Thread(FillIntArray);
        thread1.Start();

        Thread thread2 = new Thread(FillCharArray);
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Int array: " + string.Join(", ", obj.intArray));
        Console.WriteLine("Char array: " + new string(obj.charArray));
        Console.Write("Press any key to exit...");
        Console.ReadLine();
    }
}
