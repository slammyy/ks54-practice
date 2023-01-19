namespace Program11
{
  class Program
  {
    unsafe static void NotMain()
    {
      int number;
      char** ppSymbol;
      char* pSymbol = (char*)(&number);
      ppSymbol = &pSymbol;
      **ppSymbol = 'A';
      *(*ppSymbol + 1) = 'B';
      Console.WriteLine("Number = " + number);
    }
  }
}
