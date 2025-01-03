using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Collections
{
    class Collections
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////Non-Generic Collections///////////////////////////
            ////////////////////////////ArrayList //////////////////////////////// 

            //exp-1
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("DotNet Developer");
            //arrayList.Add("Angular Developer");
            //arrayList.Add("Software Engineer");
            //Console.WriteLine("Jobs are : ");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////exp-2 
            //ArrayList arrayList = new ArrayList();
            //////Add
            //arrayList.Add(100); arrayList.Add(200); arrayList.Add(300); arrayList.Add(400);
            //Console.WriteLine(arrayList.Capacity);
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i + "  ");
            //    Console.WriteLine();
            //}
            ///Insert
            //arrayList.Insert(3, 350);
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i + "  ");
            //    Console.WriteLine();
            //}
            /////Remove
            //arrayList.Remove(200);//remove by element 
            //arrayList.RemoveAt(3);//remove by index 
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i + "  ");
            //    Console.WriteLine();
            //}

            /////////////////////////////////HashTable///////////////////////////////////
            //Hashtable ht = new Hashtable();

            //ht.Add("DotNet Developer", 1); // Adding
            //ht.Add("Angular Developer", 1); // Adding
            //ht.Add("Java Developer", 1); // Adding
            //ht.Add("Python Developer", 1); // Adding

            //Console.WriteLine("Jobs are : ");
            //foreach (DictionaryEntry entry in ht)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");

            //}

            //ht.Remove("Angular Developer"); // remove

            //Console.WriteLine("After removing : ");
            //foreach(DictionaryEntry entry in ht)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            //}


            //IDictionaryEnumerator en = ht.GetEnumerator(); /// to show value

            //while (en.MoveNext())
            //{
            //    string str = en.Value.ToString();
            //}


            //Console.WriteLine("Retrieved Data : ");
            //string name = ht["Java Developer"].ToString(); // retrive



            /////////////////////////////Queue///////////////////////////////////
            //exp-1

            //Queue Qu = new Queue();
            //Qu.Enqueue("DotNet");
            //Qu.Enqueue("Java");
            //Qu.Enqueue("Angular");

            //Console.WriteLine("The jobs are in the Queue are : ");
            //while (Qu.Count > 0)
            //{
            //    Console.WriteLine(Qu.Dequeue());

            //}
            //exp-2

            Queue li = new Queue();

            li.Enqueue("MCA");
            li.Enqueue("MBA");
            li.Enqueue("BCA");
            li.Enqueue("BBA");
            li.Enqueue("AACA");
            li.Enqueue("CMA");
            Console.WriteLine("The Degrees are :" + li.Count);

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("peek item : " + li.Peek());  // peek will show the items of first

            li.Dequeue();
            li.Dequeue();

            //li.Clear(); // after the function clear() will clear all the other modified function under it

            Console.WriteLine("After the removal of elements in the Queue are :" + li.Count); /// count the number of items in the list

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The Element CMA is in the Queue : " + li.Contains("CMA"));
            Console.WriteLine("The Element MCA is in the Queue : " + li.Contains("MCA")); //  check the item in the list


            Queue li2 = new Queue(li.ToArray()); // coping in second Array

            Console.WriteLine("Contents of copy data : ");
            foreach (var item in li2)
            {
                Console.WriteLine(item);
            }

            ////////////////////////////Stack/////////////////////////////
            //Stack st = new Stack();
            //st.Push("Haneesha");
            //st.Push("Rh");
            //st.Push("MCA");

            //Console.WriteLine("Here is the Details : ");
            //foreach (string i in st) 
            //{
            //    Console.WriteLine(i);
            //}
            ////while(st.Count > 0) 
            ////{ 
            ////    Console.WriteLine(st.Pop());
            ////}

            //st.Pop();
            //Console.WriteLine("Removing and Returning");
            //foreach(string i in st)
            //{
            //    Console.WriteLine(i);
            //}

            /////////////////// Sorted List //////////////////////

            //SortedList sort = new SortedList();

            //sort.Add(1, "sunday");
            //sort.Add(2, "monday");
            //sort.Add(3, "tuesday");
            //sort.Add(4, "wednesday");
            //sort.Add(5, "thursday");
            //sort.Add(6, "friday");

            //Console.WriteLine("Sorted Elements : ");
            //foreach (DictionaryEntry entry in sort)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            //}


        }
    }
}
