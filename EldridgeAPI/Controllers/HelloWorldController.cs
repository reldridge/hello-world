using System.Web.Http;
using EldridgeDomain.Interfaces.BO;

namespace EldridgeAPI.Controllers
{
    [RoutePrefix("HelloWorld")]
    public class HelloWorldController : ApiController
    {
        private readonly IHelloWorldBO HelloWorldBO;

        public HelloWorldController(IHelloWorldBO helloWorldBO)
        {
            HelloWorldBO = helloWorldBO;
        }

        /// <summary>
        /// Gets response from HelloWorldBO.GetHelloWorld() method
        /// </summary>
        [HttpGet]
        [Route("")]
        public IHttpActionResult ReturnHelloWorld()
        {
            // get response from HelloWorldBO
            var response = HelloWorldBO.GetHelloWorld();

            return Ok(response);
        }

        // more endpoints will be added in future
    }
}
