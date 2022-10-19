using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_facultate.src
{
    public class Exercise1
    {
        private List<int> arrayOfInts;
        public Exercise1()
        {
            arrayOfInts = new List<int>();
        }
        public void AddInts()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            while (number % 100 != 0)
            {
                arrayOfInts.Add(number);
                number = int.Parse(Console.ReadLine());
            }
        }
        public void PrintList()
        {
            foreach(int number in arrayOfInts)
            {
                Console.WriteLine(number);
            }
        }
    }
}
