using System.Web.Http;

using HalSwaggerSample.ApiApp.Models;

namespace HalSwaggerSample.ApiApp.Controllers
{
    /// <summary>
    /// This represents the controller entity for entry.
    /// </summary>
    [RoutePrefix("")]
    public class EntryController : ApiController
    {
        /// <summary>
        /// Gets the entry.
        /// </summary>
        /// <returns>
        /// Returns the entry.
        /// </returns>
        [Route("")]
        public virtual Entry GetEntry()
        {
            var entry = new Entry();
            entry.Products = new Link() { Href = "/products" };
            entry.Product = new Link() { Href = "/products/{productId}" };

            return entry;
        }
    }
}