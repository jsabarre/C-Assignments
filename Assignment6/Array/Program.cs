// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(String[] args)
        {
            //Answer 1
            //CopyArray();

            //Answer 2
            //ManageList();

            //Answer 3
            //int[] primes = FindPrimes(2, 30);

            //Answer 4
            //int[] arr1 = { 1,2,3,4,5};
            //RotateArray(arr1, 3);

            //Answer 5
            //int[] arr2 = { 2, 1, 2, 2, 2, 1, 4, 4, 4, 4, 3, 2, 5, 2};
            //LongestSubseq(arr2);

            //Answer 7
            int[] arr3 = {3,2,4,5,10,5,2,6,1,8,9,10,2,10,10 };
            int max_num = FreqNum(arr3);
            System.Console.WriteLine(max_num);



            static void CopyArray()
            {
                int[] First = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

                int[] Second = new int[First.Length];

                Console.WriteLine("The First Array values are ");

                for (int i = 0; i < First.Length; i++)
                {
                    Second[i] = First[i];
                    Console.Write(First[i] + "\n");

                }
                Console.WriteLine("The Second Array values are ");
                for (int j = 0; j < Second.Length; j++)
                {
                    Console.Write(Second[j] + "\n");
                }
            }

            Console.Write("\n");




            //Question 2
            static void ManageList()
            {

                ArrayList arr = new ArrayList();

                while (true)
                {
                    Console.WriteLine("Enter command (+ Add item, - Remove item, -- to clear item, 0 to exit)):");

                    String item = Console.ReadLine();

                    if (item == "0")
                    {
                        break;

                    }

                    if (item == "--")
                    {
                        arr.Clear();
                        Console.WriteLine(String.Join(", ", arr.ToArray(typeof(String)) as String[]));
                        continue;
                    }

                    if (item.StartsWith("+"))
                    {
                        arr.Add(item.Split(" ")[1]);
                        Console.WriteLine(String.Join(", ", arr.ToArray(typeof(String)) as String[]));
                        continue;
                    }
                    if (item.StartsWith("-"))
                    {
                        arr.Remove(item.Split(" ")[1]);
                        Console.WriteLine(String.Join(", ", arr.ToArray(typeof(String)) as String[]));
                        continue;
                    }

                }
            }


            //Question 3
            static int[] FindPrimes(int start, int end)

            {
                int[] Array = new int[100];
                int k = 0;

                start = Convert.ToInt32(start);
                end = Convert.ToInt32(end);

                for (int i = start; i <= end; i++)
                {
                    int Count = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Count++;
                            break;
                        }
                    }
                    if (Count == 0 && i != 1)
                    {
                        Array[k] = i;
                        k++;
                        Console.Write(i + "\n");
                    }
                }
                return Array;


            }


            //Question 4
            static void RotateArray(int[] arr, int k)
            {
                int n = arr.Length;
                int[] sum = new int[n];
                int[] prev = arr;
                int[] rotate;

                for (int i = 0; i < k; i++)
                {
                    rotate = RotateOnce(prev);

                    Console.WriteLine(String.Join(" ", rotate));

                    for (int j = 0; j < n; j++)
                    {
                        sum[j] += rotate[j];
                    }

                    prev = rotate;
                }

                Console.WriteLine(String.Join(" ", sum));
            }

            static int[] RotateOnce(int[] arr)
            {
                int n = arr.Length;
                int[] newArr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        newArr[i] = arr[n - 1];
                    } else
                    {
                        newArr[i] = arr[i - 1];
                    }
                }

                return newArr;
            }





            //Question 5
            static void LongestSubseq(int[] arr)
            {
                int currNum = int.MinValue;
                int currFreq = int.MinValue;
                int maxNum = int.MinValue;
                int maxFreq = int.MinValue;


                foreach (int num in arr)
                {
                    if (num != currNum)
                    {
                        currNum = num;
                        currFreq = 1;
                    }  else
                    {
                        currFreq += 1;
                        if (currFreq > maxFreq)
                        {
                            maxFreq = currFreq;
                            maxNum = num;
                        }
                    }
                }
                for (int i = 0; i < maxFreq; i++)
                {
                    if (i != maxFreq - 1)
                    {
                        Console.Write(maxNum + " ");
                    } else
                    {
                        Console.WriteLine(maxNum);
                    }

                }
            }

            static int FreqNum(int[] arr)
            {
                Hashtable dict = new Hashtable();


                for (int i = 0; i < arr.Length; i++)
                {
                    if (dict.ContainsKey(arr[i]))
                    {
                        dict[arr[i]] = (int)dict[arr[i]] + 1;
                    } else
                    {
                        dict.Add(arr[i], 1);
                    }
                }

                int maxFreq = 0;
                int maxNum = int.MinValue;

                foreach (DictionaryEntry d in dict)
                {
                    if ((int)d.Value > maxFreq)
                    {

                        maxFreq = (int)d.Value;
                        maxNum = (int)d.Key;

                    }
                }

                return maxNum;
            }
        }

    }
}
