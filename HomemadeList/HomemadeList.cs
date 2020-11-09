using System;
using HomemadeListLibrary;

namespace HomemadeList
{
    class HomemadeList
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(" ", array));
            int[] result = HomemadeListLibrary.HomemadeList.IncreasingTheArrayByOneElement(array);
            Console.WriteLine(string.Join(" ", HomemadeListLibrary.HomemadeList.FillingTheArray(array, result)));
        }
    }
}
