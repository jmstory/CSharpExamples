using System;
using System.Collections.Generic;

namespace GenericTypeParameters
{
    public class GenericList<T>
    {
        public void Add(T input) { }
    }
    class Program
    {
        private class ExampleClass { }
        private struct ExampleStruct{}
       
        //Type parameter naming guidelines
        public delegate TOutput Converter<TInput, TOutput>(TInput from);
        public class List<T> { /*...*/ }        
        public int IComparer<T>() { return 0; }
        public delegate bool Predicate<T>(T item);
        public struct Nullable<T> where T : struct { /*...*/ }
        public interface ISessionChannel<TSession>
        {
            TSession Session { get; }
        }
        static void Main(string[] args)
        {
            GenericList<float> list1 = new GenericList<float>();
            GenericList<ExampleClass> list2 = new GenericList<ExampleClass>();
            GenericList<ExampleStruct> list3 = new GenericList<ExampleStruct>();
        }
    }

   
}
