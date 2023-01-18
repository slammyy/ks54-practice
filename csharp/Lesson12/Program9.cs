// namespace Practic9
// {
//   delegate int Del(int i);
//   internal class Program
//   {
//     private static int ReturnedInt(int i)
//     {
//       return i * 2 - 2;
//     }
//
//     private static int[] Mathematics(Int32[] numbers, Del delegator)
//     {
//       int[] result = { };
//       for (int i = 0; i < numbers.Length; i++)
//       {
//         result[i] = delegator(numbers[i]);
//       }
//       return result;
//     }
//
//     public static void Main()
//     {
//       Del delegator = ReturnedInt;
//       int[] numbers = { 4, 2, 6 };
//       Mathematics(numbers, delegator);
//     }
//   }
// }
