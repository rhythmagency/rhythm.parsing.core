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

        #endregion

    }

}