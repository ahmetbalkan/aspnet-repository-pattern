using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extentions
{
    public static class ClaimExtentions
    {
        public static void AddEmail(this ICollection<System.Security.Claims.Claim> claims, string email)
        {
            claims.Add(new System.Security.Claims.Claim("email", email));
        }
        public static void AddName(this ICollection<System.Security.Claims.Claim> claims, string name)
        {
            claims.Add(new System.Security.Claims.Claim("name", name));
        }
        public static void AddNameIdentifier(this ICollection<System.Security.Claims.Claim> claims, string nameIdentifier)
        {
            claims.Add(new System.Security.Claims.Claim("nameIdentifier", nameIdentifier));
        }
        public static void AddRoles(this ICollection<System.Security.Claims.Claim> claims, string[] roles)
        {
            roles.ToList().ForEach(role => claims.Add(new System.Security.Claims.Claim("roles", role)));
        }
    }
}
