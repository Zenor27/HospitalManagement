using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace HospitalClient.Utils
{
    public class User
    {
        public static int GetCurrentUserId(HttpContext context)
        {
            return int.Parse(context.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);
        }
    }
}
