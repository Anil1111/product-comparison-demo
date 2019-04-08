using System.Web.Http;

using Newtonsoft.Json;

namespace ApiClientLibrary.Controllers
{
    public abstract class ApiControllerBase : ApiController
    {
        protected readonly JsonSerializerSettings Settings;

        protected ApiControllerBase(Formatting format)
        {
            Settings = new JsonSerializerSettings { Formatting = format };
        }

        protected ApiControllerBase()
            : this(Formatting.None)
        {
        }
    }
}