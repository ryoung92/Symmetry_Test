using System;
using System.Collections.Generic;
using System.Text;
using PartOne.Conditions;
using PartOne.Processors;

namespace PartOne
{
    internal sealed class PartOneProgram
    {
        public PartOneProgram()
        {
            var length = 100;
            var sb = new StringBuilder();
            //instansiate processor here
            var conditionProcessor = new ConditionProcessor(new List<ICondition>
            {
                new DivideByThree(),
                new DivideByFive()
            });

            for (int i = 1; i <= length; i++)
            {
                //process number with process
                //print
                //new line
                var result = conditionProcessor.Process(i);

                sb.AppendLine(result);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
