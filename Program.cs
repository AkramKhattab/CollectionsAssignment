using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test your implementations here
        }


        #region Part1

        /* Collections Comparison

            [Array]
            Structure: Fixed-size contiguous memory block
            Use Case: Fixed-size data, frequent random access
            Example:
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            int thirdElement = numbers[2];
            int index = Array.IndexOf(numbers, 3);
            
            =====================================================
            
            [ArrayList]
            Structure: Resizable array (non-generic)
            Use Case: Dynamic size requirements, legacy code
            Example:
            ArrayList list = new ArrayList();
            list.Add("Apple");
            list.Add("Banana");
            list.Insert(1, "Cherry");
            list.Remove("Banana");
            string item = (string)list[0];
            
            =====================================================
            
            [List<T>]
            Structure: Generic resizable array
            Use Case: Type-safe dynamic collections
            Example:
            List<string> fruits = new List<string> { "Apple", "Banana" };
            fruits.Add("Cherry");
            fruits.Insert(0, "Date");
            fruits.Remove("Banana");
            string firstFruit = fruits[0];
            
            =====================================================
            
            [LinkedList<T>]
            Structure: Doubly-linked nodes
            Use Case: Frequent insertions/deletions
            Example:
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddLast(2);
            LinkedListNode<int> node = numbers.Find(1);
            numbers.AddAfter(node, 3);
            numbers.Remove(2);
            
            =====================================================
            
            [Stack<T>]
            Structure: LIFO collection
            Use Case: Undo mechanisms, expression parsing
            Example:
            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            string top = stack.Pop(); // Returns "Second"
            bool isEmpty = stack.Count == 0;
            
            =====================================================
            
            [Queue<T>]
            Structure: FIFO collection
            Use Case: Task scheduling, breadth-first algorithms
            Example:
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            string first = queue.Dequeue(); // Returns "First"
            string peek = queue.Peek(); // Returns "Second" without removing
            
            =====================================================    
            
            [Hashtable]
            Structure: Key-value pairs (non-generic)
            Use Case: Fast lookups, legacy systems
            Example:
            Hashtable ht = new Hashtable();
            ht.Add("key1", "value1");
            ht.Add("key2", 123);
            string value = (string)ht["key1"]; // Requires casting
            ht.Remove("key2");
            
            =====================================================
            
            [Dictionary<TKey, TValue>]
            Structure: Generic key-value pairs
            Use Case: Fast, type-safe key-value lookups
            Example:
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("One", 1);
            dict["Two"] = 2;
            int value;
            if (dict.TryGetValue("One", out value))
            {Console.WriteLine(value);}
            
             ================================ Comparison Summary: ================================
            
            1. Performance:
            - Random access: Array, List<T>, ArrayList optimal
            - Frequent insertions/deletions: LinkedList<T> preferable
            - Key-based operations: Dictionary<TKey, TValue>, Hashtable
            
            
            2. Flexibility:
            - Fixed size: Array
            - Dynamic sizing: Others offer automatic resizing
            
            
            3. Type Safety:
            - Non-generic: ArrayList, Hashtable (require casting)
            - Generic: List<T>, LinkedList<T>, Stack<T>, Queue<T>, Dictionary<TKey, TValue>
            
            
            4. Specialized Use Cases:
            - LIFO operations: Stack<T>
            - FIFO operations: Queue<T>
            - Key-Value pairs: Dictionary<TKey, TValue> (modern), Hashtable (legacy)
            
            */
        #endregion


        #region Part2

        #region Question1
        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }
        #endregion

        #region Question2
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            return evenNumbers;
        }
        #endregion

        #region Question3
        public class FixedSizeList<T>
        {
            private T[] _items;
            private int _count;

            public FixedSizeList(int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentException("Capacity must be greater than zero.");
                _items = new T[capacity];
                _count = 0;
            }

            public void Add(T item)
            {
                if (_count >= _items.Length)
                    throw new InvalidOperationException("The list is full. Cannot add more elements.");
                _items[_count++] = item;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");
                return _items[index];
            }
        }
        #endregion

        #region Question4
        public static int FirstNonRepeatedCharIndex(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                    return i;
            }

            return -1;
        }
        #endregion

        #endregion


    }
}