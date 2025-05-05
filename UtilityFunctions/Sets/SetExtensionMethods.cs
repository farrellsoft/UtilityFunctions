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
            var sourceList = source.ToList();
            
            if (other == null) throw new ArgumentNullException(nameof(other));
            var otherList = other.ToList();

            foreach (var item in sourceList)
            {
                if (!otherList.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
            foreach (var item in otherList)
            {
                if (!sourceList.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Map<T>(this IEnumerable<T> source, Action<T> mapFunc)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var sourceList = source.ToList();
            
            if (mapFunc == null) throw new ArgumentNullException(nameof(mapFunc));

            foreach (var item in sourceList)
            {
                mapFunc(item);
                yield return item;
            }
        }

        public static IEnumerable<T> Intersection<T>(this IEnumerable<T> source, IEnumerable<T> other, IEqualityComparer<T> comparer = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var sourceList = source.ToList();
            
            if (other == null) throw new ArgumentNullException(nameof(other));
            var otherList = other.ToList();

            foreach (var item in sourceList)
            {
                if (sourceList.Contains(item, comparer ?? EqualityComparer<T>.Default) &&
                    otherList.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Difference<T>(this IEnumerable<T> source, IEnumerable<T> other, IEqualityComparer<T> comparer = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var sourceList = source.ToList();
            
            if (other == null) throw new ArgumentNullException(nameof(other));
            var otherList = other.ToList();

            foreach (var item in sourceList)
            {
                if (!otherList.Contains(item, comparer ?? EqualityComparer<T>.Default))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Product<T>(this IEnumerable<T> source, IEnumerable<T> other, IEqualityComparer<T> comparer = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var sourceList = source.ToList();
            
            if (other == null) throw new ArgumentNullException(nameof(other));
            var otherList = other.ToList();
            
            var returnList = new List<T>(sourceList);
            foreach (var item in otherList)
            {
                if (returnList.Contains(item, comparer ?? EqualityComparer<T>.Default) == false)
                {
                    returnList.Add(item);
                }
            }
            
            return returnList;
        }

        public static IEnumerable<T> Complement<T>(this IEnumerable<T> source, IEnumerable<T> other, IEqualityComparer<T> comparer = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            var sourceList = source.ToList();
            
            if (other == null) throw new ArgumentNullException(nameof(other));
            var otherList = other.ToList();
            
            foreach (var item in otherList)
            {
                if (sourceList.Contains(item, comparer ?? EqualityComparer<T>.Default) == false)
                    yield return item;
            }
        }
    }
}