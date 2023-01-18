namespace Program4
{
  unsafe class Program
  {
    unsafe static void NotMain()
    {
      var rand = new Random();
      int firstVar = rand.Next(20), secondVar = rand.Next(20), thirdVar;

      Console.WriteLine("firstVar\tsecondVar\tthirdVar");

      char* cFirstVar = (char*)&firstVar;
      char* cSecondVar = (char*)&secondVar;
      char* cThirdVar = (char*)&thirdVar;

      *cThirdVar = *cFirstVar;
      *(cThirdVar + 1) = *cSecondVar;
      
      Console.WriteLine("{0}\t{1}\t{2}", firstVar, secondVar, thirdVar);
    }
  }
}
