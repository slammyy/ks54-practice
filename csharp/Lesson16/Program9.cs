namespace Program9
{
    class Program
    {
        static void typeChecker<T>(T t)
        {
            if (t.GetType() == typeof(int))
                Console.WriteLine("The variable type is integer");
            else if (t.GetType() == typeof(char))
                Console.WriteLine("The variable type is char");
            else
                Console.WriteLine("The variable type is neither integer nor char");
        }

        static void Main()
        {
            int a = 10;
            char b = 'b';
            double c = 21.20;
            typeChecker<int>(a);
            typeChecker<double>(c);
            typeChecker<char>(b);
        }
    }
}
