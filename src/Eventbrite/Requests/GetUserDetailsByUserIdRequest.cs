using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Entities;

namespace Eventbrite.Requests
{
  public class GetUserDetailsByUserIdRequest : IRequest<User>
  {
    public GetUserDetailsByUserIdRequest(int userId)
    {
      UserId = userId;
    }

    public int UserId { get; private set; }

    public HttpMethod HttpMethod { get { return HttpMethod.Get; }}

    public Uri RequestUri
    {
      get { return new Uri(string.Format("/v3/users/{0}/", UserId)); }
    }
  }
}
