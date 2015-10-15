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
    /// This represents the entity for product.
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// Gets or sets the product Id.
        /// </summary>
        [JsonProperty(PropertyName = "ProductId")]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product type. Possible values for this property
        /// include: 'Unknown', 'Food', 'Stationery'.
        /// </summary>
        [JsonProperty(PropertyName = "ProductType")]
        public string ProductType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public IList<Link> LowLinelinks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_embedded")]
        public IList<EmbeddedResource> LowLineembedded { get; set; }

    }
}
