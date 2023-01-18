namespace Program2
{
  unsafe class Program
  {
    unsafe static void NotMain()
    {
      int* variableIntAdress;
      int variableInt = 228;
      variableIntAdress = &variableInt;


      variableIntAdress[0] = 1;
      variableIntAdress[-3] = 1;
      variableIntAdress[-1] = 'A';
      variableIntAdress[-2] = 'A';

      for (int i = 0; i >= -3; i--)
      {
        Console.WriteLine(variableIntAdress[i]);
      }
    }
  }
}
