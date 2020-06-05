using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PartOne.Conditions;

namespace PartOne.Processors
{
    public sealed class ConditionProcessor
    {
        /// <summary>
        /// Provides ability to process input
        /// </summary>

        private readonly List<ICondition> _conditions;

        /// <summary>
        /// Initialises an instance of <see cref="ConditionProcessor"/>
        /// </summary>
        /// <param name="condition">conditions to apply</param>
        public ConditionProcessor(IEnumerable<ICondition> conditions)
        {
            _conditions = (List<ICondition>)conditions;
        }

        /// <summary>
        /// Returns a processed string.
        /// </summary>
        /// <param name="input">number to apply to condition</param>
        public string Process(int input)
        {
            var processResult = "";
            var list = new List<string>();

            //place the non empty results of the operations in a list
            foreach (var c in _conditions)
            {
                var result = c.Condition(input);
                if ( result == string.Empty)
                {
                }
                else
                {
                    list.Add(result);
                }
            }

            //place the non empty results in a string
            foreach (var item in list)
            {
                processResult += item + " ";
            }

            //if results list didnt yield results send input back as string
            if (processResult == string.Empty)
            {
                processResult = input.ToString();
            }

            return processResult;
           //_conditions.TrueForAll(c => c.Condition(input)) ? string.Empty : input;
        }

    }
}





