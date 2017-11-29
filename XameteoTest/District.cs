using Newtonsoft.Json;

namespace XameteoTest
{
    /// <summary>
    ///
    /// </summary>
    internal class District
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("idDistrito")]
        public int Id
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
        [JsonProperty("nome")]
        public string Nome
        {
            get;
            private set;
        }
    }
}