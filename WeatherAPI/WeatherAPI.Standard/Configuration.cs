using WeatherAPI.Standard.Models;
namespace WeatherAPI.Standard
{
    public partial class Configuration
    {


        //The base Uri for API calls
        public static string BaseUri = "http://api.openweathermap.org/data/2.5";

        //app key
        //TODO: Replace the Appid with an appropriate value
        public static string Appid = "e7b16ebe3fbe47e6b97f6821cff80e5d";

    }
}