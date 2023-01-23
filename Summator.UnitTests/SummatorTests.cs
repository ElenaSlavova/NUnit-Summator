namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPossitiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNeggativeNumbers()
        {
            var nums = new int[] { -1, -29 };
            var actual = Summator.Sum(nums);
            var expected = -30;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);
            var expected = 6000000000;

            Assert.AreEqual(expected, actual);
        }

        // AverageTests

        [Test]
        public void Test_Average_SumOfPossitiveNumbers()
        {
            var nums = new int[] { 1, 5, 4, 2 };
            var actual = Summator.Average(nums, "add");
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_SumOfNeggativeNumbers()
        {
            var nums = new int[] { -1, -50, -9 };
            var actual = Summator.Average(nums, "add");
            var expected = -20;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000 };
            var actual = Summator.Average(nums, "add");
            var expected = 2000000000;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_MyltiplyOfPossitiveNumbers()
        {
            var nums = new int[] { 3, 6, 9 };
            var actual = Summator.Average(nums, "multiply");
            var expected = 54;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_MyltiplyOfNegaitiveNumbers()
        {
            var nums = new int[] { -2, -4, -6 };
            var actual = Summator.Average(nums, "multiply");
            var expected = -16;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_MyltiplyOfBigNumbers()
        {
            var nums = new int[] { 20000, 200000 };
            var actual = Summator.Average(nums, "multiply");
            var expected = 2000000000;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_SubstractOfPossitiveNumbers()
        {
            var nums = new int[] { 100, 50, 5, 5 };
            var actual = Summator.Average(nums, "substract");
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_SubstractOfNeggativeNumbers()
        {
            var nums = new int[] { -70, -5, -5 };
            var actual = Summator.Average(nums, "substract");
            var expected = -20;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_SubstractNumbers()
        {
            var nums = new int[] { 2000000000, 1000000000 };
            var actual = Summator.Average(nums, "substract");
            var expected = 500000000;

            Assert.AreEqual(expected, actual);
        }
    }
}