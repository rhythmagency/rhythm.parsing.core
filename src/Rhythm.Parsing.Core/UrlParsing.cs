namespace Rhythm.Parsing.Core
{

    // Namespaces.
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Assists with URL parsing tasks.
    /// </summary>
    public class UrlParsing
    {

        #region Properties

        /// <summary>
        /// The regex used to match the first segment of a path.
        /// </summary>
        private static Regex FirstSegmentRegex { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructor.
        /// </summary>
        static UrlParsing()
        {
            var options = RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase;
            FirstSegmentRegex = new Regex(@"^/((?!/).)+", options);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Safely extracts the path and query string portion from a URL, regardless of
        /// whether or not that URL has a domain.
        /// </summary>
        /// <param name="url">
        /// The URL (e.g., "http://www.rhythmagency.com/some-path?some=query").
        /// </param>
        /// <returns>
        /// The path (e.g., "/some-path?some=query").
        /// </returns>
        public static string GetPathAndQueryFromUrl(string url)
        {

            // Empty URL's are considered the homepage.
            if (string.IsNullOrWhiteSpace(url))
            {
                return "/";
            }

            // Ensure the URL has a domain in order to ensure no errors
            // are thrown when converting it to a Uri.
            var sampleUrl = new Uri("http://www.site.com/");
            var urlWithDomain = new Uri(sampleUrl, url);

            // Return the path, including the query string.
            var path = urlWithDomain.PathAndQuery;
            if (string.IsNullOrWhiteSpace(path))
            {
                path = "/";
            }
            return path;

        }

        /// <summary>
        /// Safely extracts the path portion from a URL, regardless of
        /// whether or not that URL has a domain.
        /// </summary>
        /// <param name="url">
        /// The URL (e.g., "http://www.rhythmagency.com/some-path?some=query").
        /// </param>
        /// <returns>
        /// The path (e.g., "/some-path").
        /// </returns>
        /// <remarks>
        /// Will not include the query string.
        /// </remarks>
        public static string GetPathFromUrl(string url)
        {

            // Empty URL's are considered the homepage.
            if (string.IsNullOrWhiteSpace(url))
            {
                return "/";
            }

            // Ensure the URL has a domain in order to ensure no errors
            // are thrown when converting it to a Uri.
            var sampleUrl = new Uri("http://www.site.com/");
            var urlWithDomain = new Uri(sampleUrl, url);

            // Return the path, excluding the query string.
            var path = urlWithDomain.AbsolutePath;
            if (string.IsNullOrWhiteSpace(path))
            {
                path = "/";
            }
            return path;

        }

        /// <summary>
        /// Removes the first segment from a URL path.
        /// </summary>
        /// <param name="path">
        /// The path (e.g., "/unwanted-segment/about/company").
        /// </param>
        /// <returns>
        /// The path without the first segment (e.g., "/about/company").
        /// </returns>
        public static string RemoveFirstSegmentFromPath(string path)
        {
            path = FirstSegmentRegex.Replace(path ?? string.Empty, string.Empty);
            if (string.IsNullOrWhiteSpace(path))
            {
                path = "/";
            }
            return path;
        }

        #endregion

    }

}