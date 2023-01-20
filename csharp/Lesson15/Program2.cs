namespace Program2
{
    class Program
    {
        static void FirstThred()
        {
            int factorial = 6;

            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }

            Console.WriteLine("Factorial: " + Factorial(factorial));
        }

        static void SecondThread()
        {
            int doubleFactorial = 6;

            static int DoubleFactorial(int n) 
            { 
                if (n == 0 || n==1) 
                    return 1; 
                return n * DoubleFactorial(n - 2); 
            } 

            Console.WriteLine("DoubleFactorial: " + DoubleFactorial(doubleFactorial));
        }

        static void ThirdThread()
        {
            int fibonacci = 6;

            int Fibonacci(int n)
            {
                if (n == 0 || n == 1) return n;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            Console.WriteLine("Fibonacci: " + Fibonacci(fibonacci));
        }

        static void NotMain()
        {
            Thread FirstChildThread = new Thread(FirstThred);
            FirstChildThread.Start();
            Thread SecondChildThread = new Thread(SecondThread);
            SecondChildThread.Start();
            Thread ThirdChildThread = new Thread(ThirdThread);
            ThirdChildThread.Start();
        }

    }
}
