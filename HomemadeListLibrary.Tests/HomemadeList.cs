using NUnit.Framework;
using HomemadeListLibrary;

namespace HomemadeListLibrary.Tests
{
    public class HomemadeList
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8)]
        [TestCase(new int[] { 1, 2, 3 }, 4)]
        public void IncreasingTheArrayByOneElement(int[] array, int expected)
        {
            int actual = HomemadeListLibrary.HomemadeList.IncreasingTheArrayByOneElement(array).Length;
            Assert.AreEqual(expected, actual);
        }


    }
}