/*
 * Batchly.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/19/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Batchly.PCL;

namespace Batchly.PCL.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum LanguageEnum
    {
        NONE, //TODO: Write general description for this method
        DOTNET, //TODO: Write general description for this method
        MONO, //TODO: Write general description for this method
        JAVA, //TODO: Write general description for this method
        PYTHON, //TODO: Write general description for this method
        PHP, //TODO: Write general description for this method
        RUBY, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type LanguageEnum
    /// </summary>
    public static class LanguageEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "None", "DotNet", "Mono", "Java", "Python", "PHP", "Ruby" };

        /// <summary>
        /// Converts a LanguageEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The LanguageEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(LanguageEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case LanguageEnum.NONE:
                case LanguageEnum.DOTNET:
                case LanguageEnum.MONO:
                case LanguageEnum.JAVA:
                case LanguageEnum.PYTHON:
                case LanguageEnum.PHP:
                case LanguageEnum.RUBY:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of LanguageEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of LanguageEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<LanguageEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into LanguageEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed LanguageEnum value</returns>
        public static LanguageEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type LanguageEnum", value));

            return (LanguageEnum) index;
        }
    }
} 