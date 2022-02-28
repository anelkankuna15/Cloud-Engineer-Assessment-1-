using System;

namespace Palota.Assessment.Countries.Helpers
{
    /// <summary>
    /// Defines a <see cref="CountryErrorException" />
    /// </summary>
    public class ContinentErrorException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryErrorException"/> class.
        /// </summary>
        /// <param name="field">Field</param>
        /// <param name="value">Value</param>
        public ContinentErrorException(string field, String value)
        : base(String.Format("The continent with name {0} could not be found.", field, value))
        {
        }
    }
}