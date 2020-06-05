using API;

namespace PartTwo.Conditions
{
    public class DivideByFive : ICondition
    {
        public string Condition(int input)
        {
            if (input % 5 == 0)
            {
                return "Buff";
            }

            return string.Empty;
        }
    }
}
