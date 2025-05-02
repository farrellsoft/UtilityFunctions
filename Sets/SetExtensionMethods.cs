using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farrellsoft.UtilityFunctions
{
    public static class SetExtensionMethods
    {
        public static IEnumerable<T> SymmetricDifference<T>(this IEnumerable<T> source, IEnumerable<T> other, IEqualityComparer<T> comparer = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (other == null) throw new ArgumentNullException(nameof(other));

            foreach (var item in source)
            {
                if (!other.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
            foreach (var item in other)
            {
                if (!source.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Map<T>(this IEnumerable<T> source, Action<T> mapFunc)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (mapFunc == null) throw new ArgumentNullException(nameof(mapFunc));

            foreach (var item in source)
            {
                mapFunc(item);
                yield return item;
            }
        }

        public static IEnumerable<T> Intersection<T>(this IEnumerable<T> source, IEnumerable<T> other, IEqualityComparer<T> comparer = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (other == null) throw new ArgumentNullException(nameof(other));

            foreach (var item in source)
            {
                if (source.Contains(item, comparer ?? EqualityComparer<T>.Default) &&
                    other.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Difference<T>(this IEnumerable<T> source, IEnumerable<T> other, IEqualityComparer<T> comparer = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (other == null) throw new ArgumentNullException(nameof(other));

            foreach (var item in source)
            {
                if (!other.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
        }
    }
}