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
      this.Status = "all";
      this.Expansions = new List<string>();
    }

    public long Id { get; private set; }

    public string Status { get; set; }

    public List<string> Expansions { get; set; }

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
          StringBuilder queryString = new StringBuilder();
          queryString.Append("?");

          if(!string.IsNullOrEmpty(this.Status))
          {
              queryString.AppendFormat("status={0}", this.Status.ToLower());
          }

          if (this.Expansions.Count() > 0)
          {
              if (queryString.Length > 1)
              {
                  queryString.Append("&");
              }

              queryString.Append("expand=");

              foreach (string expansion in this.Expansions)
              {
                  queryString.Append(expansion.ToLower());
                  queryString.Append(",");
              }

              queryString.Remove(queryString.Length - 1, 1);
          }

          return string.Format("/v3/users/{0}/owned_events/{1}", Id, queryString.ToString()); 
      }
    }
  }
}
