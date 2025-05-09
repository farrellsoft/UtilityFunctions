
namespace Farrellsoft.UtilityFunctions
{
    public static class SetHelperExtensionMethods
    {
        public static bool None<T>(this IEnumerable<T> source, Func<T, bool>? predicate = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            return predicate == null
                ? !source.Any()
                : !source.Any(predicate);
        }
    }
}