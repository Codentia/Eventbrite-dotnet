using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Eventbrite.Requests;
using Xunit;

namespace Eventbrite.Tests
{
  public class GetAccessTokenRequestTests
  {
    [Fact]
    public async Task Should_()
    {

      var api = new EventbriteApi();
      var request = new GetAccessTokenRequest("","","");
      var response = await api.Execute(request, CancellationToken.None);
    }
  }
}
