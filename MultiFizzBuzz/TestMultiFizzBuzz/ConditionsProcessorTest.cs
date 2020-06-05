using Microsoft.VisualStudio.TestTools.UnitTesting;
using API;
using PartOne.Processors;
using NSubstitute;
using System.Collections.Generic;

namespace TestMultiFizzBuzz
{
    [TestClass]
    public class ConditionsProcessorTest
    {

        [TestMethod]
        public void Returns_Fizz_if_input_is_Divisble_by_Three()
        {
            //arrage
            var input = 3;
            var expected = "Fizz";
            var fizzReturnCondition = Substitute.For<ICondition>();
            fizzReturnCondition
               .Condition(Arg.Any<int>())
               .Returns("Fizz");
            var conditions = new List<ICondition> { fizzReturnCondition };
            var conditionsProcessor = new ConditionProcessor(conditions);

            //act
            var actual = conditionsProcessor.Process(input);

            fizzReturnCondition.Received(1).Condition(Arg.Any<int>());

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Returns_Buzz_if_input_is_Divisble_by_Five()
        {
            //arrage
            var input = 5;
            var expected = "Buzz";
            var buzzReturnCondition = Substitute.For<ICondition>();
            buzzReturnCondition
               .Condition(Arg.Any<int>())
               .Returns("Buzz");

            var conditions = new List<ICondition> { buzzReturnCondition };
            var conditionsProcessor = new ConditionProcessor(conditions);

            //act
            var actual = conditionsProcessor.Process(input);

            buzzReturnCondition.Received(1).Condition(Arg.Any<int>());

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns_Fizz_Buzz_if_input_is_Divisble_by_Three_and_Five()
        {
            //arrage
            var input = 15;
            var expected = "Fizz Buzz";
            var divideByThreeCondition = Substitute.For<ICondition>();
            var divideByFiveCondition = Substitute.For<ICondition>();


            divideByThreeCondition
               .Condition(Arg.Any<int>())
               .Returns("Fizz");


            divideByFiveCondition
               .Condition(Arg.Any<int>())
               .Returns("Buzz");

            var conditions = new List<ICondition>
            {
                divideByThreeCondition,
                divideByFiveCondition
            };
            var conditionsProcessor = new ConditionProcessor(conditions);

            //act
            var actual = conditionsProcessor.Process(input);

            divideByThreeCondition.Received(1).Condition(Arg.Any<int>());
            divideByFiveCondition.Received(1).Condition(Arg.Any<int>());

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Returns_Buff_if_input_is_Divisble_by_Five()
        {
            //arrage
            var input = 5;
            var expected = "Buff";
            var buffReturnCondition = Substitute.For<ICondition>();
            buffReturnCondition
               .Condition(Arg.Any<int>())
               .Returns("Buff");
            var conditions = new List<ICondition> { buffReturnCondition };
            var conditionsProcessor = new ConditionProcessor(conditions);

            //act
            var actual = conditionsProcessor.Process(input);

            buffReturnCondition.Received(1).Condition(Arg.Any<int>());

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Returns_Six_if_input_is_Divisble_by_Six()
        {
            //arrage
            var input = 6;
            var expected = "Six";
            var sixReturnCondition = Substitute.For<ICondition>();
            sixReturnCondition
               .Condition(Arg.Any<int>())
               .Returns("Six");
            var conditions = new List<ICondition> { sixReturnCondition };
            var conditionsProcessor = new ConditionProcessor(conditions);

            //act
            var actual = conditionsProcessor.Process(input);

            sixReturnCondition.Received(1).Condition(Arg.Any<int>());

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Returns_Foo_if_input_is_Divisble_by_Eleven()
        {
            //arrage
            var input = 6;
            var expected = "Foo";
            var fooReturnCondition = Substitute.For<ICondition>();
            fooReturnCondition
               .Condition(Arg.Any<int>())
               .Returns("Foo");
            var conditions = new List<ICondition> { fooReturnCondition };
            var conditionsProcessor = new ConditionProcessor(conditions);

            //act
            var actual = conditionsProcessor.Process(input);

            fooReturnCondition.Received(1).Condition(Arg.Any<int>());

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Returns_Buff_Six_Foo_if_input_is_Divisble_by_Three_and_Five()
        {
            //arrage
            var input = 330;
            var expected = "Buff Six Foo";
            var divideByFiveCondition = Substitute.For<ICondition>();
            var divideBySixCondition = Substitute.For<ICondition>();
            var divideByElevenCondition = Substitute.For<ICondition>();


            divideByFiveCondition
               .Condition(Arg.Any<int>())
               .Returns("Buff");


            divideBySixCondition
               .Condition(Arg.Any<int>())
               .Returns("Six");

            divideByElevenCondition
                .Condition(Arg.Any<int>())
                .Returns("Foo");

            var conditions = new List<ICondition>
            {
                divideByFiveCondition,
                divideBySixCondition,
                divideByElevenCondition
            };
            var conditionsProcessor = new ConditionProcessor(conditions);

            //act
            var actual = conditionsProcessor.Process(input);

            divideByFiveCondition.Received(1).Condition(Arg.Any<int>());
            divideBySixCondition.Received(1).Condition(Arg.Any<int>());
            divideByElevenCondition.Received(1).Condition(Arg.Any<int>());

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}
