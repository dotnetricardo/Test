using Shape.Contracts;
using Shape.Core;
using Newtonsoft.Json;

namespace Plugin
{
    using System.Threading.Tasks;

    [Shape("SerializerPlugin", false)]
    public class SerializerPlugin
    {
        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

    }
}
