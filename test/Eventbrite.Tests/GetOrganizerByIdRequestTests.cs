﻿using System;
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
    public async Task Should()
    {
      var api = new EventbriteApi();
      api.SetOAuthToken("");
      var request = new GetOrganizerByIdRequest(7794529429);
      var response = await api.Execute(request, CancellationToken.None);
    }

    [Fact]
    public void lol()
    {
      var test = "lol/"
        .AppendPathSegment("lol/test?lol=t&test=test")
        .SetQueryParam("new", "newdata");

    }
  }
}
