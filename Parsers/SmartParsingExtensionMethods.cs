
namespace UtilityFunctions.Parsers
{
    public static class SmartParsingExtensionMethods
    {
        public static int AsInt(this string str, int defaultValue = int.MinValue)
        {
            if (int.TryParse(str, out int result))
            {
                return result;
            }

            return defaultValue;
        }

        public static int? AsInt(this string str)
        {
            if (int.TryParse(str, out int result))
            {
                return result;
            }

            return null;
        }

        public static long AsLong(this string str, long defaultValue = long.MinValue)
        {
            if (long.TryParse(str, out long result))
            {
                return result;
            }

            return defaultValue;
        }

        public static long? AsLong(this string str)
        {
            if (long.TryParse(str, out long result))
            {
                return result;
            }

            return null;
        }

        public static float AsFloat(this string str, float defaultValue = float.MinValue)
        {
            if (float.TryParse(str, out float result))
            {
                return result;
            }

            return defaultValue;
        }

        public static float? AsFloat(this string str)
        {
            if (float.TryParse(str, out float result))
            {
                return result;
            }

            return null;
        }

        public static double AsDouble(this string str, double defaultValue = double.MinValue)
        {
            if (double.TryParse(str, out double result))
            {
                return result;
            }

            return defaultValue;
        }

        public static double? AsDouble(this string str)
        {
            if (double.TryParse(str, out double result))
            {
                return result;
            }

            return null;
        }
    }
}