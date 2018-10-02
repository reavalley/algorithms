using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorter = new BubbleSort();
            
            var result = BubbleSort.Sort(new int[]{29,27,3,11,18,28,13 });
            
            var output = string.Join(",", result.Select(p=>p.ToString()).ToArray());
            
            Console.WriteLine(output);
        }
    }
}