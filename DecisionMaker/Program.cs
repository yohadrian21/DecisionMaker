using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> DecisionList = new List<string>();
            DecisionList.Add("Yes");
            DecisionList.Add("No");
            DecisionList.Add("Maybe");
            DecisionList.Add("Ask your Friend");
            DecisionList.Add("Ask your Best Friend");
            DecisionList.Add("Maybe you should think it");
            DecisionList.Add("How about NO?");
            DecisionList.Add("How About Yes");

            var random = new Random();
            int index = random.Next(DecisionList.Count);
            Console.WriteLine(DecisionList[index]);

        }
    }
}
