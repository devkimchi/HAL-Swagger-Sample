using System.Collections.Generic;

using WebApi.Hal;

namespace HalSwaggerSample.HalApiApp.Models
{
    /// <summary>
    /// This represents the collection entity for products.
    /// </summary>
    public class ProductCollection : SimpleListRepresentation<Product>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ProductCollection" /> class.
        /// </summary>
        public ProductCollection()
            : base()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ProductCollection" /> class.
        /// </summary>
        /// <param name="products">
        /// List of the <see cref="Product" /> objects.
        /// </param>
        public ProductCollection(IList<Product> products)
            : base(products)
        {
        }
    }
}