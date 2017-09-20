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
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 4, 5, 2 };
            string  order = "desc";
            SuperRobot.Task a = new SuperRobot.Task();

            //Testing total no of chips
            int count = a.nochips;
            //Testing array sorting
            array = a.sortArray(array, order);
            //Testing Sum of array
            int Sum =  a.SumOfArray(array);
            //Testing donotreturnanything
            a.donotreturnanything();
        }
    }
}
