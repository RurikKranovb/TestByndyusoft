using TestByndy;

namespace TestByndyTests
{
    public class SumTwoMinimalTest
    {
        private SumTwoMinimal _sumTwoMinimalTest;

        [SetUp]
        public void Setup()
        {
            _sumTwoMinimalTest = new SumTwoMinimal();
        }

        [Test]
        public void BaseTest()
        {
            int[] array = { 4, 0, 3, 19, 492, -10, 1 };
            int result = _sumTwoMinimalTest.SumTwoMinimalMethod(array);
            Assert.That(-10 + 0, Is.EqualTo(result)); // -10 + 0 = -10
        }

        [Test]
        public void LargeArrayTest()
        {
            int[] array = Enumerable.Range(1, 1000000).ToArray();
            int result = _sumTwoMinimalTest.SumTwoMinimalMethod(array);
            Assert.That(1 + 2, Is.EqualTo(result)); //3
        }

        //[Test]
        //public void UnicodeLetterTest()
        //{
        //    object[] invalidArray = { "a", "5", "10" };
        //}


        [Test]
        public void NegativeNumbersTest()
        {
            int[] array = { -4, -3, -19, -492, -10, -1 };
            int result = _sumTwoMinimalTest.SumTwoMinimalMethod(array);
            Assert.That(-492 + -19, Is.EqualTo(result));
        }
    }
}
