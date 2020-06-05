using API;
using System.Collections.Generic;
using System.Linq;

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
            var list = new List<string>();

            //place the non empty results of the operations in a list
            foreach (var c in _conditions)
            {
                var result = c.Condition(input);
                if (!string.IsNullOrEmpty(result))
                {
                    list.Add(result);
                }

            }

            if (list.Count > 1)
            {
               return string.Join(" ", list);
            }

            return list.FirstOrDefault() ?? input.ToString();

        }

    }
}





