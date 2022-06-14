using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
namespace Widget_Weather.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Datum
    {
        [JsonPropertyName("rh")]
        public double Rh { get; set; }

        [JsonPropertyName("pod")]
        public string Pod { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("pres")]
        public double Pres { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("ob_time")]
        public string ObTime { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("clouds")]
        public double Clouds { get; set; }

        [JsonPropertyName("ts")]
        public double Ts { get; set; }

        [JsonPropertyName("solar_rad")]
        public double SolarRad { get; set; }

        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }

        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        [JsonPropertyName("wind_spd")]
        public double WindSpd { get; set; }

        [JsonPropertyName("wind_cdir_full")]
        public string WindCdirFull { get; set; }

        [JsonPropertyName("wind_cdir")]
        public string WindCdir { get; set; }

        [JsonPropertyName("slp")]
        public double Slp { get; set; }

        [JsonPropertyName("vis")]
        public double Vis { get; set; }

        [JsonPropertyName("h_angle")]
        public double HAngle { get; set; }

        [JsonPropertyName("sunset")]
        public string Sunset { get; set; }

        [JsonPropertyName("dni")]
        public double Dni { get; set; }

        [JsonPropertyName("dewpt")]
        public double Dewpt { get; set; }

        [JsonPropertyName("snow")]
        public double Snow { get; set; }

        [JsonPropertyName("uv")]
        public double Uv { get; set; }

        [JsonPropertyName("precip")]
        public double Precip { get; set; }

        [JsonPropertyName("wind_dir")]
        public double WindDir { get; set; }

        [JsonPropertyName("sunrise")]
        public string Sunrise { get; set; }

        [JsonPropertyName("ghi")]
        public double Ghi { get; set; }

        [JsonPropertyName("dhi")]
        public double Dhi { get; set; }

        [JsonPropertyName("aqi")]
        public double Aqi { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }

        [JsonPropertyName("datetime")]
        public string Datetime { get; set; }

        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("station")]
        public string Station { get; set; }

        [JsonPropertyName("elev_angle")]
        public double ElevAngle { get; set; }

        [JsonPropertyName("app_temp")]
        public double AppTemp { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }

        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("code")]
        public double Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }



}

