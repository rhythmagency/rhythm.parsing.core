namespace Rhythm.Parsing.Core
{

    // Namespaces.
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Assists with filename parsing tasks.
    /// </summary>
    public class FilenameParsing
    {

        #region Properties

        /// <summary>
        /// The characters to exclude when sanitizing filenames.
        /// </summary>
        private static HashSet<char> InvalidFilenameChars { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructor.
        /// </summary>
        static FilenameParsing()
        {
            InvalidFilenameChars = new HashSet<char>(Path.GetInvalidFileNameChars());
            InvalidFilenameChars.Add('.');
            InvalidFilenameChars.Add('~');
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sanitizes a source string for use as a filename.
        /// </summary>
        /// <param name="source">
        /// The source string to sanitize.
        /// </param>
        /// <param name="replaceChar">
        /// Optional. The character to use to replace invalid characters. If unspecified,
        /// invalid characters will be removed entirely.
        /// </param>
        /// <returns>
        /// The sanitized string.
        /// </returns>
        /// <remarks>
        /// For extra safety, this will exclude some characters that are not strictly prohibited
        /// from being part of filenames (e.g., the period character).
        /// </remarks>
        public static string SanitizeFilename(string source, string replaceChar = null)
        {
            replaceChar = replaceChar ?? string.Empty;
            source = source ?? string.Empty;
            var sanitized = new StringBuilder();
            var invalidChars = InvalidFilenameChars;
            foreach (var character in source)
            {
                if (invalidChars.Contains(character))
                {
                    sanitized.Append(replaceChar);
                }
                else
                {
                    sanitized.Append(character);
                }
            }
            return sanitized.ToString();
        }

        #endregion

    }

}