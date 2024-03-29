﻿namespace WebServer.Cookies
{
    using System;
    using System.Web;

    /// <summary>
    /// Cookie sent by the client/browser.
    /// </summary>
    /// <seealso cref="ResponseCookie"/>
    public class RequestCookie
    {
        private readonly string _name;
        private string _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCookie"/>.
        /// </summary>
        /// <param name="id">Cookie identifier</param>
        /// <param name="content">Cookie content</param>
        /// <exception cref="ArgumentNullException">Id or content is null.</exception>
        /// <exception cref="ArgumentException">Id is empty.</exception>
        public RequestCookie(string id, string content)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException("id");
            if (content == null) throw new ArgumentNullException("content");

            _name = id;
            _value = content;
        }

        /// <summary>
        /// Gets the cookie identifier.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets value. 
        /// </summary>
        /// <remarks>
        /// Set to <c>null</c> to remove cookie.
        /// </remarks>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Gets the cookie HTML representation.
        /// </summary>
        /// <returns>cookie string</returns>
        public override string ToString()
        {
            return string.Format("{0}={1}; ", HttpUtility.UrlEncode(_name), HttpUtility.UrlEncode(_value));
        }
    }
}