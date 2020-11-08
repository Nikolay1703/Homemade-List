using System;
using HomemadeListLibrary;

namespace HomemadeList
{
    class HomemadeList
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(String.Join(" ", array));
            int[] result = HomemadeListLibrary.HomemadeList.AddingAValueToTheEnd(array);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
