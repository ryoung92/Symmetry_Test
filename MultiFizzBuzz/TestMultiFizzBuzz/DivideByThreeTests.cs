using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartOne.Conditions;

namespace TestMultiFizzBuzz
{
    [TestClass]
    public class DivideByThreeTests
    {

        [TestMethod]
        public void Returns_Fizz_if_Divisble_by_Three()
        {
            //arrage
            string expected = "Fizz";
            int input = 3;
            var divideByThree = new DivideByThree();

            //act
            var actual = divideByThree.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns_string_empty_if_Divisble_by_Three()
        {
            //arrage
            string expected = string.Empty;
            int input = 2;
            var divideByThree = new DivideByThree();

            //act
            var actual = divideByThree.Condition(input);

            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}
