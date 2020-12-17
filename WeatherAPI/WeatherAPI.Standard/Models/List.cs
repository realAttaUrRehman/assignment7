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
    public class List : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int id;
        private string name;
        private Models.Coord coord;
        private Models.Main main;
        private int dt;
        private Models.Wind wind;
        private Models.Sys sys;
        private Models.Rain rain;
        private string snow;
        private Models.Clouds clouds;
        private List<Models.Weather> weather;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public int Id 
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
        [JsonProperty("name")]
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
        [JsonProperty("coord")]
        public Models.Coord Coord 
        { 
            get 
            {
                return this.coord; 
            } 
            set 
            {
                this.coord = value;
                onPropertyChanged("Coord");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("main")]
        public Models.Main Main 
        { 
            get 
            {
                return this.main; 
            } 
            set 
            {
                this.main = value;
                onPropertyChanged("Main");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("dt")]
        public int Dt 
        { 
            get 
            {
                return this.dt; 
            } 
            set 
            {
                this.dt = value;
                onPropertyChanged("Dt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("wind")]
        public Models.Wind Wind 
        { 
            get 
            {
                return this.wind; 
            } 
            set 
            {
                this.wind = value;
                onPropertyChanged("Wind");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sys")]
        public Models.Sys Sys 
        { 
            get 
            {
                return this.sys; 
            } 
            set 
            {
                this.sys = value;
                onPropertyChanged("Sys");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("rain")]
        public Models.Rain Rain 
        { 
            get 
            {
                return this.rain; 
            } 
            set 
            {
                this.rain = value;
                onPropertyChanged("Rain");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("snow")]
        public string Snow 
        { 
            get 
            {
                return this.snow; 
            } 
            set 
            {
                this.snow = value;
                onPropertyChanged("Snow");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clouds")]
        public Models.Clouds Clouds 
        { 
            get 
            {
                return this.clouds; 
            } 
            set 
            {
                this.clouds = value;
                onPropertyChanged("Clouds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("weather")]
        public List<Models.Weather> Weather 
        { 
            get 
            {
                return this.weather; 
            } 
            set 
            {
                this.weather = value;
                onPropertyChanged("Weather");
            }
        }
    }
} 