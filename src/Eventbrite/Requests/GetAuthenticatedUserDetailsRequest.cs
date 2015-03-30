using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Entities;

namespace Eventbrite.Requests
{
  public class GetAuthenticatedUserDetailsRequest : IRequest<User>
  {
    public HttpMethod HttpMethod
    {
      get { return HttpMethod.Get; }
    }

    public Uri RequestUri
    {
      get
      {
        return new Uri("/v3/users/me/");
      }
    }
  }
}
