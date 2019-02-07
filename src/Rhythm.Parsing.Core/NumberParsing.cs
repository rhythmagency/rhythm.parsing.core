namespace Rhythm.Parsing.Core
{

    /// <summary>
    /// Assists with number parsing tasks.
    /// </summary>
    public class NumberParsing
    {

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

        #endregion

    }

}