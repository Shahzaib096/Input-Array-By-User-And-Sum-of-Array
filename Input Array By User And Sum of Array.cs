using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Array_By_User_And_Sum_of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Size by User
            Console.Write("Please Enter Size of Array : ");
            int sizeOfArray = int.Parse(Console.ReadLine());
            //Declear Array
            int[] myArray = new int[sizeOfArray];
            //Input Array By User
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            //Display Array Size 
            Console.WriteLine("Array Size is :" + sizeOfArray);
            //Display Array Elements 
            Console.WriteLine("Array Elemnets :");
            foreach (int item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Array Sum
            Console.WriteLine("Array Sum is :" + myArray.Sum());
            Console.ReadLine();
        }
    }
}
