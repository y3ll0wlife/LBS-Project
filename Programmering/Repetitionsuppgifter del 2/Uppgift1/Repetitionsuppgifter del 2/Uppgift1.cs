using System;

namespace Repetitionsuppgifter_del_2
{
    class Uppgift1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++) arr[i] = Convert.ToInt32(Console.ReadLine());

             
            Console.WriteLine("--------------");

            bool moved = true;
            int inc = 0;

            while (moved)
            {
                moved = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int lower = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = lower;
                        moved = true;
                    }
                    inc++;
                }
            }

            Console.WriteLine($"Times: {inc}");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }




    }
}
