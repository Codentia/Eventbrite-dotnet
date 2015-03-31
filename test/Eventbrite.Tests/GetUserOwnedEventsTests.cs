﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Entities;
using Eventbrite.Requests;
using Newtonsoft.Json;
using Xunit;
using System.Threading.Tasks;
using System.Threading;

namespace Eventbrite.Tests
{
  public class GetUserOwnedEventsTests
  {
    [Fact]
    public async Task Should_return_owned_events()
    {
      long id = 89307119205;
      var api = new EventbriteApi();
      api.SetOAuthToken("BKKRDKVUVRC5WG4HAVLT");
      var request = new GetUserOwnedEventsRequest(id);
      var response = await api.Execute(request, CancellationToken.None);

      Assert.NotEmpty(response.Events);
    }
  }
}
