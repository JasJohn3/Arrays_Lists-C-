using System;
using System.Collections.Generic;

namespace Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a random number generator variable
            Random Random_Number = new Random();
            //creating an array
            var matrix = new int[3, 5];

            //creating a jagged array;
            var jagged_Array = new int[3][];
            jagged_Array[0]= new int[4];
            jagged_Array[1] = new int[5];
            jagged_Array[2] = new int[3];

            //how to iterate through a standard array
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    matrix[row, col] = Random_Number.Next(0,100);
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine(matrix[row,col]);
                }
            }

            //how to iterate through a jagged Array
            for (int row = 0; row < jagged_Array.Length; row++)
            {
                for (int col = 0; col < jagged_Array[row].Length; col++)
                {
                    jagged_Array[row] [col] = Random_Number.Next(0, 10);
                }
            }
            for (int row = 0; row < jagged_Array.Length; row++)
            {
                for (int col = 0; col < jagged_Array[row].Length; col++)
                {
                    Console.WriteLine(jagged_Array[row][col]);
                }
            }

            var numbers = new[] {3, 7, 9, 2, 14, 6};

            // Length method of array class
            Console.WriteLine("Length: "+ numbers.Length);

            // Indexof() index method of array class
            var index = Array.IndexOf(numbers, 14);
            Console.WriteLine("Index of #14 in array using C Sharp Array Method Array.Index(array_name,item value in array): "+ index);

            // Clear() clear method of array class
            Array.Clear(numbers,0,2);

            Console.WriteLine("Effects of Clear() Method: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //Array.Copy Method example
            int[] array_copy_method =new int[3];
            Array.Copy(numbers,array_copy_method, 3);

            Console.WriteLine("Array.Copy() Method: ");
            foreach (var item in array_copy_method)
            {
                Console.WriteLine(item);
            }
            //Array.Sort Method example
           Array.Sort(numbers);
           Console.WriteLine("Array.Sort() Method: ");
            foreach (var item in numbers)
           {
               Console.WriteLine(item);
           }

            //Array.Reverse Method example
            Array.Reverse(numbers);
            Console.WriteLine("Array.Reverse() Method: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            //Lists
            var numbers_list = new List<int>();

            //this functions generates a random size value for our list
            var Size = Random_Number.Next(0, 50);
            for (int i = 0; i < Size; i++)
            {
                //this adds a random number to our numbers list
                numbers_list.Add(Random_Number.Next(0,50));
            }
            Console.WriteLine("Displaying our Randomly Generated List and index values: ");
            foreach (var item in numbers_list)
            {
                Console.Write("\nIndex: "+ numbers_list.IndexOf(item));
                Console.Write("\tValue: "+ item);
            }
        }
    }
}
