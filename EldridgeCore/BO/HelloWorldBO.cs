using EldridgeDomain.Interfaces.BO;

namespace EldridgeCore.BO
{
    public class HelloWorldBO : IHelloWorldBO
    {
        /// <summary>
        /// This method simply returns "Hello World"
        /// </summary>
        /// <returns>A string containing "Hello World"</returns>
        public string GetHelloWorld()
        {
            return "Hello World";
        }
    }
}
