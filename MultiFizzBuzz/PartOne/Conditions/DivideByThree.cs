using API;

namespace PartOne.Conditions
{
    public class DivideByThree : ICondition
    {
        public string Condition(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }

            return string.Empty;
        }
    }
}
