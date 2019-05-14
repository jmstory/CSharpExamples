using System;
public delegate void Action();
public delegate void Action<in T>(T arg);
public delegate void Action<in T1, in T2>(T1 arg1 , T2 arg2);

public delegate TResult Func<out TResult>();
public delegate TResult Func<in T1, out TResult>(T1 arg);
public delegate TResult Func<in T1 , in T2 , out TResult>(T1 arg1 , T2 arg2);

public delegate bool Predicate<in T>(T obj);
namespace StronglyTypedDelegate
{
    class Program
    {
        Func<string, bool> TestForString;
        Predicate<string> AnotherTestForString;
        static void Main(string[] args)
        {
           
        }
    }
}
