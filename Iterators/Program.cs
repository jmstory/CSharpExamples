using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {

            // foreach(var item in collection)
            // {
            //     Console.WriteLine(item.ToString());
            // }

            //Deeper Dive into foreach
            
            // IEnumerator<int> enumerator = collection.GetEnumerator();
            // while (enumerator.MoveNext())
            // {
            //     var item = enumerator.Current;
            //     Console.WriteLine(item.ToString());
            // }

            // C#버전 1 ~ 4
            // IEnumerator<int> enumerator = collection.GetEnumerator();
            // int item = default(int);
            // while (enumerator.MoveNext())
            // {
            //     item = enumerator.Current;
            //     Console.WriteLine(item.ToString());
            // }
            
            // var enumerator = collection.GetEnumerator();
            // try
            // {
            //     while (enumerator.MoveNext())
            //     {
            //         var item = enumerator.Current;
            //         Console.WriteLine(item.ToString());
            //     }
            // } finall
            // {
            //     //(enumerator as IDisposable)?.Dispose();
            // }

        }

        // public IEnumerable<int> GetSingleDigitNumbers()
        // {
        //     yield return 0;
        //     yield return 1;
        //     yield return 2;
        //     yield return 3;
        //     yield return 4;
        //     yield return 5;
        //     yield return 6;
        //     yield return 7;
        //     yield return 8;
        //     yield return 9;
        // }

        // public IEnumerable<int> GetSingleDigitNumbers()
        // {
        //     int index = 0;
        //     while (index++ < 10)
        //         yield return index;
        // }

        // public IEnumerable<int> GetSingleDigitNumbers()
        // {
        //     int index = 0;
        //     while (index++ < 10)
        //         yield return index;

        //     yield return 50;

        //     index = 100;
        //     while (index++ < 110)
        //         yield return index;
        // }

        public IEnumerable<int> GetSingleDigitNumbers()
        {
            int index = 0;
            while (index++ < 10)
                yield return index;

            yield return 50;

            //컴파일 에러
            // var items = new int[] {100, 101, 102, 103, 104, 105, 106, 107, 108, 109 };
            // return items;
        }

        public IEnumerable<int> GetSingleDigitOddNumbers(bool getCollection)
        {
            if (getCollection == false)
                return new int[0];
            else
                return IteratorMethod();
        }

        private IEnumerable<int> IteratorMethod()
        {
            int index = 0;
            while (index++ < 10)
                if (index % 2 == 1)
                    yield return index;
        }

        
    }
}
