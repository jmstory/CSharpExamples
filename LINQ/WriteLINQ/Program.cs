using System;
using System.Collections.Generic;
using System.Linq;

namespace WriteLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){5,4,1,3,9,8,6,7,2,0};
            //Query Syntax
            {
                //#1
                IEnumerable<int> filteringQuery = from num in numbers 
                                        where num < 3 || num > 7 select num;

                //#2
                IEnumerable<int> orderingQuery = from num in numbers where num < 3 || num > 7
                                                    orderby num ascending select num;

                //#3
                string[] groupingQuery = {"carrots", "cabbage", "brocoli", "beans", "barley"};
                IEnumerable<IGrouping<char, string>> queryFoodGroups = from item in groupingQuery
                                                                        group item by item[0];
            }

            List<int> numbers1 = new List<int>(){5,4,1,3,9,8,6,7,2,0};
            List<int> numbers2 = new List<int>(){15,14,11,13,19,18,16,17,12,10};
            //Method Syntax
            {
                //#4
                double avrage = numbers1.Average();

                //#5
                IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);

                //#6
                IEnumerable<int> largeNumbersQuery = numbers2.Where(c => c > 15);
            }     

            //Mixed query and method syntax
            {
                //#7
                int numCount1 = (from num in numbers1 where num < 3 || num > 7 select num).Count();

                //Better
                IEnumerable<int> numbersQuery = from num in numbers1 
                                                    where num < 3 || num > 7 select num;   
            
                int numCount2 = numbersQuery.Count();
            }

            var numCount = numbers.Where(n => n < 3 || n > 7).Count();
            int numCount3 = numbers.Where(n => n < 3 || n > 7).Count();


            
        }
    }
}
