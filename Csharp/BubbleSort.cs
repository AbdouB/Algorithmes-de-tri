using System;

using System.Linq;


namespace SortingAlgorithms
{
    class BubbleSort
    {
        public static void bubbleSort<T>(T[] array)where T : IComparable<T>
        {

            int j;
            int bound = array.Length - 1;

            for(int i = 0; i < array.Length - 2; i++)
            {

                for(j = 0; j < bound; j++)
                {
                    if( array.ElementAt(j).CompareTo( array.ElementAt(j+1) ) > 0)
                    {
                        T tmp = array.ElementAt(j);
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;

                    }
                }

                bound = j - 1;

            }

        }

        
    }
}
