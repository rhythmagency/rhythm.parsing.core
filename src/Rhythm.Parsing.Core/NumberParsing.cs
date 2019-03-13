namespace Rhythm.Parsing.Core
{

    // Namespaces.
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Assists with number parsing tasks.
    /// </summary>
    public class NumberParsing
    {

        #region Properties

        /// <summary>
        /// Regular expression that matches the numeric digits in a string.
        /// </summary>
        private static Regex DigitsRegex { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructor.
        /// </summary>
        static NumberParsing()
        {
            var options = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline;
            DigitsRegex = new Regex(@"[0-9]+", options);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Attempts to parse an integer.
        /// </summary>
        /// <param name="value">
        /// The string version of the integer.
        /// </param>
        /// <returns>
        /// The integer, if it could be parsed; otherwise, null.
        /// </returns>
        public static int? AttemptParseInt(string value)
        {
            if (value == null)
            {
                return null;
            }
            var tempInt = default(int);
            return int.TryParse(value, out tempInt)
                ? tempInt
                : default(int?);
        }

        /// <summary>
        /// Attempts to parse a long.
        /// </summary>
        /// <param name="value">
        /// The string version of the long.
        /// </param>
        /// <returns>
        /// The long, if it could be parsed; otherwise, null.
        /// </returns>
        public static long? AttemptParseLong(string value)
        {
            if (value == null)
            {
                return null;
            }
            var tempLong = default(long);
            return long.TryParse(value, out tempLong)
                ? tempLong
                : default(long?);
        }

        /// <summary>
        /// Attempts to parse a double.
        /// </summary>
        /// <param name="value">
        /// The string representation of the double.
        /// </param>
        /// <returns>
        /// The double, if it could be parsed; otherwise, null.
        /// </returns>
        public static double? AttemptParseDouble(string value)
        {
            if (value == null)
            {
                return null;
            }
            var parsed = default(double);
            return double.TryParse(value ?? string.Empty, out parsed)
                ? parsed
                : default(double?);
        }

        /// <summary>
        /// Attempts to parse a decimal.
        /// </summary>
        /// <param name="value">
        /// The string representation of the decimal.
        /// </param>
        /// <returns>
        /// The decimal, if it could be parsed; otherwise, null.
        /// </returns>
        public static decimal? AttemptParseDecimal(string value)
        {
            if (value == null)
            {
                return null;
            }
            var parsed = default(decimal);
            return decimal.TryParse(value ?? string.Empty, out parsed)
                ? parsed
                : default(decimal?);
        }

        /// <summary>
        /// Extracts the numeric digits from the specified string.
        /// </summary>
        /// <param name="value">
        /// The string value to extract digits from (e.g., "(555) 555-5555").
        /// </param>
        /// <returns>
        /// The numeric digits (e.g., "5555555555").
        /// </returns>
        public static string ExtractDigits(string value)
        {
            value = value ?? string.Empty;
            var digits = DigitsRegex.Matches(value).Cast<Match>().Select(x => x.Value);
            var strDigits = string.Join(string.Empty, digits);
            return strDigits ?? string.Empty;
        }

        #endregion

    }

}