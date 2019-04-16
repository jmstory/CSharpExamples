using System;
using System.Linq;

namespace Anonymous_Function
{
    delegate void Printer(string s);
    class Program
    {
        delegate void TestDelegate(string s);
        static void M(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            //기본 딜리게이트 문법 초기화와 같이 메소드 이름
            TestDelegate testDelA = new TestDelegate(M);

            //C# 2.0 딜리게이트 초기화와 같이 인라인코드 , "anonymous method"라고 부름
            //이 메소드는 문자열 파라미터를 가진다
            TestDelegate testDelB = delegate(string s){Console.WriteLine(s);};

            //C# 3.0 딜리게이트 초기화와 같이 람다표현 , 이 람다또한 문자열 파라미터를 가진다
            //(x). The type of x is inferred by the compiler. << 이게 무슨말임?
            TestDelegate testDelC = (x) => {Console.WriteLine(x);};

            //딜리게이트 호출?
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");

            //Lambda Expressions
            Console.WriteLine();
            Console.WriteLine("Lambda Expressions");
            Func<int,int> square = x => x * x;
            Console.WriteLine(square(5));

            System.Linq.Expressions.Expression<Func<int,int>> e = x => x * x;
            Console.WriteLine(e);

            int []numbers = {2,3,4,5};
            var squareNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ",squareNumbers));

            //Expression 
            //(input-parameters) => expression;
            //Action line = () => Console.WriteLine();
            //Func<int,int,bool> testForEquality = (x,y) => x == y;
            //Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;

            //Statement 
            Action<string> greet = name=>{string greeting = $"Hello{name}"; Console.WriteLine(greeting);};
            greet("World");

            //Use Lambda Expressions in a Query
            Console.WriteLine();
            Console.WriteLine("Use Lambda Expressions in a Query");

            int[] scores = {90,71,82,93,75,82};
            int highScoreCount = scores.Where(n => n > 80).Count();
            Console.WriteLine("{0} scores are greater than 80",highScoreCount);


            //Anonymous Methods 
            Del d = delegate(int k){};

            //int n = 0;
            //Del d1 = delegate(){System.Console.WriteLine("Copy #:{0}", ++n);};

            //Instantiate the delegate type using an anonymous method.
            Printer p = delegate(string j){System.Console.WriteLine(j);};
            p("The delegate using the anonymous method is called."); 

            // The delegate instantiation using a named method "DoWork".
            p= DoWork;  
            p("The delegate using the named method is called.");         

        }

        // private static void TotalsByGradeLevel()
        // {
        //     var categories = from student in students
        //     group student by student.Year int studentGroup
        //     select new{GradeLevel = studentGroup.Key, 
        //     TotalScore = studentGroup.Sum(s => s.ExamScores.Sum())};

        //     foreach( var cat in categories)
        //     {
        //         Console.WriteLine("Key = {0} Sum = {1}",cat.GradeLevel, cat.TotalScore);
        //     }
        // }


        //Anonymous Methods 
        delegate void Del(int x);
        void StartThread()
        {
            System.Threading.Thread t1 = new System.Threading.Thread(delegate()
            { System.Console.Write("Hello, "); System.Console.WriteLine("World");});
            t1.Start();
        }
        static void DoWork(string k)
        {
            System.Console.WriteLine(k);
        }
        
    }

    
}
