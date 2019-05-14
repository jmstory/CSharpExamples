using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryExpressionBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            IEnumerable<int> highScoresQuery = from score in scores where score > 80
            orderby score descending select score;

            IEnumerable<string> highScoresQuery2 = from score in scores where score > 80
            orderby score descending select $"The score is {score}";

            int highScoreCount = (from score in scores where score > 80 select score).Count();

            IEnumerable<int> highScoresQuery3 = from score in scores where score >80 select score;

            int scoreCount = highScoresQuery3.Count();

            //쿼리 변수
            IEnumerable<int> scoreQuery = //쿼리 변수
                from score in scores //요청
                where score > 80 // 옵션
                orderby score descending // 옵션
                select score; //데이터 선택 또는 그룹

                foreach(int testScore in scoreQuery)
                {
                    Console.WriteLine(testScore);
                }

            // //쿼리 문법
            // IEnumerable<City> queryMajorCities = from city in queryMajorCities 
            //     where city.Population > 10000 select city;

            // //메소드 문법
            // IEnumerable<City> queryMajorCities2 = cities.Where(c => c.Population > 100000);

            //초기화를 쿼리로 하지만 쿼리가 아닌 변수
            int highestScore = (from score in scores select score).Max();
            
            //스플릿 익스프레션
            IEnumerable<int> scoreQuery2 = from score in scores select score;

            int highScore = scoreQuery2.Max();

            // List<City> largeCitiesList =
            //     (from country in countries
            //     from city in country.Cities
            //     where city.Population > 10000
            //     select city)
            //     .ToList();

            // // 스플릿 익스프레션
            // IEnumerable<City> largeCitiesQuery =
            //     from country in countries
            //     from city in country.Cities
            //     where city.Population > 10000
            //     select city;

            // List<City> largeCitiesList2 = largeCitiesQuery.ToList();

            // //Explicit and implicit typing of query variables
            // var queryCities =
            //     from city in cities
            //     where city.Population > 100000
            //     select city;

            ////Starting a query expression
            // IEnumerable<Country> countryAreaQuery =
            //     from country in countries
            //     where country.Area > 500000 //sq km
            //     select country;

            // IEnumerable<City> cityQuery =
            //     from country in countries
            //     from city in country.Cities
            //     where city.Population > 10000
            //     select city;

            // //Ending a query expression
            // var queryCountryGroups =
            //     from country in countries
            //     group country by country.Name[0];

            // IEnumerable<Country> sortedQuery =
            //     from country in countries
            //     orderby country.Area
            //     select country;

            ////anonymous type
            //var queryNameAndPop = from country in countries 
            //select new { Name = country.Name, Pop = country.Population };

            ////Continuations with "into"
            // var percentileQuery =
            //     from country in countries
            //     let percentile = (int) country.Population / 10_000_000
            //     group country by percentile into countryGroup
            //     where countryGroup.Key >= 20
            //     orderby countryGroup.Key
            //     select countryGroup;
            // foreach (var grouping in percentileQuery)
            // {
            //     Console.WriteLine(grouping.Key);
            //     foreach (var country in grouping)
            //         Console.WriteLine(country.Name + ":" + country.Population);
            // }

            ////Filtering, ordering, and joining
            ////where clause
            // IEnumerable<City> queryCityPop =
            //     from city in cities
            //     where city.Population < 200000 && city.Population > 100000
            //     select city;

            ////orderby clause
            // IEnumerable<Country> querySortedCountries =
            //     from country in countries
            //     orderby country.Area, country.Population descending
            //     select country;

            ////join clause
            // var categoryQuery =
            //     from cat in categories
            //     join prod in products on cat equals prod.Category
            //     select new { Category = cat, Name = prod.Name };


            //let clause
            string[] names = {"a t","b t","c t", "d t"};
            IEnumerable<string> queryFirstNames = from name in names 
            let firstName = name.Split(' ')[0] select firstName;

            foreach(string s in queryFirstNames)
            {
                Console.Write(s + " ");
            }

            // //Subqueries in a query expression
            // var queryGroupMax = from student in students group student
            // by student.GradeLevel into studentGroup select new
            // {
            //     Level = studentGroup.Key,
            //     HighestScore = (from student2 in studentGroup select student2.Scores.Average()).Max()
            // }

        }
    }
}
