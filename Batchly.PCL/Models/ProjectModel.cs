/*
 * Batchly.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/19/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Batchly.PCL;

namespace Batchly.PCL.Models
{
    public class ProjectModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string accountId;
        private string accountName;
        private int? activeJobCount;
        private PlatformEnum? platform;
        private bool? isVpc;
        private string id;
        private string name;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId 
        { 
            get 
            {
                return this.accountId; 
            } 
            set 
            {
                this.accountId = value;
                onPropertyChanged("AccountId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName 
        { 
            get 
            {
                return this.accountName; 
            } 
            set 
            {
                this.accountName = value;
                onPropertyChanged("AccountName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ActiveJobCount")]
        public int? ActiveJobCount 
        { 
            get 
            {
                return this.activeJobCount; 
            } 
            set 
            {
                this.activeJobCount = value;
                onPropertyChanged("ActiveJobCount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Platform", ItemConverterType = typeof(StringValuedEnumConverter))]
        public PlatformEnum? Platform 
        { 
            get 
            {
                return this.platform; 
            } 
            set 
            {
                this.platform = value;
                onPropertyChanged("Platform");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IsVpc")]
        public bool? IsVpc 
        { 
            get 
            {
                return this.isVpc; 
            } 
            set 
            {
                this.isVpc = value;
                onPropertyChanged("IsVpc");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 