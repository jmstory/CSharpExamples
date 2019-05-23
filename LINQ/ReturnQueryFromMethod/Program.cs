using System;
using System.Collections.Generic;
using System.Linq;

namespace ReturnQueryFromMethod
{    
    class Program
    {
        IEnumerable<string> QueryMethod1(ref int[] ints)
        {
            var intsToString = from i in ints where i > 4 select i.ToString();
            return intsToString;
        }

        void QueryMethod2(ref int [] ints , out IEnumerable<string> returnQ)
        {
            var intsToString = from i in ints where i < 4 select i.ToString();
            returnQ = intsToString;
        }
        static void Main(string[] args)
        {
            Program app = new Program();
            int [] nums = {0,1,2,3,4,5,6,7,8,9};

            var myQuery1 = app.QueryMethod1(ref nums);

            foreach( string s in myQuery1)
            {
                 Console.WriteLine(s);
            }

            Console.WriteLine("\nResults of executing myQuery1 directly:");
       
            foreach (string s in app.QueryMethod1(ref nums))
            {
                Console.WriteLine(s);
            }

            IEnumerable<string> myQuery2;
            app.QueryMethod2(ref nums , out myQuery2);

            Console.WriteLine("\nResults of executing myQuery2:");
            foreach (string s in myQuery2)
            {
                Console.WriteLine(s);
            }

            myQuery1 = from item in myQuery1 orderby item descending select item;

            Console.WriteLine("\nResults of executing modified myQuery1:");
            foreach (string s in myQuery1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
