using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace DemoXamarin123.Model
{
    public class AzureClient
    {
        private MobileServiceClient _client;
        private IMobileServiceTable<Asistente> _tabla;

        public AzureClient()
        {
            _client = new MobileServiceClient("http://myownchat.azurewebsites.net");
            _tabla = _client.GetTable<Asistente>();
        }

        public async Task InsertarAsistente(Asistente asistente)
        {
            await _tabla.InsertAsync(asistente);
        }
    }
}