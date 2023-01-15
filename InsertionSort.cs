using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class InsertionSort
    {
        public static void DisplayInsertion()
        { 
    int[] arr = new int[5] { 23, 9, 85, 12, 99 };
    int n = 5, i, j, val, flag;
    Console.WriteLine("Insertion Sorting");
    Console.WriteLine("Intial array :");
    for(i=0;i<n;i++)
        {
        Console.WriteLine(arr[i]);
        }
     for (i=1;i<n;i++)
{
    val = arr[i];
    flag = 0;
    for (j=i-1; j>=0&&  flag!=1;)
    {
        if (val < arr[j])
        {
            arr[j + 1] = arr[j];
            j--;
            arr[j + 1] = val;
        }
        else
            flag = 1;
    }
}
Console.WriteLine("Sorted array :");
for (i = 0; i < n; i++)

{
    Console.WriteLine(arr[i]);
}

        
    }
}

}
