using SampleIDLE.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleIDLE.Controllers
{
    internal class GeneratorController
    {
        public static void SetNumberToBuyForAllGenerators(Dictionary<string,Generator> generatorMap, int numberToBuy)
        {
            foreach(Generator generator in generatorMap.Values)
            {
                generator.NumberToBuy = numberToBuy;
            }
        }

        public static double GetTotalIncomePerSecond(Dictionary<string, Generator> generatorMap)
        {
            double totalIncome = 0;

            foreach (Generator generator in generatorMap.Values)
            {
                totalIncome += generator.Income;
            }

            return totalIncome;
        }
    }
}
