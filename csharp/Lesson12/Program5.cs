namespace Practic5
{
  delegate int Del(int arg); 
  internal class Program 
  { 
    private int In1(int n) 
    { 
      return n * 1; 
    } 
    private int In2(int n) 
    { 
      return n * n; 
    } 
    private int In3(int n) 
    { 
      return n * n * n; 
    } 
    public Del this[int n] 
    { 
      get 
      { 
        switch (n)
        {
          case 1:
            return In1;
          case 2:
            return In2;
          case 3:
            return In3;
          default:
            return In1;
        }
      } 
    } 
  } 
}
