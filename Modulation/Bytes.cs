using System;
using System.Linq;

namespace Modulation
{
    public static class Bytes
    {
        private static readonly Random Rnd = new Random();

        /// <summary>
        /// Сгенерировать бит. последовательность указанной длины.
        /// </summary>
        /// <param name="array_lenght">Длина бит. последовательности.</param>
        /// <returns>Целочисленный массив с бит. последовательностью указанной длины.</returns>
        public static int[] Generate_Byte_Array(int array_lenght)
        {
            var array = new int[array_lenght];
            for (var i = 0; i < array_lenght; i++) array[i] = Rnd.Next(2);
            return array;
        }

        /// <summary>
        /// Преобразовать целочисленный массив с битовой последовательностью в строку.
        /// </summary>
        /// <param name="arr">Целочисленный массив с битовой последовательностью.</param>
        /// <returns>Строка с битовой последовательностью.</returns>
        public static string Byte_Array_ToString(int[] array)
        {
            return array.Aggregate("", (current, d) => current + d);
        }
    }
}
