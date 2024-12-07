using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data= File.ReadAllLines("input.txt");

            List<int> firstList = data.Select(x => Convert.ToInt32(x.Split(' ')[0])).OrderBy(x=>x).ToList();
            List<int> selcondList = data.Select(x => Convert.ToInt32(x.Split(' ')[3])).OrderBy(x => x).ToList();
            List<int> distance = new List<int>();

            for (int i = 0; i < data.Length; i++)
            {
                distance.Add(Math.Abs(firstList[i] - selcondList[i]));
            }

            Console.WriteLine(distance.Sum());
            Console.ReadKey();

        }
    }
}
