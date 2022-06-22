using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string HeroName = "leon";
            double HeroHeight = 187.5 + 5;
            int HeroAge = 27;
            string HeroSuperPower = "super double kick";
            string VillainName = "Nemesis";
            double villainHeight = 210.2;
            int villainAge = 32;
            string villainSuperPower = "None";
            int AgeDifference = HeroAge - villainAge;
            Console.WriteLine(" my Name" + HeroName + " MY age is " + HeroAge + " My Super powers is " + HeroSuperPower + " My height is " + HeroHeight);
            Console.WriteLine(" I am the villain and My Name is " + VillainName + " My age is " + villainAge + " My height is " + villainHeight + " my super powers is " + villainSuperPower);
        }
    }
}
