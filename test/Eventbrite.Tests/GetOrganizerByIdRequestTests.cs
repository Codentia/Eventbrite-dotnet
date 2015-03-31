using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Eventbrite.Requests;
using Flurl;
using Xunit;

namespace Eventbrite.Tests
{
  public class GetOrganizerByIdRequestTests
  {
    [Fact]
    public async Task Should_return_correct_organisation()
    {
      long id = 7794529429;
      var api = new EventbriteApi();
      api.SetOAuthToken("BKKRDKVUVRC5WG4HAVLT");
      var request = new GetOrganizerByIdRequest(id);
      var response = await api.Execute(request, CancellationToken.None);

      Assert.Equal(id, response.Id);
    }

  }
}
