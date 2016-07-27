using System;
using System.Linq;


namespace SortingAlgorithms
{
  
    class Program
    {

        

   
        public static void Main(string[] args)
        {

            /*exemple de tri d'une liste des caractères */
            char[] char_list = { 'b', 'a', 'g', 'h', 'e', 'c' };
            Console.Write("Liste: ");
            foreach (var x in char_list)
            {
                Console.Write(x + " ");
            }


            //QuickSort.quickSort(char_list, 0, char_list.Length - 1);
            BubbleSort.bubbleSort(char_list);


            Console.WriteLine();
            Console.Write("Liste triée: ");
            foreach (var x in char_list)
            {
                Console.Write(x + " ");
            }

            /*exemple de tri d'une liste des numéros */
            int[] num_list = { 10, 3, 2, 7, 6, 5, 30, 25, 23, 21 };
            Console.WriteLine();
            Console.Write("Liste: ");
            foreach (var x in num_list)
            {
                Console.Write(x + " ");
            }

            //QuickSort.quickSort(num_list, 0, num_list.Length - 1);
            BubbleSort.bubbleSort(num_list);



            Console.WriteLine();
            Console.Write("Liste triée: ");
            foreach (var x in num_list)
            {
                Console.Write(x + " ");
            }

            Console.ReadKey();

        }


    }
}
