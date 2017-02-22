using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace DemoXamarin123.Model
{
    [DataTable("asistentes")]
    public class Asistente
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }
}