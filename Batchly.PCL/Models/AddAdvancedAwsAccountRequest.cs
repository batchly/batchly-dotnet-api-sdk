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
    public class AddAdvancedAwsAccountRequest : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string accountId;
        private string roleARN;
        private string instanceProfileARN;
        private string spotDataFeedPath;
        private string baseRegion;

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
        [JsonProperty("RoleARN")]
        public string RoleARN 
        { 
            get 
            {
                return this.roleARN; 
            } 
            set 
            {
                this.roleARN = value;
                onPropertyChanged("RoleARN");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InstanceProfileARN")]
        public string InstanceProfileARN 
        { 
            get 
            {
                return this.instanceProfileARN; 
            } 
            set 
            {
                this.instanceProfileARN = value;
                onPropertyChanged("InstanceProfileARN");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SpotDataFeedPath")]
        public string SpotDataFeedPath 
        { 
            get 
            {
                return this.spotDataFeedPath; 
            } 
            set 
            {
                this.spotDataFeedPath = value;
                onPropertyChanged("SpotDataFeedPath");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("BaseRegion")]
        public string BaseRegion 
        { 
            get 
            {
                return this.baseRegion; 
            } 
            set 
            {
                this.baseRegion = value;
                onPropertyChanged("BaseRegion");
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