using Shape.Contracts;
using Shape.Core;
using Newtonsoft.Json;

namespace Plugin
{
    using System.Threading.Tasks;

    [Shape("TestPlugin", false)]
    public class TestPlugin
    {
        public async Task<string> Message(string message)
        {
            return await Task.FromResult(JsonConvert.SerializeObject(new { Message = "Hello From TestPlugin" }));
        }

    }
}
