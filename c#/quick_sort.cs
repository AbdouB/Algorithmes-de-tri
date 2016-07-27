using System;
using System.Linq;


namespace quickSort
{
  
    class Program
    {

        //IComparable rend ce algorithme compatible avec toutes sortes d'éléments comparables {a,b,c..} {1,2,3...}
        //Le type générique <T> herite de l'interface IComparable
        public static void quickSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            int i = left, j = right;
            int pivotIndex = (left + right) / 2;
            
            T pivot = array[pivotIndex];

            while(i <= j)
            {
                //returns -1 si l'element est inférieur au pivot
                //la boucle continue jusqu'à ce qu'un element supérieur au pivot est trouver
                while(array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                //returns 1 si l'element est supérieur au pivot
                //la boucle continue jusqu'à ce qu'un element inférieur au pivot est trouver
                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
          
                if(i <= j)
                {
                    T tmp = array.ElementAt(i);
                    array[i] = array.ElementAt(j);
                    array[j] = tmp;

                    i++;
                    j--;

                 
                }

            }

            //appliquer le tri sur la partie gauche de la liste
            if (left < j)
            {
                quickSort(array, left, j);
            }

            //aapliquer le tri sur la partie droite de la liste
            if (i < right)
            {
                quickSort(array, i, right);
            }


        }

        static void Main(string[] args)
        {

            //exemple de tri d'une liste des caractères
            char[] char_list = {'b','a','g','h','e','c' };
            Console.Write("Liste: ");
            foreach(var x in char_list)
            {
                Console.Write(x + " ");
            }
            quickSort(char_list, 0, char_list.Length - 1);
            Console.WriteLine();
            Console.Write("Liste triée: ");
            foreach (var x in char_list)
            {
                Console.Write(x + " ");
            }

            //exemple de tri d'une liste des numéros
            int[] num_list = { 10,3,2,7,6,5,30,25,23 };
            Console.WriteLine();
            Console.Write("Liste: ");
            foreach (var x in num_list)
            {
                Console.Write(x + " ");
            }
            quickSort(num_list, 0, num_list.Length - 1);
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
