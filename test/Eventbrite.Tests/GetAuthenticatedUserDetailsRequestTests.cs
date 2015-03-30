using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Requests;

namespace Eventbrite.Tests
{

  public class GetAuthenticatedUserDetailsRequestTests
  {

    public async Task Should()
    {
      var api = new EventbriteApi("");
      var response = await api.Execute(new GetUserDetailsByUserIdRequest(1));
    }
  }
}
