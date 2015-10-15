using System.Web.Http;

using Newtonsoft.Json.Serialization;

using WebApi.Hal;

namespace HalSwaggerSample.HalApiApp
{
    /// <summary>
    /// This represents the config entity for HAL.
    /// </summary>
    public static class HalConfig
    {
        /// <summary>
        /// Configures HAL formatters.
        /// </summary>
        /// <param name="config"><see cref="HttpConfiguration" /> instance.</param>
        public static void ConfigHal(this HttpConfiguration config)
        {
            config.Formatters.Add(new JsonHalMediaTypeFormatter()
                                  {
                                      SerializerSettings =
                                      {
                                          ContractResolver = new CamelCasePropertyNamesContractResolver()
                                      }
                                  });
            config.Formatters.Add(new XmlHalMediaTypeFormatter());
        }
    }
}