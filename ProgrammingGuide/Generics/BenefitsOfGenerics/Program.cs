using System;
using System.Collections.Generic;

namespace BenefitsOfGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1 닷넷 버전 생성법
            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            list1.Add(3);
            list1.Add(105);

            System.Collections.ArrayList list2 = new System.Collections.ArrayList();
            list2.Add("It is rainning in Redmond.");
            list2.Add("It is snowing in the mountains.");

            System.Collections.ArrayList list = new System.Collections.ArrayList();
            list.Add("It is raining in Redmond.");

            int t = 0;
            foreach(int x  in list)
            {
                t += x;
            }

            //2.0 닷넷 버전 생성방법
            List<int> list20 = new List<int>();
            list20.Add(3);
        }
    }
}
