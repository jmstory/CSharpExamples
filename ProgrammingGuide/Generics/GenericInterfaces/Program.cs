using System;
using System.Collections.Generic;
namespace GenericInterfaces
{
    public class GenericList<T> : System.Collections.Generic.IEnumerable<T>
            {
            protected Node head;
            protected Node current = null;
        }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
