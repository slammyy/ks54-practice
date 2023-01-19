namespace Program7
{
  class MyClass
  {
    public int number;
  }

  class Program
  {
    unsafe static void Main()
    {
      fixed (int* pNumber = &new MyClass().number)
      {
        char* s = (char*)pNumber;
        *s = 'A';
        *(s + 1) = 'B';
        Console.WriteLine("Number = " + (*pNumber));
      }
    }
  }
}
