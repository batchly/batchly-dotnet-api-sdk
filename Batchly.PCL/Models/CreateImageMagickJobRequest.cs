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
    public class CreateImageMagickJobRequest : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string projectId;
        private string sourceLocation;
        private string destinationLocation;
        private string region;
        private double timeLimit;
        private string resize;

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
        [JsonProperty("ProjectId")]
        public string ProjectId 
        { 
            get 
            {
                return this.projectId; 
            } 
            set 
            {
                this.projectId = value;
                onPropertyChanged("ProjectId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SourceLocation")]
        public string SourceLocation 
        { 
            get 
            {
                return this.sourceLocation; 
            } 
            set 
            {
                this.sourceLocation = value;
                onPropertyChanged("SourceLocation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DestinationLocation")]
        public string DestinationLocation 
        { 
            get 
            {
                return this.destinationLocation; 
            } 
            set 
            {
                this.destinationLocation = value;
                onPropertyChanged("DestinationLocation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Region")]
        public string Region 
        { 
            get 
            {
                return this.region; 
            } 
            set 
            {
                this.region = value;
                onPropertyChanged("Region");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TimeLimit")]
        public double TimeLimit 
        { 
            get 
            {
                return this.timeLimit; 
            } 
            set 
            {
                this.timeLimit = value;
                onPropertyChanged("TimeLimit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Resize")]
        public string Resize 
        { 
            get 
            {
                return this.resize; 
            } 
            set 
            {
                this.resize = value;
                onPropertyChanged("Resize");
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