using API;
using System;
using System.Collections.Generic;
using System.Text;
using PartOne.Processors;
using PartTwo.Conditions;

namespace PartTwo
{
    internal sealed class PartTwoProgram
    {
        public PartTwoProgram()
        {
            var length = 100;
            var sb = new StringBuilder();
            //instansiate processor here
            var conditionProcessor = new ConditionProcessor(new List<ICondition>
            {
                new DivideByFive(),
                new DivideBySix(),
                new DivideByEleven()
            });

            for (int i = 1; i <= length; i++)
            {
                var result = conditionProcessor.Process(i);

                sb.AppendLine(result);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
