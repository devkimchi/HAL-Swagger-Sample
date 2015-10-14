using System.Web.Http;

using HalSwaggerSample.HalApiApp.Models;

using WebApi.Hal;

namespace HalSwaggerSample.HalApiApp.Controllers
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
            entry.Links.Add(new Link() { Rel = "products", Href = "/products" });
            entry.Links.Add(new Link() { Rel = "product", Href = "/products/{productId}" });

            return entry;
        }
    }
}