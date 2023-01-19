namespace Program8
{
  class Program
  {
    unsafe static void NotMain()
    {
      int size = 2;
      int* arr = stackalloc int[2];
      int* pArr = arr;
      
      for (int i = 0; i < size; i++)
      {
        Console.WriteLine("Byte = {0}", pArr[i]);
      }
    }
  }
}
