using System;
using System.Collections.Generic;

using HalSwaggerSample.ApiApp.Models;

namespace HalSwaggerSample.ApiApp.Helpers
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
                var product = new Product()
                {
                    ProductId = i + 1,
                    Name = "Product " + (i + 1),
                    ProductType = (ProductType)((i + 1) % Enum.GetNames(typeof(ProductType)).Length),
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
            var product = new Product()
            {
                ProductId = productId,
                Name = "Product " + productId,
                ProductType = (ProductType)(productId % Enum.GetNames(typeof(ProductType)).Length),
            };

            return product;
        }
    }
}