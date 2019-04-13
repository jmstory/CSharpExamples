using System;
using System.Collections.Generic;

namespace GenericsAndArrays
{
   
    class Program
    {
        static void ProcessItems<T>(IList<T> coll)
        {
            System.Console.WriteLine("IsReadOnly returns {0} for this collection.",coll.IsReadOnly);
            foreach (T item in coll)
            {
                System.Console.Write(item.ToString() + " ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4};
            List<int> list = new List<int>();

            for(int x = 5 ; x < 10 ; x++)
            {
                list.Add(x);
            }

            ProcessItems<int>(arr);
            ProcessItems<int>(list);

         
            
        }
    }
}
