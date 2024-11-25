using Microsoft.AspNetCore.SignalR;
using System.Net.Http;

namespace UdemyCarBook.API.Hubs
{
    public class CarHub(IHttpClientFactory httpClientFactory) : Hub
    {
        public async Task SendCarCount()
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7243/api/Statistics/GetCarCount");
            var value = await responseMessage.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCarCount", value);
        }
    }
}
