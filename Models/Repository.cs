using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static readonly List<GuestResponse> responses = new List<GuestResponse>();

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public static IEnumerable<GuestResponse> Responses => responses;
    }
}
