using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Entities;
using Flurl;

namespace Eventbrite.Requests
{
  public class GetAccessTokenRequest : IRequest<AccessToken>
  {
    public GetAccessTokenRequest(string code, string clientSecret, string clientId)
    {
      Code = code;
      ClientSecret = clientSecret;
      ClientId = clientId;
    }

    public string Code { get; private set; }
    public string ClientSecret { get; private set; }
    public string ClientId { get; private set; }

    public HttpMethod HttpMethod { get{ return HttpMethod.Post;} }

    public string RequestUri
    {
      get
      {
        return "/oauth/token"
          .SetQueryParam("code", Code)
          .SetQueryParam("client_secret", ClientSecret)
          .SetQueryParam("client_id", ClientId)
          .SetQueryParam("grant_type", "authorization_code");
      }
    }
  }
}