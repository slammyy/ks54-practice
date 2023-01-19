namespace Program10
{
  class Program
  {
    unsafe static void Main()
    {
      string text = "дед макар";

      fixed (char* p = text)
      {
        text = new string(text.Reverse().ToArray());
        Console.WriteLine(text);
      }
    }
  }
}
