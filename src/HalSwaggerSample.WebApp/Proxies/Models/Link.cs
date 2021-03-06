// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace HalSwaggerSample.WebApp.Proxies.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class Link
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Curie")]
        public CuriesLink Curie { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Rel")]
        public string Rel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Href")]
        public string Href { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Deprecation")]
        public string Deprecation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Profile")]
        public string Profile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HrefLang")]
        public string HrefLang { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsTemplated")]
        public bool? IsTemplated { get; private set; }

    }
}
