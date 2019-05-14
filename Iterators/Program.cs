using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();
            collection.Add(1);
            collection.Add(2);
            collection.Add(3);
            foreach(var item in collection)
            {
                Console.WriteLine(item.ToString());
            }

            //Deeper Dive into foreach
            
            IEnumerator<int> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item.ToString());
            }

            // C#버전 1 ~ 4

            //1
            IEnumerator<int> enumerator1 = collection.GetEnumerator();
            int item1 = default(int);
            while (enumerator1.MoveNext())
            {
                item1 = enumerator1.Current;
                Console.WriteLine(item1.ToString());
            }
            
            //2
            var enumerator2 = collection.GetEnumerator();
            try
            {
                while (enumerator2.MoveNext())
                {
                    var item = enumerator2.Current;
                    Console.WriteLine(item.ToString());
                }
            } 
            finally
            {
                //(enumerator as IDisposable)?.Dispose();
            }

            //3
            var enumerator3 = collection.GetEnumerator();
            try
            {
                while (enumerator3.MoveNext())
                {
                    var item = enumerator3.Current;
                    Console.WriteLine(item.ToString());
                }
            } 
            finally
            {
                (enumerator as IDisposable)?.Dispose();
            }

            //4
            var enumerator4 = collection.GetEnumerator();
            try
            {
                while (enumerator4.MoveNext())
                {
                    var item = enumerator4.Current;
                    Console.WriteLine(item.ToString());
                }
            } 
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
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
