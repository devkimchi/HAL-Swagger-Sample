using System.Web.Http;

using HalSwaggerSample.HalApiApp.Helpers;
using HalSwaggerSample.HalApiApp.Models;

using WebApi.Hal;

namespace HalSwaggerSample.HalApiApp.Controllers
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
            collection.Links.Add(new Link("self", "/products"));
            collection.Links.Add(new Link("product", "/products/{productId}"));

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
