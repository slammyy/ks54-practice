namespace Program11
{
  struct FirstStruct
  {
    public int number;

    public FirstStruct(int thisNumber)
    {
      number = thisNumber;
    }

    static public SecondStruct operator + (FirstStruct self, FirstStruct other)
    {
      return new SecondStruct(self.number, other.number);
    }

    public int show()
    {
      return number;
    }
  }

  struct SecondStruct
  {
    public int firstNumber, secondNumber;

    public SecondStruct(int thisFirstNumber, int thisSecondNumber)
    {
      firstNumber = thisFirstNumber;
      secondNumber = thisSecondNumber;
    }

    public string show()
    {
      return firstNumber + " " + secondNumber;
    }

    public FirstStruct[] methodB()
    {
      return new FirstStruct[2]
      {
        new FirstStruct(this.firstNumber),
        new FirstStruct(this.secondNumber)
      };
    }
  }

  class Program 
  {
    static void Main()
    {
      FirstStruct A1 = new FirstStruct(3);
      Console.WriteLine("Структура A1: " + A1.show());
      FirstStruct A2 = new FirstStruct(3);
      Console.WriteLine("Структура A2: " + A2.show());
      SecondStruct B = A1 + A2;
      Console.WriteLine("Структура B: " + B.show());
      SecondStruct B1 = new SecondStruct(10, 20);
      Console.WriteLine("Структура B1: " + B1.show());
      FirstStruct[] A3 = B1.methodB();
      Console.WriteLine("Структура A3[0]: " + A3[0].show());
      Console.WriteLine("Структура A3[1]: " + A3[1].show());

      Console.Write("\nPress any key to exit...");
      Console.ReadKey();
    }
  }
}
