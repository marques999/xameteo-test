﻿using System;
using Newtonsoft.Json;

namespace XameteoTest
{
    /// <summary>
    /// 
    /// </summary>
    internal class Location
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("globalIdLocal")]
        public int Id
        {
            get;
            private set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("local")]
        public string Nome
        {
            get;
            private set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("idRegiao")]
        public int Regiao
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("idConcelho")]
        public int Concelho
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("idDistrito")]
        public int Distrito
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("idAreaAviso")]
        public string AreaAviso
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="degrees"></param>
        /// <returns></returns>
        private static double DegreesToRadians(double degrees) => degrees * Math.PI / 180;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rhsLatitude"></param>
        /// <param name="rhsLongitude"></param>
        /// <returns></returns>
        public double CalculateDistance(double rhsLatitude, double rhsLongitude)
        {
            var deltaLatitude = DegreesToRadians(rhsLatitude - Latitude);
            var deltaLongitude = DegreesToRadians(rhsLongitude - Longitude);
            var angle = Math.Sin(deltaLatitude / 2) * Math.Sin(deltaLatitude / 2) + Math.Sin(deltaLongitude / 2) * Math.Sin(deltaLongitude / 2) * Math.Cos(DegreesToRadians(Latitude)) * Math.Cos(DegreesToRadians(rhsLatitude));
            return 12742 * Math.Atan2(Math.Sqrt(angle), Math.Sqrt(1 - angle));
        }
    }
}