using System;

namespace Rotate
{
    class Program
    {
        static int[] rotate(int[] array, int count)//, bool direction)
        {
         
            //Rotate the given array by n times toward right  
            for (int i = 0; i < count; i++)
            {
                int j, last;
                //Stores the last element of array  
                last = array[array.Length - 1];

                for (j = array.Length - 1; j > 0; j--)
                {
                    //Shift element of array by one  
                    array[j] = array[j - 1];
                }
                //Last element of array will be added to the start of array.  
                array[0] = last;
            }

            Console.WriteLine();

            //Displays resulting array after rotation  
            Console.WriteLine("Array after right rotation: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
                return null;
        }
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int[] result = rotate(values, 2);//,true);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
