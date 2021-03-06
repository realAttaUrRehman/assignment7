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
    public class Main : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double temp;
        private double feelsLike;
        private double tempMin;
        private double tempMax;
        private int pressure;
        private int humidity;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("temp")]
        public double Temp 
        { 
            get 
            {
                return this.temp; 
            } 
            set 
            {
                this.temp = value;
                onPropertyChanged("Temp");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("feels_like")]
        public double FeelsLike 
        { 
            get 
            {
                return this.feelsLike; 
            } 
            set 
            {
                this.feelsLike = value;
                onPropertyChanged("FeelsLike");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("temp_min")]
        public double TempMin 
        { 
            get 
            {
                return this.tempMin; 
            } 
            set 
            {
                this.tempMin = value;
                onPropertyChanged("TempMin");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("temp_max")]
        public double TempMax 
        { 
            get 
            {
                return this.tempMax; 
            } 
            set 
            {
                this.tempMax = value;
                onPropertyChanged("TempMax");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pressure")]
        public int Pressure 
        { 
            get 
            {
                return this.pressure; 
            } 
            set 
            {
                this.pressure = value;
                onPropertyChanged("Pressure");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("humidity")]
        public int Humidity 
        { 
            get 
            {
                return this.humidity; 
            } 
            set 
            {
                this.humidity = value;
                onPropertyChanged("Humidity");
            }
        }
    }
} 