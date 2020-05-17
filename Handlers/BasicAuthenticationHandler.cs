using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AspNetCoreWebApi.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly BookStoresDbContext _context;

        public BasicAuthenticationHandler(BookStoresDbContext context,
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock) : base(options, logger, encoder, clock)
        {
            _context = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            //emailaddress=john.smith@gmail.com
            //password=8be7dbd7237e2e0bf90ff81b8ff44333
            //=> converted to base64 on https://www.base64encode.org/ =>
            //am9obi5zbWl0aEBnbWFpbC5jb206OGJlN2RiZDcyMzdlMmUwYmY5MGZmODFiOGZmNDQzMzM=

            var bytes = Encoding.UTF8.GetBytes("emailAdress:password");
            var base64 = Convert.ToBase64String(bytes);

            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Authorization header was not found");
            }

            try
            {
                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var outputBytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                var credentials = Encoding.UTF8.GetString(outputBytes).Split(':');
                var email = credentials[0];
                var password = credentials[1];
                var user = await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress == email && u.Password == password);
                if (user == null)
                {
                    return AuthenticateResult.Fail("Invalid username or passord");
                }
                else
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, user.EmailAddress) };
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);
                    return AuthenticateResult.Success(ticket);
                }
            }
            catch (System.Exception)
            {
                return AuthenticateResult.Fail("Error has ocurred");
            }
        }
    }
}