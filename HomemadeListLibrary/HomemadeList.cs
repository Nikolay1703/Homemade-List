using System;

namespace HomemadeListLibrary
{
    static public class HomemadeList
    {
        static public int[] AddingAValueToTheEnd(int[] array)
        {
            int[] result = new int[array.Length + 1];

            for(int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }

            result[array.Length] = Convert.ToInt32(Console.ReadLine());

            return result;
        }
    }
}
