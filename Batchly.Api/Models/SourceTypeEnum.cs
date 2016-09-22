/*
 * Batchly.Api
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/19/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Batchly.Api;

namespace Batchly.Api.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum SourceTypeEnum
    {
        NONE, //TODO: Write general description for this method
        SQS, //TODO: Write general description for this method
        SQLSERVER, //TODO: Write general description for this method
        MYSQL, //TODO: Write general description for this method
        ORACLE, //TODO: Write general description for this method
        RDSMYSQL, //TODO: Write general description for this method
        S3, //TODO: Write general description for this method
        BOX, //TODO: Write general description for this method
        PORTICOR, //TODO: Write general description for this method
        S3FILE, //TODO: Write general description for this method
        S3DELIMITED, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type SourceTypeEnum
    /// </summary>
    public static class SourceTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "None", "SQS", "SqlServer", "MYSql", "Oracle", "RDSMySql", "S3", "Box", "Porticor", "S3File", "S3Delimited" };

        /// <summary>
        /// Converts a SourceTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SourceTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SourceTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SourceTypeEnum.NONE:
                case SourceTypeEnum.SQS:
                case SourceTypeEnum.SQLSERVER:
                case SourceTypeEnum.MYSQL:
                case SourceTypeEnum.ORACLE:
                case SourceTypeEnum.RDSMYSQL:
                case SourceTypeEnum.S3:
                case SourceTypeEnum.BOX:
                case SourceTypeEnum.PORTICOR:
                case SourceTypeEnum.S3FILE:
                case SourceTypeEnum.S3DELIMITED:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SourceTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SourceTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SourceTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into SourceTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SourceTypeEnum value</returns>
        public static SourceTypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type SourceTypeEnum", value));

            return (SourceTypeEnum) index;
        }
    }
} 