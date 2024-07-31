using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

                        //=============== Data Structures - Collections in C# ===============//
                        //==================================================================//


            // 1. Array
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            string[] fruits = { "Apple", "Banana", "Orange" };
            // Arrays have fixed size after initialization
            // Accessing elements:
            Console.WriteLine(numbers[2]); // Output: 3
            Console.WriteLine(fruits[0]); // Output: Apple

            // Arrays are useful for fixed collections of elements where the size is known in advance
            // They provide fast, index-based access but are inflexible for resizing



            //================================================================================================//

            // 2. ArrayList
            ArrayList mixed = new ArrayList();
            mixed.Add(10);
            mixed.Add("Hello");
            // ArrayList can store elements of different types, but this reduces type safety
            Console.WriteLine(mixed[1]); // Output: Hello
                                         // Casting is required when retrieving elements
            int num = (int)mixed[0];
            Console.WriteLine(num); // Output: 10

            // ArrayList is largely obsolete in modern C# due to the introduction of generics


            //================================================================================================//

            // 3. List<T>
            List<string> names = new List<string> { "Alice", "Bob" };
            names.Add("Charlie");
            Console.WriteLine(names.Count); // Output: 3
                                            // List<T> provides type safety and doesn't require casting
            string secondName = names[1];
            Console.WriteLine(secondName); // Output: Bob

            // List<T> is the go-to collection for most scenarios requiring a dynamic array


            //================================================================================================//

            // 4. LinkedList<T>
            LinkedList<int> linkedNumbers = new LinkedList<int>();
            linkedNumbers.AddLast(5);
            linkedNumbers.AddFirst(1);
            linkedNumbers.AddAfter(linkedNumbers.First, 3);

            foreach (int value in linkedNumbers)
            {Console.Write(value + " ");}                     
                                  
            Console.WriteLine(); // Output: 1 3 5 

            // LinkedList<T> is ideal for scenarios with frequent insertions and deletions



            //================================================================================================//

            // 5. Stack<T>
            Stack<string> books = new Stack<string>();
            books.Push("Book1");
            books.Push("Book2");
            Console.WriteLine(books.Pop()); // Output: Book2
            Console.WriteLine(books.Peek()); // Output: Book1

            // Stacks are used in algorithms that require LIFO behavior
            // Common in undo mechanisms, parsing expressions, and managing function calls



            //================================================================================================//

            // 6. Queue<T>
            Queue<int> orders = new Queue<int>();
            orders.Enqueue(101);
            orders.Enqueue(102);
            Console.WriteLine(orders.Dequeue()); // Output: 101
            Console.WriteLine(orders.Peek()); // Output: 102

            // Queues are essential in scenarios requiring FIFO behavior
            // Used in task scheduling, breadth-first search, and handling asynchronous operations



            //================================================================================================//

            // 7. Hashtable
            Hashtable ages = new Hashtable();
            ages["Alice"] = 30;
            ages["Bob"] = 25;
            Console.WriteLine(ages["Alice"]); // Output: 30

            // Hashtable is a non-generic key-value collection
            // It's less commonly used in modern C# due to lack of type safety



            //================================================================================================//

            // 8. Dictionary<TKey, TValue>
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores["Player1"] = 100;
            scores["Player2"] = 85;
            Console.WriteLine(scores["Player1"]); // Output: 100

            // Dictionary<TKey, TValue> provides fast lookup based on unique keys
            // It's widely used for caching, counting occurrences, and mapping relationships

        }

    }
}