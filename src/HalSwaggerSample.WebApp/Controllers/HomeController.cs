using System.Web.Mvc;

namespace HalSwaggerSample.WebApp.Controllers
{
    /// <summary>
    /// This represents the controller entity for /home.
    /// </summary>
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        /// <summary>
        /// Gets the /home/index
        /// </summary>
        /// <returns>
        /// Returns the result for /home/index
        /// </returns>
        [Route("")]
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}