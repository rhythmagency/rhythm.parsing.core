namespace Rhythm.Parsing.Core
{

    // Namespaces.
    using System.Net.Mail;

    /// <summary>
    /// Assists with email parsing tasks.
    /// </summary>
    public class EmailParsing
    {

        #region Properties

        /// <summary>
        /// Indicates whether or not the specified email address is in a valid format.
        /// </summary>
        /// <param name="email">
        /// The email address.
        /// </param>
        /// <returns>
        /// True, if the email address is in a valid format; otherwise, false.
        /// </returns>
        /// <remarks>
        /// This code is based on this Stack Overflow answer: http://stackoverflow.com/a/1374644/2052963
        /// </remarks>
        public static bool IsEmailInValidFormat(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        #endregion

    }

}