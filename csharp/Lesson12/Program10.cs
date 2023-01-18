namespace Program10
{
  delegate double MyDelegate(double x); 
   
  class Program 
  { 
      static MyDelegate method(double a, double b, double c) 
      { 
          return x => a * x * x + b * x + c; 
      } 

      static  void Main() 
      { 
          Console.WriteLine(method(5, 7, 10)); 
      } 
  }
}
