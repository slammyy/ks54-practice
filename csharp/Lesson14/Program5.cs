namespace Program5
{
  unsafe class Program
  {
    unsafe static void NotMain()
    {
      var rand = new Random();
      int* pVariable;
      int variable = rand.Next(100, 1000);
      pVariable = &variable;

      char* z = (char*)pVariable;

      Console.WriteLine("Cycle before shift: ");
      Console.WriteLine("First byte: {0}", pVariable[0]);
      Console.WriteLine("Second byte: {0}", pVariable[-1]);
      Console.WriteLine("Third byte: {0}", pVariable[-2]);
      Console.WriteLine("Fourth byte: {0}", pVariable[-3]);

      for (int i = 0; i >= variable; i--)
      {
        pVariable[i] = pVariable[i - 1];
        Console.WriteLine(pVariable[i]);
      }
    }
  }
}
