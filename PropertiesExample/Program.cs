// https://docs.microsoft.com/en-us/dotnet/csharp/properties

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonWithValidation hero = new PersonWithValidation();
            hero.FirstName = ""; // Exception 을 던져야 함
        }

        public class PersonContainsField
        {
            public string FirstName; // 여기서 FirstName은 Property가 아니고 Field임.
        }

        public class PersonContainsAutoImplementedProperty
        {
            // C# Version 3.0에서 추가된 기능.
            // get과 set 은 accecor라고 부름.
            public string FirstName { get; set; }
        }

        public class PersonContainsAutoPropertyInitializer
        {
            // C# Version 6.0에 추가된 기능
            // 원래는 FirstName은 null 이고 생성자에서 값을 지정해 줘야 되나 편의를 위해 바로 assign 할 수 있는 기능 추가.
            public string FirstName { get; set; } = string.Empty;
        }

        public class PersonContainsBasicProperty
        {
            // Accessor가 필드에 접근 하는 가장 기본적인 문법
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            private string firstName;
        }

        public class PersonContainsExpressionBodiedMember
        {
            // C# version 6.0에 추가됨. getter, setter 표현을 편하게 하기 위해.
            public string FirstName
            {
                get => firstName;
                set => firstName = value;
            }
            private string firstName;
        }

        public class PersonWithValidation
        {
            // @전민기: seeter에 null이나 빈문자열이 들어왔을 때 ArgumentException을 던지는 Property 구현
        }

        public class PersonWithValidationUsingExpressBodiedMember
        {
            // @전민기: seeter에 null이나 빈문자열이 들어왔을 때 ArgumentException을 던지는 Property 구현
            // PersonWitValidation 클래스와 동일한 FirstName Property를 ExpressionBodiedMember를 사용해 구현해 볼 것
        }

        public class PersonContainsReadOnlyProperty
        {
            // @전민기: ReadOnly property 구현
        }

        public class PersonContainsGetterOnly
        {
            // Expanded expression bodied members
            // C# Version 7.0에 추가됨
            // 아래 코드는 주석 처리된 생성자와 완전히 동일함
            // public PersonContainsGetterOnly(string firstName)
            // {
            //     this.FirstName = firstName;
            // }
            // const와 ReadOnly의 차이는 const는 compiletime에 결정 되고, readonly는 런타임에 생성자가 호출될 때 결정 됨.
            public PersonContainsGetterOnly(string firstName) => this.FirstName = firstName;

            public string FirstName { get; }
        }

        public class Measurements
        {
            // readonly property를 초기화 하는 가장 일반적인 방법.
            public ICollection<Point> points { get; } = new List<Point>();
        }

        public class PersonWithComputedProperty
        {
            // @전민기: 예제 구현 할 것
        }

        public class PersonWithComputedPropertyUsingExpressionBodiedMember
        {
            // @전민기: 예제 구현 할 것
        }

        public class PersonWithCachedEvaluatedProperty
        {
            // @전민기: 예제 구현할 것
            // 만약 기존에 호출된 적이 없으면 새로 값을 생성하고 기존에 Cached된 값이 있으면 그 값을 사용함.
        }

        public class PersonWithCachedEvaluatedProperty2
        {
            // @전민기: 예제 구현할 것
            // PersonWithCachedEvaluatedProperty 는 버그가 있음.
            // 어떤 버그가 있는지 예제 문서 확인하고 버그 없는 코드 구현
        }

        public class PersonWithAttachingAttribute
        {
            // @전민기: 예제 구현할 것.
            // C# 7.3에 추가된 기능.
            // 최신 기능이라 나도 잘 모름.
            // 예제 문서 확인하고 설명할 것.
        }

        public class Person : INotifyPropertyChanged
        {
            // @전민기: 예제 구현할 것.
            // INotifyPropertyChanged 인터페이스는 나중에 배울 것임.
            // INotifyPropertyChanged 빨간 줄(명칭:squiggle) 생긴 부분에서 ctrl + . 을 누르면 인터페이스 구현 자동으로 추가 할 수 있음.
        }
    }
}
