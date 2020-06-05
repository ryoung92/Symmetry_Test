using API;

namespace PartTwo.Conditions
{
    public class DivideByEleven : ICondition
    {
        public string Condition(int input)
        {
            if (input % 11 == 0)
            {
                return "Foo";
            }

            return string.Empty;
        }
    }
}
