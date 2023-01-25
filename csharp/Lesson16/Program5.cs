namespace Program5
{
    class Program
    {
        class Person<T>
        {
            static T[] person = new T[5];
            public T this[int index]
            {
                get { return person[index]; }
                set { person[index] = value; } 
            }
        }

        static void NotMain()
        {
            Person<string> obj = new Person<string>();

            obj[0] = "Gregor";
            obj[1] = "Jim";
            obj[2] = "Tom";
            obj[3] = "Mary";
            obj[4] = "Josea";


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The name of person number {0} is {1}", i, obj[i]);
            }
        }
    }
}
