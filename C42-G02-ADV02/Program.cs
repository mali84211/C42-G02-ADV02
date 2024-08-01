using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C42_G02_ADV02
{
    internal class Program
    {
            public static void Reverse(ArrayList arrayList)
            {
                int left = 0;
                int right = arrayList.Count - 1;

                while (left < right)
                {
                    object temp = arrayList[left];
                    arrayList[left] = arrayList[right];
                    arrayList[right] = temp;

                    left++;
                    right--;
                }
            }

                public static List<int> GetEvenNumbers(List<int> inputList)
                {
                    List<int> evenNumbers = new List<int>();

                    foreach (int number in inputList)
                    {
                        if (number % 2 == 0)
                        {
                            evenNumbers.Add(number);
                        }
                    }

                    return evenNumbers;
                }
                static void Main(string[] args)
        {
            #region PART1
            //1.Array
            //    Structure:
            //    Linear data structure.
            //    Fixed size.
            //    Elements are stored in contiguous memory locations.
            //    Time Complexity:
            //    Access: O(1)
            //    Search: O(n)
            //    Insertion: O(n)(if inserted at the beginning or middle), O(1)(if inserted at the end)
            //    Deletion: O(n)(if deleted from the beginning or middle), O(1)(if deleted from the end)
            //    Business Case:
            //    Suitable for scenarios where the number of elements is known beforehand, and frequent access by index is required.
            //int[] numbers = new int[5];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //int num = numbers[1];

            //2.List < T >
            //      Structure:
            //      Dynamic array.
            //      Automatically resizes.
            //      Time Complexity:
            //      Access: O(1)
            //      Search: O(n)
            //      Insertion: O(1)(if at the end), O(n) (if inserting in the middle)
            //      Deletion: O(n)
            //      Business Case:
            //      Ideal for dynamic collections where the number of elements can change.
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(20);
            //int num = list[1];

            //3.LinkedList < T >
            //        Structure:
            //        Doubly linked list.
            //        Each element(node) contains data and references to the next and previous nodes.
            //        Time Complexity:
            //        Access: O(n)
            //        Search: O(n)
            //        Insertion: O(1)(if position is known)
            //        Deletion: O(1)(if position is known)
            //        Business Case:
            //        Useful for applications requiring frequent insertions and deletions.
            //    LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.AddFirst(10);
            //linkedList.AddLast(20);
            //int firstElement = linkedList.First.Value;

            //4.Stack < T >
            //        Structure:
            //        Linear data structure.
            //        Follows LIFO(Last In, First Out) principle.
            //        Time Complexity:
            //        Access: O(n)
            //        Search: O(n)
            //        Insertion: O(1)
            //        Deletion: O(1)
            //        Business Case:
            //        Suitable for scenarios like undo operations, function call management, and balancing symbols.
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //int element = stack.Pop();

            //5.Queue < T >
            //        Structure:
            //        Linear data structure.
            //        Follows FIFO(First In, First Out) principle.
            //        Time Complexity:
            //        Access: O(n)
            //        Search: O(n)
            //        Insertion: O(1)
            //        Deletion: O(1)
            //        Business Case:
            //        Ideal for scheduling tasks and managing requests in web servers.
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //int element = queue.Dequeue();

            //6.Dictionary < TKey, TValue >
            //            Structure:
            //            Key - value pair data structure.
            //            Uses a hash function to compute the index into an array of buckets.
            //            Time Complexity:
            //            Access: O(1) on average
            //            Search: O(1) on average
            //            Insertion: O(1) on average
            //            Deletion: O(1) on average
            //            Business Case:
            //            Efficient for lookups and insertions by key.
            //            Suitable for implementing caches, dictionaries, and databases.
            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //dictionary["Alice"] = 30;
            //dictionary["Bob"] = 25;
            //int age = dictionary["Alice"];
            #endregion

            #region PART2 -1
            ArrayList arrayList = new ArrayList { 10, 20, 30, 40, 50 };
            Console.WriteLine("Original ArrayList:");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }

            Reverse(arrayList);

            Console.WriteLine("\nReversed ArrayList:");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            #endregion
            Console.WriteLine("\n======================");
            #region 2
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = GetEvenNumbers(numbers);

            Console.WriteLine("Original List:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\nEven Numbers List:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            #endregion
            Console.WriteLine("\n======================");
            #region 3
            try
            {
                FixedSizeList<int> list = new FixedSizeList<int>(5);

                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(4);
                list.Add(5);

                Console.WriteLine("List elements:");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list.Get(i));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            #endregion
        }






    }
}
