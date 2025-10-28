using System.Collections;

namespace C_Advanced_A2


{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*1. The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, 4
             * which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm 
            And implement the code of this optimised bubble sort algorithm
            */

            //static void Optimized_bubble_sort<T>(T[] arr) where T : IComparable<T>
            //{
            //    int n = arr.Length;
            //    bool swapped;

            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        swapped = false;

            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            // Use CompareTo instead of > or <
            //            // CompareTo returns:
            //            //   < 0 if arr[j] < arr[j + 1]
            //            //   = 0 if equal
            //            //   > 0 if arr[j] > arr[j + 1]
            //            if (arr[j].CompareTo(arr[j + 1]) > 0)
            //            {
            //                // Swap
            //                T temp = arr[j];
            //                arr[j] = arr[j + 1];
            //                arr[j + 1] = temp;
            //                swapped = true;
            //            }
            //        }

            //        // Stop if no swaps happened
            //        if (!swapped)
            //            break;
            //    }
            //}

            #endregion


            #region Q2
            /*2.You are given an ArrayList containing a sequence of elements. 
             * try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse.
             * Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
             */

            // ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            // reverseArry(list);



            #endregion


            #region Q3
            /*. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, 
             * and you should print how many numbers in array that is greater than  X.
             * 
                Ex:
                Input
                3 3                    //Size of array , number of queries
                11 5 3             //Array 
                1                      //Query1
                5                     //Query2
                13                  //Query 3
                Output
                3                   //11,5,3
                        1                  //11
                0             
                */

            //Console.WriteLine("enter the size of array : ");
            //int size= int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("enter number of query : ");
            //int queryCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the elements of array : ");
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int q = 0; q < queryCount; q++)
            //{
            //    Console.WriteLine("enter the query number : ");
            //    int X = int.Parse(Console.ReadLine());
            //    int count = 0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (arr[i] > X)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(count);
            //}



            #endregion

            #region Q4
            /*4. Given a number N and an array of N numbers. Determine if it's palindrome or not.
             
            Ex:
            Input:
            5
            1 3 2 3 1
            Output:
            YES
            */


            //Console.WriteLine("Enter array size");
            //int size=int.Parse(Console.ReadLine()); 
            //int[]arr = new int [size];
            //Console.WriteLine("enter the elements of array ");
            //for (int i= 0;i<size;i++) {
            //    Console.Write($"enter element num {i} : ");
            //    arr[i]=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(isplidrome(arr,size));






            #endregion

            #region Q5
            /*5. Given a Queue, implement a function to reverse the elements of a queue using a stack.*/
            //Queue<int>queue = new Queue<int> ( new[] { 1, 2, 3, 4, 5 } );
            //Stack<int> stack = new Stack<int>();
            //foreach (int i in queue) { 
            //stack.Push(i);
            //}
            //foreach (int i in stack) {
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q6
            /*
          6. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

          Ex:
          Input:
          [()]{}
          Output:
          Balanced
          */

            //string s = Console.ReadLine();
            //Stack<char> st = new Stack<char>();
            //foreach (char x in s)
            //{
            //    if (x == '{' || x == '(' || x == '[')
            //    {
            //        st.Push(x);
            //    } else if (x == '}' || x == ')' || x == ']')
            //    {
            //        if (st.Count == 0)
            //        {
            //            Console.WriteLine("Not Balanced ");
            //            return;
            //        }
            //        char top = st.Pop();
            //        if( (x == '}' && top != '{') || (x == ')' && top != '(') || (x == ']' && top != '['))
            //                {
            //            Console.WriteLine("Not Balanced");
            //            return;
            //        }
            //    }

            //}
            //Console.WriteLine("Balanced");

            ////STLs:)



            #endregion

            #region Q7
            ///*7. Given an array, implement a function to remove duplicate elements from an array.*/
            //int[] arr = new int []{1,2,3,2,3,5,6,1 };

            //int[]res =removeDuplicate(arr);
            ////       = rmduplicate (arr)
            //foreach(var i in res)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q8

            /*8. Given an array list , implement a function to remove all odd numbers from it.*/
            // ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ArrayList arr1= removeodd(arrayList);
            // foreach (var i in arr1)
            // {
            //    Console.WriteLine(i);
            // }

            #endregion
            #region Q9

            /*9. Implement a queue that can hold different data types. 
            And insert the following data:
            queue.Enqueue(1)
            queue.Enqueue(“Apple”)
            queue.Enqueue(5.28)
            */


            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //foreach (var item in queue) {
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q10
            /*Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack.
             * If the target is found, print a message indicating that the target was found how many elements were checked before
             * finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message 
             * indicating that the target was not found(“Target was not found”).
            Note : take the target as input from the user
            */
            // gettarget();

            #endregion

            #region MyRegion
            /*Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
            Ex : 
            Input :
            5 , 3
            [1,2,3,4,4] , [10,4,4]
            Output : 
            [4,4]
              */
            //int x= int.Parse(Console.ReadLine());
            //int y= int.Parse(Console.ReadLine());

            //  int [] arr1 = new int[x];
            //  int [] arr2 = new int[y];
            //  Console.WriteLine("enter elements of first array : ");
            //  for(int i=0;i<x;i++)
            //  {
            //      arr1[i]= int.Parse(Console.ReadLine());
            //  }
            //  Console.WriteLine("enter elements of second array : ");
            //  for (int i = 0; i < y; i++)
            //  {
            //      arr2[i] = int.Parse(Console.ReadLine());
            //  }

            // //int z = Math.Max(x, y);
            //  List<int> intersection = new List<int>();
            //  for (int i = 0; i < x; i++)
            //  {
            //      for (int j = 0; j < y; j++)
            //      {
            //          if (arr1[i] == arr2[j])
            //          {
            //              intersection.Add(arr1[i]);
            //              arr2[j] = int.MinValue; // علشان ما نستخدمش نفس العنصر مرتين
            //              break; // نطلع من اللوب بعد ما نلاقي أول تطابق
            //          }
            //      }
            //  }
            //  Console.WriteLine("Intersection elements are : ");
            //  foreach (var item in intersection)
            //  {
            //      Console.WriteLine(item);
            //  }


            #endregion


            #region MyRegion
            /*12. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
            Ex : 
            Input : 
            [1, 2, 3, 7, 5]
            12
            Output : 
            [2, 3, 7]
            */
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 7, 5 };
            int target =int.Parse( Console.ReadLine());
            //IDk how to solve it :(




            #endregion
            #region MyRegion
            /*13. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
            Ex : 
            Input : 
            [1 , 2 , 3 , 4 ,5]
            K = 3
            Output :
            [3 , 2 , 1 , 4 ,5]

            */

            //IDK
            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //int K = int.Parse(Console.ReadLine());
            
            //Console.WriteLine("Reversed Queue is : ");
            //foreach (var item in reversedQueue)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


        }
        public static void gettarget()
        {
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < 20; i++)
            {
                st.Push(i);
            }
            int count = 0;
            Console.WriteLine("Enter the target : ");
            int target = int.Parse(Console.ReadLine());
            bool isfound = false;
            foreach (int i in st)
            {
                if(i == target)
                {
                    isfound= true;
                    break;
                }
                else { count++; }
            }
            if (isfound)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }


        }
        public static ArrayList removeodd(ArrayList arrayList)
        {
            ArrayList arr = new ArrayList();
            foreach (int x in arrayList) {
                if (x % 2 == 0)
                {
                    arr.Add(x);
                }

            }
            return arr;
        }
        public static int[]removeDuplicate(int[]arr)
        {
           return arr.Distinct().ToArray();

        }

        public static int[] rmduplicate(int[] arr)
        {
            List<int> list = new List<int>();
            foreach(int num in arr)
            {
                if (!list.Contains(num))
                {
                    list.Add(num);
                }
            }
            return list.ToArray();
        }
        public static bool isplidrome(int[]arr,int n)
        {
            for (int i=0;i<arr.Length/2;i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    return false;
                   
                }


            }
            return true;

        }

        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;
            while (left < right)
            {
                // Swap elements at left and right indices
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }

        public static  void reverseArry(ArrayList list)
        {
            for(int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i] +" ");
            }

        }




    }
}
