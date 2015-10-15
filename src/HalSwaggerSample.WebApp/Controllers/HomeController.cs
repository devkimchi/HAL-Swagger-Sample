using System;
using System.Threading.Tasks;
using System.Web.Mvc;

using HalSwaggerSample.WebApp.Proxies;

namespace HalSwaggerSample.WebApp.Controllers
{
    /// <summary>
    /// This represents the controller entity for /home.
    /// </summary>
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        private readonly IHalSwaggerSampleHalApiApp _proxy;

        /// <summary>
        /// Initialises a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        /// <param name="proxy"><see cref="HalSwaggerSampleHalApiApp" /> instance.</param>
        public HomeController(IHalSwaggerSampleHalApiApp proxy)
        {
            if (proxy == null)
            {
                throw new ArgumentException(nameof(proxy));
            }

            this._proxy = proxy;
        }

        /// <summary>
        /// Gets the /home/index
        /// </summary>
        /// <returns>
        /// Returns the result for /home/index
        /// </returns>
        [Route("")]
        public virtual async Task<ActionResult> Index()
        {
            var response = await this._proxy.ProductOperations.GetProductWithHttpMessagesAsync(5);
            var product = response.Body;
            return View(product);
        }
    }
}