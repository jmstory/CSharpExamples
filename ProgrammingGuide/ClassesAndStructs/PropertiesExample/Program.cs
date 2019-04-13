// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

using System;
using System.Runtime.CompilerServices;

namespace PropertiesExample
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // @전민기: 아래 세 메서드를 모두 호출 가능하게 작업할 것
            DemoPropertiesWithBackingFields();
            DemoExpressionBodyDefinitions();
            DemoAutoImplementedProperties();
        }

        public class TimePeriod
        {
            private double _seconds;
            public double Hours
            {
                get{return _seconds/3600;}
                set
                {
                    if(value < 0 || value > 24)
                    {
                        throw new ArgumentOutOfRangeException(
                            $"{nameof(value)} must be between 0 and 24.");                          
                    }
                    _seconds = value * 3600;
                   
                }
            }
        }
        static void DemoPropertiesWithBackingFields()
        {
            WriteMethodName();

            // @전민기: TimePeriod 구현할 것
            TimePeriod t = new TimePeriod();
            // The property assignment causes the 'set' accessor to be called.
            t.Hours = 24;
            // Retrieving the property causes the 'get' accessor to be called.
            Console.WriteLine($"Time in hours: {t.Hours}");
        }

        public class Person
        {
            private string _firstName;
            private string _lastName;
            public Person(string first , string last)
            {
                _firstName = first;
                _lastName = last;
            }
            public string Name => $"{_firstName} {_lastName}";
        }

        public class SaleItem
        {
            string _name;
            decimal _cost;
            public SaleItem(string name ,decimal cost)
            {
                _name = name;
                _cost = cost;
            }
            public string Name
            {
                get => _name;
                set => _name = value;
            }
            public decimal Price
            {
                get => _cost;
                set => _cost = value;
            }
        }
        static void DemoExpressionBodyDefinitions()
        {
            WriteMethodName();

            // @전민기: Person, SaleItem 구현할 것
            var person = new Person("Isabelle", "Butts");
            Console.WriteLine(person.Name);
            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }

        public class SaleItemAuto
        {
            public string Name{ get; set; }

            public decimal Price{ get; set; }
        }
        static void DemoAutoImplementedProperties()
        {
            WriteMethodName();
            
            // @전민기: Auto-implemented property를 이용하는 SaleItemAuto 구현할 것
            var item = new SaleItemAuto{ Name = "Shoes", Price = 19.95m };
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }

        static void WriteMethodName([CallerMemberName]string name="")
        {
            Console.WriteLine($"==== {name} ====");
        }
    }
}
