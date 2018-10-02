using System.Collections.Generic;

namespace Algorithms
{
    public class BubbleSort
    {
        public static IEnumerable<int> Sort(int[] listToSort)
        {
            var m = 0;
            var k = 0;
            var n = listToSort.Length - 1;

            while (m < n)
            {
                while (k < n)
                {
                    if (listToSort[k] > listToSort[k+1])
                    {
                        var a = listToSort[k];
                        var b = listToSort[k + 1];

                        listToSort[k] = b;
                        listToSort[k + 1] = a;
                    }
                    k++;
                }
                k = 0;
                m++;
            }
            return listToSort;
        }
        
        public IEnumerable<int> Sort2(int[] listToSort)
        {
            foreach (var val in listToSort)
            {
                for (var i = 0; i < listToSort.Length; i++)
                {
                    if (i + 1 > listToSort.Length - 1) continue;
                
                    var a = listToSort[i];
                    var b = listToSort[i + 1];

                    if (a <= b) continue;
                
                    listToSort[i] = b;
                    listToSort[i + 1] = a;
                }
            }
            return listToSort;
        }
    }
}