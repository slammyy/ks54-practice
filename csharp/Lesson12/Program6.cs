namespace Practic6
{
  delegate int Del();
  class Program
  {
    static int a = 9, b = 10, c;

    static Program()
    {
      Console.WriteLine(a);
      for (int i = 0; i <= 10; i++)
      {
        Console.WriteLine(b);
        c = b;
        b = b + a;
        a = c;
      }
    }

    static void Main()
    {
      Program pr = new Program();
      Console.WriteLine(pr);
      Console.ReadLine();
    }
  }
}
