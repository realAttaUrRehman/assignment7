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
    public class Wind : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double speed;
        private int deg;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("speed")]
        public double Speed 
        { 
            get 
            {
                return this.speed; 
            } 
            set 
            {
                this.speed = value;
                onPropertyChanged("Speed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("deg")]
        public int Deg 
        { 
            get 
            {
                return this.deg; 
            } 
            set 
            {
                this.deg = value;
                onPropertyChanged("Deg");
            }
        }
    }
} 