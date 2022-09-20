using SampleIDLE.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleIDLE.Controllers
{
    internal class BonusController
    {
        public class BonusType
        {
            public double Global;
            public double GlobalArchivement;
            public double GeneratorMilestone = 1;
            public double EventBuff;
        }
        public static void SetBonusGlobal(Dictionary<string,Generator> generatorMap, double multiplier)
        {
            foreach(var generator in generatorMap.Values)
            {
                generator.Bonus.Global = multiplier;
            }
        }

        public static void SetBonusEventBuff(Dictionary<string, Generator> generatorMap, double multiplier)
        {
            foreach(var generator in generatorMap.Values)
            {
                generator.Bonus.EventBuff = multiplier;
            }
        }

        public static void SetBonusGlobalAchivement(Dictionary<string, Generator> generatorMap, double multiplier)
        {
            foreach (var generator in generatorMap.Values)
            {
                generator.Bonus.GlobalArchivement = multiplier;
            }
        }
    }
}
