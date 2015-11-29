using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Responses;

namespace Eventbrite.Requests
{
  public class GetUserOwnedEventsRequest : IRequest<OwnedEventsResponse>
  {
    public GetUserOwnedEventsRequest(long id)
    {
      Id = id;
    }

    public long Id { get; private set; }

    public string Status { get; set; }

    public HttpMethod HttpMethod
    {
      get
      {
        return HttpMethod.Get;
      }
    }

    public string RequestUri
    {
      get 
      {
          string status = string.IsNullOrEmpty(this.Status) ? string.Empty : string.Format("?status={0}", this.Status);

          return string.Format("/v3/users/{0}/owned_events/{1}", Id, status); 
      }
    }
  }
}
