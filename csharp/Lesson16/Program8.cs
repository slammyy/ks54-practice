// namespace Program8
// {
//     class Program
//     {
//         static void sorter<T>(T[] inputArray) where T : IComparable;
//         {
//             T[] outputArray = new T[inputArray.Length];
//             T min = inputArray.Min();
//             T max = inputArray.Max();
// 
//             for(int i = 0; i < inputArray.Length; i++)
//             {
//                 outputArray[i] = inputArray[i];
//             }
// 
//             while (outputArray[0].CompareTo(min) != 0)
//             {
//                 for (int i = 0; i < inputArray.Length - 1; i++)
//                 {
//                     if (outputArray[i].CompareTo(outputArray[i + 1]) > 0)
//                     {
//                         T tmp = outputArray[i];
//                         outputArray[i] = outputArray[i + 1];
//                         outputArray[i + 1] = tmp;
//                     }
//                 }
//             }
// 
//             for (int i = 0; i < outputArray.Length; i++)
//             {
//                 Console.WriteLine("The {0} value in sorted array is {1}", i outputArray[i]);
//             }
//         }
//         
//         static void NotMain()
//         {
//             int[] randomArray = new int[20];
//             Random rand = new Random();
//             for (int i = 0; i < randomArray.Length; i++)
//             {
//                 randomArray[i] = rand.Next(1, 100);
//             }
// 
//             sorter<int>(randomArray);
//         }
//     }
// }
