using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] arr = 
                {
                    new DateTime ( 2021, 1, 1),
                    new DateTime ( 2021, 11, 6),
                    new DateTime ( 2021, 10, 13),
                    new DateTime ( 2021, 12, 17),
                    new DateTime ( 2021, 5, 12)
                };
            Console.WriteLine("Before insertion :");
            foreach (var array in arr)
            {
                Console.WriteLine(array);
            }


            //In array We can replace element but cannot add or remove element
            Console.WriteLine("\nAfter insertion :");
            arr[1] = new DateTime(2021, 7, 15);
            foreach (var array in arr)
            {
                Console.WriteLine(array);
            }
        }
    }
}
