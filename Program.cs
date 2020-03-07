using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("thus is  my endless learning cerve:\n");
                int[] arr = new int[5];

                arr[0] = Convert.ToInt32(Console.ReadLine());
                arr[1] = Convert.ToInt32(Console.ReadLine());
                arr[2] = Convert.ToInt32(Console.ReadLine());
                arr[3] = Convert.ToInt32(Console.ReadLine());
                arr[4] = Convert.ToInt32(Console.ReadLine());

                Array.Sort(arr);
                Array.Reverse(arr);



                foreach (int value in arr)
                {
                    Console.WriteLine("");
                    Console.Write($"the numbers you entered are :{value}");
                   
                }
            }





        }
    }
}
