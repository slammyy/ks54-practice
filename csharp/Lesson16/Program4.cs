namespace Program4
{
    class Program
    {
        static void NotMain()
        {
            Person<int> person = new Person<int>(16);
            Console.WriteLine("Propety value before change: {0}", person.Age);
            person.Age = 18;
            Console.WriteLine("Propety value after change: {0}", person.Age);
        }
    }


    class Person<X>
    {
        private X age;
        public X Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(X a)
        {
            age  = a;
        }
    }
}

