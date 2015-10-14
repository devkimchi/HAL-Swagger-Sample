using System;
using System.Collections.Generic;

using HalSwaggerSample.HalApiApp.Models;

using WebApi.Hal;

namespace HalSwaggerSample.HalApiApp.Helpers
{
    /// <summary>
    /// This represents the helper entity for products.
    /// </summary>
    public static class ProductHelper
    {
        /// <summary>
        /// Gets the list of products.
        /// </summary>
        /// <param name="count">
        /// Number of products to return.
        /// </param>
        /// <returns>
        /// Returns the list of products.
        /// </returns>
        public static List<Product> GetProducts(int count)
        {
            var products = new List<Product>();
            for (var i = 0; i < count; i++)
            {
                var link = new Link("self", "/products/" + (i + 1));
                var links = new List<Link>()
                                {
                                    link,
                                    new Link("product", "/products/{productId}"),
                                    new Link("products", "/products"),
                                };

                var product = new Product()
                                  {
                                      ProductId = i + 1,
                                      Name = "Product " + (i + 1),
                                      ProductType = (ProductType)((i + 1) % Enum.GetNames(typeof(ProductType)).Length),
                                      Rel = "product",
                                      Href = link.Href,
                                      Links = links,
                                  };

                products.Add(product);
            }

            return products;
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
        public static Product GetProduct(int productId)
        {
            var link = new Link("self", "/products/" + productId);
            var links = new List<Link>()
                                {
                                    link,
                                    new Link("template", "/products/{productId}"),
                                    new Link("products", "/products"),
                                };

            var product = new Product()
                              {
                                  ProductId = productId,
                                  Name = "Product " + productId,
                                  ProductType = (ProductType)(productId % Enum.GetNames(typeof(ProductType)).Length),
                                  Rel = "product",
                                  Href = link.Href,
                                  Links = links,
                              };

            return product;
        }
    }
}