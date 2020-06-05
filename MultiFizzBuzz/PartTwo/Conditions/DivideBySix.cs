using API;

namespace PartTwo.Conditions
{
    public class DivideBySix : ICondition
    {
        public string Condition(int input)
        {
            if (input % 6 == 0)
            {
                return "Six";
            }

            return string.Empty;
        }
    }
}
