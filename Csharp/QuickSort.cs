using System;
using System.Linq;


namespace SortingAlgorithms
{
    class QuickSort
    {
        //IComparable rend ce algorithme compatible avec toutes sortes d'éléments comparables {a,b,c..} {1,2,3...}
        //Le type générique <T> herite de l'interface IComparable
        public static void quickSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            int i = left, j = right;
            int pivotIndex = (left + right) / 2;

            T pivot = array[pivotIndex];

            while (i <= j)
            {
                //returns -1 si l'element est inférieur à middle
                //la boucle continue jusqu'à ce qu'un element supérieur au pivot est trouver
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                //returns 1 si l'element est supérieur à middle
                //la boucle continue jusqu'à ce qu'un element inférieur au pivot est trouver
                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T tmp = array.ElementAt(i);
                    array[i] = array.ElementAt(j);
                    array[j] = tmp;

                    i++;
                    j--;


                }

            }

            //appliquer le tri sur la partie gauche du tableau
            if (left < j)
            {
                quickSort(array, left, j);
            }

            //aapliquer le tri sur la partie droite du tableu
            if (i < right)
            {
                quickSort(array, i, right);
            }


        }
    }
}
