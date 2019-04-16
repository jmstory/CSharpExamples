using System;

public delegate void Del(string message);
delegate void Delegate1();
delegate void Delegate2();

namespace UsingDelegates
{
    class Program
    {
        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }
        
        static void MethodWithCallback(int parm1, int parm2 , Del callback)
        {
            callback("The number is: " + (parm1+parm2).ToString());
        }
        public class MethodClass
        {
            public void Method1(string message){}
            public void Method2(string message){}
        }
        
        static void method(Delegate1 d , Delegate2 e , System.Delegate f)
        {
            //컴파일 에러
            //Console.WriteLine(d==e);

            //
            System.Console.WriteLine(d == f);
        }
        static void Main(string[] args)
        {
            Del handler = DelegateMethod;

            handler("DelegateMethod");            
            MethodWithCallback(1,2,handler);

            MethodClass obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            Del allMethodDelegate = d1 + d2;          
            allMethodDelegate += d3;
          
            allMethodDelegate -= d1;

            Del oneMethodDelegate = allMethodDelegate - d2;

            int invocationCount = d1.GetInvocationList().GetLength(0);

            


        }

      
    }
}
