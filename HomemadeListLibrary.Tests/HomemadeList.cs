using NUnit.Framework;
using HomemadeListLibrary;

namespace HomemadeListLibrary.Tests
{
    public class HomemadeList
    {
        [TestCase(new int[] {1, 2, 3, 4, 5}, new int[] {1, 2, 3, 4, 5, 6})]
        public void AddingAValueToTheEnd(int[] array, int[] expected)
        {
            int[] actual = HomemadeListLibrary.HomemadeList.AddingAValueToTheEnd(array);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}