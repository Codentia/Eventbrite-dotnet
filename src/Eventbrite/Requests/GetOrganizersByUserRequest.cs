using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Entities;
using Eventbrite.Responses;

namespace Eventbrite.Requests
{
    public class GetOrganizersByUserRequest : IRequest<OrganizersResponse>
    {
        public GetOrganizersByUserRequest(long userId)
        {
            this.UserId = userId;
        }

        public long UserId { get; private set; }
        public HttpMethod HttpMethod { get { return HttpMethod.Get; } }
        public string RequestUri { get { return string.Format("/v3/users/{0}/organizers", this.UserId); } }
    }
}
