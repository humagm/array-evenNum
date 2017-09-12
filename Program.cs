using System;
using System.Collections.Generic;
namespace array_evenNum
{
    class Program
    {
        static void Main(string[] args)
        {
          var numbers = new int[] {2, 4, 5, 78, 45, 99, 88, 100, 203, 111};
          var evenNumbers = new List<int>();

          foreach(var x in numbers) {
          if(x % 2 != 0){
          evenNumbers.Add(x);

          }
        }

        Console.WriteLine("the given array in ascendig order");
        Array.Sort(numbers);

         foreach(var x in numbers) {
         Console.WriteLine(x);
         }
             
    }
}
    }