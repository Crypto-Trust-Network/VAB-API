using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTN_VAB.Providers
{
    /// <summary>
    /// Manages refreshing an OAuth Token
    /// </summary>
    public class ApplicationRefreshTokenProvider : AuthenticationTokenProvider
    {
        /// <summary>
        /// Creates a new token for a user
        /// </summary>
        /// <param name="context">Information about the request etc</param>
        public override void Create(AuthenticationTokenCreateContext context)
        {
            //Expiration time in years
            int expire = 1;
            context.Ticket.Properties.ExpiresUtc = new DateTimeOffset(DateTime.Now.AddYears(expire));
            context.SetToken(context.SerializeTicket());
        }

        /// <summary>
        /// De-serializes the token 
        /// </summary>
        /// <param name="context">Information about the request, including the token to de-serialize</param>
        public override void Receive(AuthenticationTokenReceiveContext context)
        {
            context.DeserializeTicket(context.Token);
        }
    }
}