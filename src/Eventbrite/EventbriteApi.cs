using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Requests;
using Newtonsoft.Json;

namespace Eventbrite
{
  public class EventbriteApi
  {
    private readonly HttpClient httpClient;
    private readonly string apiKey;


    public EventbriteApi(string apiKey)
    {
      this.apiKey = apiKey;
      httpClient = new HttpClient();
    }

    public async Task<TResponse> Execute<TResponse>(IRequest<TResponse> request)
    {
      var httpRequestMessage = new HttpRequestMessage(request.HttpMethod, request.RequestUri);
      var response = await httpClient.SendAsync(httpRequestMessage);
      var content = await response.Content.ReadAsStringAsync();
      return JsonConvert.DeserializeObject<TResponse>(content);
    }
  }
}
