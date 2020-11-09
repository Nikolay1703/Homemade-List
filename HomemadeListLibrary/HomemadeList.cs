using System;

namespace HomemadeListLibrary
{
    static public class HomemadeList
    {
        static public int[] IncreasingTheArrayByOneElement(int[] array)
        {
            int[] result = new int[array.Length + 1];
            return result;
        }

        static public int[] FillingTheArray(int[] array, int[] result)
        {
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            result[array.Length] = Convert.ToInt32(Console.ReadLine());

            return result;
        }
    }
}
