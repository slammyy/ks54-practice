namespace Program6
{
  struct Struct
  {
    public char symbol;
    public int number;

    public void Show()
    {
      Console.WriteLine("Symbol: {0}\nNumber: {1}", symbol, number);
    }

  }

  class Program
  {
    unsafe static void notMain()
    {
      Struct copy;
      Struct* pStruct;
      pStruct = &copy;

      pStruct->symbol = 'a';
      pStruct->number = 14;
      pStruct->Show();
    }
  }
}
