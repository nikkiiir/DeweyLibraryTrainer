using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyLibraryTrainer
{
    public static class ShuffleList
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int i = list.Count;

            while (i > 1)
            {
                Random random = new Random();
                i--;
                int j = random.Next(i + 1);
                // Randomize the list<T>
                // Using Fisher-Yates shuffle
                T value = list[j];
                list[j] = list[i];
                list[i] = value;
            }
        }
    }
}
