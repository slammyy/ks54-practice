// namespace Program5
// {
//   struct Structure
//   {
//     public int[] arr;
//     public Structure(int n)
//     {
//       Random rnd = new Random();
//       arr = new int[n];
//       for (int i = 0; i < n; i++)
//         arr[i] = rnd.Next(20);
//     }
//
//     public int returnMaxNumber()
//     {
//       int maxNumber = arr[0];
//       for (int i = 0; i < arr.Length; i++)
//         if (maxNumber < arr[i])
//           maxNumber = arr[i];
//       return maxNumber;
//     }
//
//     public string returnMinNumber()
//     {
//       int minNumber = arr[0];
//       for (int i = 0; i < arr.Length; i++)
//         if (minNumber > arr[i])
//           minNumber = arr[i];
//       return "Maximum number in array: " + minNumber;
//     }
//     
//     public string returnAvgNumber()
//     {
//       int sum = 0;
//       for (int i = 0; i < arr.Length; i++)
//         sum += arr[i];
//       return "Minimal number in array: " + sum / arr.Length;
//     }
//
//     public void returnArray()
//     {
//       Console.Write("Array: ");
//       for(int i = 0; i < arr[i]; i++)
//         Console.Write(arr[i] + " ");
//     }
//   }
//
//   class Program
//   {
//     static void Main()
//     {
//       Structure structure = new Structure(10);
//      structure.returnArray();
//      Console.WriteLine(structure.returnMaxNumber());
//      Console.WriteLine(structure.returnMinNumber());
//      Console.WriteLine(structure.returnAvgNumber());
//     }
//   }
// }
