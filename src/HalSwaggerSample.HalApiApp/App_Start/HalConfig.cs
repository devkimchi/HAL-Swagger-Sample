using System.Web.Http;

using Newtonsoft.Json.Serialization;

using WebApi.Hal;

namespace HalSwaggerSample.HalApiApp
{
    public static class HalConfig
    {
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