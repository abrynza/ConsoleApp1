using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<CaseInfo> caseList = new List<CaseInfo>();
            for(int ii = 0; ii < 10000; ii++)
            {
                caseList.Add(new CaseInfo { Id = ii, Details = (ii + ii).ToString() });
            }

            IEnumerable<CaseInfo> query = from item in caseList
                                          where item.Id % 2 == 0
                                          select item;

            foreach (var item in query)
                Console.WriteLine("CaseId:" + item.Id + ", CaseDetails:" + item.Details);
        }
    }
}