using System.Web.Http;

using HalSwaggerSample.ApiApp.Helpers;
using HalSwaggerSample.ApiApp.Models;

namespace HalSwaggerSample.ApiApp.Controllers
{
    /// <summary>
    /// This represents the controller entity for products.
    /// </summary>
    [RoutePrefix("products")]
    public class ProductController : ApiController
    {
        /// <summary>
        /// Gets the product collection.
        /// </summary>
        /// <returns>
        /// Returns the product collection.
        /// </returns>
        [Route("")]
        public virtual ProductCollection GetProducts()
        {
            var products = ProductHelper.GetProducts(2);
            var collection = new ProductCollection(products);

            return collection;
        }

        /// <summary>
        /// Gets the product.
        /// </summary>
        /// <param name="productId">
        /// The product Id.
        /// </param>
        /// <returns>
        /// Returns the product.
        /// </returns>
        [Route("{productId}")]
        public virtual Product GetProduct(int productId)
        {
            var product = ProductHelper.GetProduct(productId);
            return product;
        }
    }
}