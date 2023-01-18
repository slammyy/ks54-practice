namespace Program3
{
  unsafe class Program
  {
    unsafe static void NotMain()
    {
      double* variableAdress;
      double variable = 1337228;
      variableAdress = &variable;

      variableAdress[0] = 1;
      variableAdress[-1] = 'A';
      variableAdress[-2] = 'A';
      variableAdress[-3] = 2;
      variableAdress[-4] = 2;
      variableAdress[-5] = 2;
      variableAdress[-6] = 2;
      variableAdress[-7] = 3;

      for (int i = 0; i >= -7; i--)
      {
        Console.WriteLine(variableAdress[i]);
      }
    }
  }
}
