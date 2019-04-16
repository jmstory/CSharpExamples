using System;

delegate void Del(int i , double j);
delegate void Del1();

namespace AnonymouseMethod
{    
    
    class SampleClass
    {
        public void InstanceMethod()
        {
            System.Console.WriteLine("A message from the instance method.");
        }

        static public void StaticMethod()
        {
            System.Console.WriteLine("A message from the static method.");
        }
    }
    class Program
    {
        void MultiplyNumbers(int m , double n)
        {
            System.Console.Write(m * n + " ");
        }
        static void Main(string[] args)
        {
            Program m = new Program();
            Del d = m.MultiplyNumbers;
            System.Console.WriteLine("Invoking the delegate using 'MultiplyNumbers' : ");
            for(int i = 1 ; i <=5 ;i++)
            {
                d(i,2);
            }
            System.Console.WriteLine("Press any key to exit");
            //System.Console.ReadKey();


            System.Console.WriteLine();
            //////////////////////////////////////////////////////////////////
            SampleClass ssc = new SampleClass();
            Del1 d1 = ssc.InstanceMethod;
            d1();

            d1 = SampleClass.StaticMethod;
            d1();
        }
    }
}
