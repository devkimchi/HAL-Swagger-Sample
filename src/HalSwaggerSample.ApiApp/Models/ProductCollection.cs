using System.Collections.Generic;

namespace HalSwaggerSample.ApiApp.Models
{
    /// <summary>
    /// This represents the collection entity for products.
    /// </summary>
    public class ProductCollection
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ProductCollection" /> class.
        /// </summary>
        public ProductCollection()
        {
            this.Items = new List<Product>();
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ProductCollection" /> class.
        /// </summary>
        /// <param name="products">
        /// List of the <see cref="Product" /> objects.
        /// </param>
        public ProductCollection(IList<Product> products)
        {
            this.Items = products;
        }

        public IList<Product> Items { get; set; }
    }
}