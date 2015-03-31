using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Eventbrite.Requests;
using Flurl;
using Newtonsoft.Json;

namespace Eventbrite
{
  public class EventbriteApi
  {
    private readonly HttpClient httpClient;
    private string oAuthToken;

    public EventbriteApi()
    {
      httpClient = new HttpClient();
      httpClient.BaseAddress = new Uri("https://www.eventbriteapi.com");
    }

    public async Task<TResponse> Execute<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken)
    {
      // setting auth token in query param as setting it on the header throws auth error.
      // TODO: investigate.
      var url = request.RequestUri.SetQueryParam("token", oAuthToken);

      var httpRequestMessage = new HttpRequestMessage(request.HttpMethod, url);
      var response = await httpClient.SendAsync(httpRequestMessage, cancellationToken);
      var content = await response.Content.ReadAsStringAsync();
      return JsonConvert.DeserializeObject<TResponse>(content);
    }

    public void SetOAuthToken(string token)
    {
      oAuthToken = token;
      httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }
  }
}
