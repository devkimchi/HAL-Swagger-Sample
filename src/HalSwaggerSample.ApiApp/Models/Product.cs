using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HalSwaggerSample.ApiApp.Models
{
    /// <summary>
    /// This represents the entity for product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the product Id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product type.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductType ProductType { get; set; }
    }
}