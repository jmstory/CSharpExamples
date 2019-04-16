using System;
using System.Collections.Generic;

namespace SystemDotDelegateAndTheDelegateKeyword
{
    
    class Program
    {
        public static Comparison<string> comparator; // System.Comparison<T>. F12 눌러서 확인.

        private static int CompareLength( string left, string right) =>
            left.Length.CompareTo(right.Length);

        static void Main(string[] args)
        {
            // Invoking Delegates
            comparator = CompareLength; 
            // CompareLength 메서드를 만들지 않고 lambda식으로 아래 주석 처럼 사용 가능
            // comparator = (left, right) => left.Length.CompareTo(right.Length); 
            Console.WriteLine(comparator("Dread Monarch", "Eurynome"));
            Console.WriteLine(comparator("12345678", "Eurynome"));
            Console.WriteLine(comparator("Eurynome", "Dread Monarch"));


            List<string> phrases = new List<string> 
            {
                "Hello",
                "World!",
                "My",
                "name",
                "is",
                "toilet2000",
            };

            Console.WriteLine("=== Original data ===");
            foreach( var s in phrases)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine("=== order by string length ===");
            phrases.Sort(comparator);           // List<T>.Sort의 파라미터로 Comparison<T> 사용
            phrases.ForEach(Console.WriteLine); // List<T>.ForEach 파라미터에 메소드 직접사용

            

            
            Console.WriteLine("=== order by string length desc===");
            phrases.Sort((l, r) => r.Length.CompareTo(l.Length)); // List<T>.Sort의 파라미터로 Comparison<T> 사용
            phrases.ForEach((s) => Console.WriteLine(s)); // List<T>.ForEach 파라미터로 Lambda expression 사용
        }

        
        
        
    }
}
