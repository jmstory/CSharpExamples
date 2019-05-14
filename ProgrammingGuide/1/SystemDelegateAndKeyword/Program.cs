using System;
using System.Collections;



namespace SystemDelegateAndKeyword
{
    class Program
    {
        public delegate int Comparison<in T>(T left , T right);
        //클래스 내부 정의라는데 에러뜸
        //public Comparison<T> comparator;

        private static int CompareLength(string left, string right) => left.Length.CompareTo(right.Length);

       
        static void Main(string[] args)
        {
            //int result = comparator(left, right);
          
            //리스트관련인거같은데 뭔말인지 모르겠음
            //phrases.Sort(CompareLength);

            //
            Comparison<string> comparar = CompareLength;
            //phrases.Sort(comparar);

            Comparison<string> comparer = (left, right) => left.Length.CompareTo(right.Length);
            //phrases.Sort(comparer);
        }
    }
}
