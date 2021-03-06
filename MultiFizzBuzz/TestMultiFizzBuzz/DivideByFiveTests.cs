using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartOne.Conditions;

namespace TestMultiFizzBuzz
{
    [TestClass]
    public class DivideByFiveTests
    {

        [TestMethod]
        public void Returns_Buzz_if_Divisble_by_Five()
        {
            //arrage
            string expected = "Buzz";
            int input = 5;
            var divideByFive = new DivideByFive();

            //act
            var actual = divideByFive.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns_string_empty_if_not_Divisble_by_Five()
        {
            //arrage
            string expected = string.Empty;
            int input = 4;
            var divideByFive = new DivideByFive();

            //act
            var actual = divideByFive.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
