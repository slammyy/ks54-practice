
namespace Program8
{
  class Program
  {
    unsafe static void Main()
    {
      int* variableIntAdressX;
      int* variableIntAdressY;
      int x = 10, y = 20;
 
      int[] nums = new int[2];

      variableIntAdressX = &x;
      variableIntAdressY = &y;

      variableIntAdressX[0] = 1;
      variableIntAdressX[-3] = 2;
      variableIntAdressX[-1] = 3;
      variableIntAdressX[-2] = 4;
      variableIntAdressY[0] = 1;
      variableIntAdressY[-3] = 2;
      variableIntAdressY[-1] = 3;
      variableIntAdressY[-2] = 4;

      for (int i = 0; i >= -3; i--)
      {
        Console.WriteLine(variableIntAdressX[i]);
        Console.WriteLine(variableIntAdressY[i]);
      }
    }
  }
}
