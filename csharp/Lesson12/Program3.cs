namespace Program3
{
  delegate void Del(char symbol);

  class Program
  {
    static char asdf;

    static void Fdsa(char symbol)
    {
      asdf = symbol;
    }

    static readonly char[] array = { 'a', 's', 'd', 'f' };

    static void Main()
    {
      Del del = Fdsa;
      foreach (char l in array) del(l);
      Console.WriteLine(asdf);
      Console.ReadLine();
    }
  }
}
