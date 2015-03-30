using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Eventbrite.Requests
{
  public interface IRequest<TResponse>
  {
    HttpMethod HttpMethod { get; }
    Uri RequestUri { get; }
  }
}
