using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartTwo.Conditions;

namespace TestMultiFizzBuzz.PartTwoTests
{ 
    [TestClass]
    public class DivideByElevenTest
    {

        [TestMethod]
        public void Returns_Eleven_if_Divisble_by_Eleven()
        {
            //arrage
            string expected = "Foo";
            int input = 11;
            var divideByEleven = new DivideByEleven();

            //act
            var actual = divideByEleven.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns_string_empty_if_not_Divisble_by_Eleven()
        {
            //arrage
            string expected = string.Empty;
            int input = 4;
            var divideByEleven = new DivideByEleven();

            //act
            var actual = divideByEleven.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
