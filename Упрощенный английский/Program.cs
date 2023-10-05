using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упрощенный_английский
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int Search(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element)
                    return i;

            return -1;
        }
    }
}
