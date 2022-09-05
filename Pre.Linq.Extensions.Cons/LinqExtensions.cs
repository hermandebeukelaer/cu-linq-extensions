using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Linq.Extensions.Cons
{
    public static class LinqExtensions
    {
        private static readonly Random random = new Random();

        public static IEnumerable<int> ElementsAtEvenPositions(this IEnumerable<int> enumerable)
        {
            bool evenIndex = true;
            foreach(int number in enumerable)
            {
                if (evenIndex)
                {
                    yield return number;
                }
                evenIndex = !evenIndex;
            }
        }

        public static IEnumerable<T> ElementsAtEvenPositions<T>(this IEnumerable<T> enumerable)
        {
            bool evenIndex = true;
            foreach (T element in enumerable)
            {
                if (evenIndex)
                {
                    yield return element;
                }
                evenIndex = !evenIndex;
            }
        }

        public static int TakeRandom(this IEnumerable<int> enumerable)
        {
            int randomIndex = random.Next(enumerable.Count());
            return enumerable.ElementAt(randomIndex);
        }

        public static T TakeRandom<T>(this IEnumerable<T> enumerable)
        {
            int randomIndex = random.Next(enumerable.Count());
            return enumerable.ElementAt(randomIndex);
        }
    }
}
