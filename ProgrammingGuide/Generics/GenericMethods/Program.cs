using System;

namespace GenericMethods
{
    class Program
    {
        static void Swap<T>(ref T lhs , ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public static void TestSwap()
        {
            int a = 1;
            int b = 2;

            Swap<int>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);
        }

        class SampleClass<T>
        {
            void Swap(ref T lhs, ref T rhs) { }
        }
        // class GenericList<T>
        // {
        //     void SampleMethod<T>{}
        // }
        // class GenericList2<T>
        // {
        //     void SampleMethod<T>{}
        // }

        void SwapIfGreater<T>(ref T lhs, ref T rhs) where T : System.IComparable<T>
        {
            T temp;
            if (lhs.CompareTo(rhs) > 0)
            {
                temp = lhs;
                lhs = rhs;
                rhs = temp;
            }
        }

        void DoWork() { }
        void DoWork<T>() { }
        void DoWork<T, U>() { }
        static void Main(string[] args)
        {
            TestSwap();
        }
    }
}
