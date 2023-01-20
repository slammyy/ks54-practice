namespace Program3
{
    class Program
    {
        static void CheckOdd(int number)
        {
            string returner = number % 2 != 0 ? "Number is odd" : "Number is even";
            if (number % 2 != 0)
                return "Number is odd";
            else
                return "Number is even";
        }

        static void CheckThreeDivision(int number)
        {
            string returner = number % 3 == 0 ? "Number can be divided by 3" : "Number can't be divided by 3";
        }
    }
    
}
