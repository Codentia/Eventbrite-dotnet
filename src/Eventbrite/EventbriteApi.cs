using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Eventbrite.Requests;
using Newtonsoft.Json;

namespace Eventbrite
{
  public class EventbriteApi
  {
    private readonly HttpClient httpClient;
    private string authToken;
    public EventbriteApi()
    {
      httpClient = new HttpClient();
      httpClient.BaseAddress = new Uri("https://www.eventbriteapi.com");
    }

    public async Task<TResponse> Execute<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken)
    {
      var httpRequestMessage = new HttpRequestMessage(request.HttpMethod, request.RequestUri);
      httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
      var response = await httpClient.SendAsync(httpRequestMessage, cancellationToken);
      var content = await response.Content.ReadAsStringAsync();
      return JsonConvert.DeserializeObject<TResponse>(content);
    }

    public void SetOAuthToken(string token)
    {
      authToken = token;
    }
  }
}
