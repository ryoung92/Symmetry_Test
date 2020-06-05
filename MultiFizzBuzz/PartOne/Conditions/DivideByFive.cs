using API;
namespace PartOne.Conditions
{
    public class DivideByFive : ICondition
    {
        public string Condition(int input)
        {
            if (input % 5 == 0)
            {
                return "Buzz";
            }

            return string.Empty;
        }
    }
}
