using System;

  

namespace GenericExamples
{
 
    class Program
    {
        
        public class GenericList<T>
        {
            public void Add(T input ){}
        }
        private class ExampleClass{}
        static void Main(string[] args)
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");

            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());
        }
    }
}
