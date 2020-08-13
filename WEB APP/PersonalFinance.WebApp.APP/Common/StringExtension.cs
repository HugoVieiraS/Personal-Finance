using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class StringExtension
    {
        /// <summary>
        /// Remove as aspas duplas no início e no fim da string
        /// </summary>
        /// <param name="value">Valor string</param>
        /// <returns>String sem aspas duplas no início e fim</returns>
        public static string RemoveQuotes(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            if (value.StartsWith("\""))
            {
                value = value.Remove(0, 1);
            }

            if (value.EndsWith("\""))
            {
                value = value.Remove(value.Length - 1);
            }

            return value;
        }
    }
}