using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartTwo.Conditions;

namespace TestMultiFizzBuzz.PartTwoTests
{
    [TestClass]
    public class DivideBySixTests
    {

        [TestMethod]
        public void Returns_Six_if_Divisble_by_Six()
        {
            //arrage
            string expected = "Six";
            int input = 6;
            var divideBySix = new DivideBySix();

            //act
            var actual = divideBySix.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns_string_empty_if_not_Divisble_by_Six()
        {
            //arrage
            string expected = string.Empty;
            int input = 4;
            var divideBySix = new DivideBySix();

            //act
            var actual = divideBySix.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
