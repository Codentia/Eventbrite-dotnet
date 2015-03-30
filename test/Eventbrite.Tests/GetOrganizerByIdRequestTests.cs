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
  public class GetOrganizerByIdRequestTests
  {
    [Fact]
    public async Task Should()
    {
      var api = new EventbriteApi("BKKRDKVUVRC5WG4HAVLT");
      var request = new GetOrganizerByIdRequest(7794529429);
      var response = await api.Execute(request, CancellationToken.None);
    }
  }
}
