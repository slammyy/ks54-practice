// namespace Program10
// {
//   struct Integers
//   {
//     public static int maxNumber, indexNumber;
//     public Integers(int thisMaxNumber, int thisIndexNumber)
//     {
//       maxNumber = thisMaxNumber;
//       indexNumber = thisIndexNumber;
//     }
//     public static void ReturnIntegers()
//     {
//       Console.WriteLine("Максимальное число в массиве: {0}", Integers.maxNumber);
//       Console.WriteLine("Индекс максимального числа в массиве: {0}", Integers.indexNumber);
//     }
//   }
//
//   class Program
//   {
//     static void Main()
//     {
//       int[] arr = new int[] {3, 5, 1, 23, 6, 76, 9, 0};
//
//       for (int i = 1; i < arr.Length; i++)
//       {
//         if (arr[i - 1] < arr[i])
//         {
//           Integers.maxNumber = arr[i];
//           Integers.indexNumber = i;
//         }
//       }
//       Integers.ReturnIntegers();
//     }
//   }
// }
