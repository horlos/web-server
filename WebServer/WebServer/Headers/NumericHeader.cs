﻿namespace WebServer.Headers
{
    using System.Globalization;

    /// <summary>
    /// 
    /// </summary>
    public class NumericHeader : IHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericHeader"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public NumericHeader(string name, long value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets header name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets value
        /// </summary>
        public long Value { get; set; }

        public string HeaderValue
        {
            get { return Value.ToString(CultureInfo.InvariantCulture); }
        }

        /// <summary>
        /// Returns data formatted as a HTTP header value.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
