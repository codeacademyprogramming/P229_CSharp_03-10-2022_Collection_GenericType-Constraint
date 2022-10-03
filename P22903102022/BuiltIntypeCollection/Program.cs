using System;
using System.Collections;
using System.Collections.Generic;

namespace BuiltIntypeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic Collection
            #region ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hamid");
            arrayList.Add(true);
            arrayList.Add(32);

            ArrayList arrayList1 = new ArrayList();
            arrayList1.AddRange(arrayList);
            #endregion

            #region SortedList
            //SortedList sortedList = new SortedList();
            //sortedList.Add("Sifir", "Yeddi");
            //sortedList.Add("Doqquz", "OnBes");
            //sortedList.Add("Dord", "3");

            //foreach (var item in sortedList.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in sortedList.Keys)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Queue - FIFO - First in First Out
            Queue queue = new Queue();
            queue.Enqueue("Hamid");
            queue.Enqueue("Zaur");
            queue.Enqueue("Elchin");

            //var peek = queue.Peek();

            //Console.WriteLine(queue.Peek());
            //var deq = queue.Dequeue();
            //Console.WriteLine(queue.Peek());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Stack - LIFO - Last In First Out
            Stack stack = new Stack();
            stack.Push("Hamid");
            stack.Push("Zaur");
            stack.Push("Elchin");

            //var pop = stack.Pop();
            //Console.WriteLine(pop);
            //Console.WriteLine(stack.Peek());

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

            #region Generic Collection
            #region List
            List<string> strList = new List<string>();
            strList.Add("");

            //foreach (string item in strList)
            //{

            //}

            #endregion
            #region Dictionary
            Dictionary<string, string> phones = new Dictionary<string, string>();
            phones.Add("Hamid", "+994505523674");
            phones.Add("Test", "+994");
            phones.Add("Test-2", "+99455");

            //foreach (var item in phones)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value}");
            //}
            #endregion
            #region SortedList
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(0, "Sifir");

            //foreach (var item in keyValuePairs.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Queue - FIFO - First in First Out
            Queue<string> strListQueue = new Queue<string>();

            strListQueue.Peek();
            #endregion
            #region Stack - LIFO - Last In First Out
            Stack<int> intStackList = new Stack<int>();
            #endregion
            #endregion

        }
    }
}
