using System;
using System.Collections.Generic;

namespace ConstraintsOnTypeParameters
{
    // public class Employee
    // {
    //     public Employee(string s, int i) => (Name ,ID) = (s,i);
    //     public string Name{get;set;}
    //     public int ID {get; set;}
    // }
    // public class GenericList<T> where T : Employee
    // {
    //     private class Node
    //     {
    //         public Node(T t) => (Next,Data) = (null,t);
    //         public Node Next {get; set;}
    //         public T Data{get;set;}
    //     }
    //     private Node head;
    //     public void AddHead(T t)
    //     {
    //         Node n =  new Node(t) {Next = head};
    //         head = n ;
    //     }
    //     public IEnumerator<T> GetEnumerator()
    //     {
    //         Node current = head;
    //         while (current != null)
    //         {
    //             yield return current.Data;
    //             current = current.Next;
    //         }
    //     }
    //     public T FindFirstOccurrence(string s)
    //     {
    //         Node current = head;
    //         T t = null;

    //         while(current != null)
    //         {
    //             if( current.Data.Name == s)
    //             {
    //                 t = current.Data;
    //                 break;
    //             }
    //             else
    //             {
    //                 current = current.Next;
    //             }
    //         }
    //         return t;
    //     }
    // }

    // class EmployeeList<T> where T : Employee, IEmployee, System.IComparable<T>, new()
    // {
        
    // }
   
    class Program
    {
    //      public static void OpEqualsTest<T>(T s , T t) where T : class
    //      {
    //          System.Console.WriteLine(s == t);
    //      }

    //      private static void TestStringEquality()
    //      {
    //          string s1 = "target";
    //          System.Text.StringBuilder sb = new System.Text.StringBuilder("target");
    //          string s2 = sb.ToString();
    //          OpEqualsTest<string>(s1, s2);
    //     }

        //Constraining multiple parameters
        // class Base{}
        // class Test<T,U> where U: struct where T : Base, new()
        // {

        // }

        // //Type parameters as constraints
        // public class List<T>
        // {
        //     public void Add<U>(List<U> items) where U : T {}
        // }
        // public class SampleClass<T, U, V> where T : V { }

        //Unmanaged constraint
        // public static TDelegate TypeSafeCombine<TDelegate>(this TDelegate source,TDelegate target) 
        // where TDelegate : System.Delegate => Delegate.Combine(source,target) as TDelegate;

        //Enum constraints
        // public static Dictionary<int , string > EnumNamedValues<T>() where T : System.Enum
        // {
        //     var result = new Dictionary<int, string>();
        //     var values = Enum.GetValues(typeof(T));

        //     foreach (int item in values)
        //         result.Add(item, Enum.GetName(typeof(T), item));
        //     return result;
        // }
        enum Rainbow
        {
            Red,Orage,Yellow,Green,Blue,Indigo,Violet
        }
        static void Main(string[] args)
        {            
            ////Unmanaged constraint
            //Action first = () => Console.WriteLine("this");
            //Action second = () => Console.WriteLine("that");

            //var combined = first.TypeSafeCombine(second);
            //combined();
            //Func<bool> test = () => true;

            //Enum constraints
            // var map = EnumNamedValues<Rainbow>();

            // foreach (var pair in map)
            // {
            //     Console.WriteLine($"{pair.Key}:\t{pair.Value}");
            // }
                 

        }
    }
}
