using System;
namespace CollectionsMasterConsoleUI
{
    public class Methods
    {

        public static void ReverseArray(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers

        public static void ThreeToZero(int[] arr)
        {
            foreach (var item in arr)
            {
                if (item % 3 != 0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }


        //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this

        
        }
    }
}

