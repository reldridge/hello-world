using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EldridgeAPI.Controllers;
using System.Web.Http.Results;
using EldridgeCore.BO;
using EldridgeDomain.Interfaces.BO;

namespace EldridgeAPI.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Get()
        {
            IHelloWorldBO helloWorldBO = new HelloWorldBO();

            // controller instance
            HelloWorldController controller = new HelloWorldController(helloWorldBO);

            // call ReturnHelloWorld() method
            IHttpActionResult actionResult = controller.ReturnHelloWorld();

            // validate test
            var conNegResult = actionResult as OkNegotiatedContentResult<string>;
            Assert.IsNotNull(conNegResult);
            Assert.AreEqual("Hello World", conNegResult.Content);            
        }
    }
}
