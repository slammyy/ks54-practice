namespace Program4
{
  delegate char Del();

  class Program
  {
    public readonly string text;
    private Del n;

    public Del nc => n;
    public Program(string line, bool boolean)
    {
      text = line;

      if (boolean)
      {
        n = () => line[line.Length - 1];
      }

      else
      {
        n = () => line[0];
      }

      return;
    }

    static void Main()
    {
      Program pr = new Program("asdf", true);
      Program prTwo = new Program("asdf", false);
      Console.WriteLine("True " + pr.nc());
      Console.WriteLine("False " + prTwo.nc());
      Console.ReadLine();
    }
  }
}
