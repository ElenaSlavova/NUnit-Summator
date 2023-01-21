namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPossitiveNumbers()
        {
            int[] nums = new int[] { 1, 2 };
            int actual = Summator.Sum(nums);
            int expected = 3;

            Assert.AreEqual(expected, actual);  


        }

        [Test]
        public void Test_Summator_SumTwoNeggativeNumbers()
        {
            int[] nums = new int[] { -1, -29 };
            int actual = Summator.Sum(nums);
            int expected = -30;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            int[] nums = new int[] { 6 };
            int actual = Summator.Sum(nums);
            int expected = 6;

            Assert.AreEqual(expected, actual);

        }


    }
}