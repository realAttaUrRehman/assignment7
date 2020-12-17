/*
 * WeatherAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
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
using WeatherAPI.Standard;
using WeatherAPI.Standard.Utilities;


namespace WeatherAPI.Standard.Models
{
    public class Clouds : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int all;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("all")]
        public int All 
        { 
            get 
            {
                return this.all; 
            } 
            set 
            {
                this.all = value;
                onPropertyChanged("All");
            }
        }
    }
} 