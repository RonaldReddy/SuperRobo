using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRobot;


namespace TestClinet
{
    class Program
    {
        public static int nochips = 2;
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 4, 5, 2 };
            string  order = "desc";
            SuperRobot.Task a = new SuperRobot.Task();
            int count = a.nochips;
            array = a.sortArray(array, order);
            int totalelements =  a.SumOfArray(array);
            a.donotreturnanything();
        }
    }
}
