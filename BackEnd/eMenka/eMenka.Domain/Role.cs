using Microsoft.AspNetCore.Identity;

namespace eMenka.Domain
{
    public class Role : IdentityRole<int>
    {
        public const string Admin = "admin";
        public const string Client = "client";
    }
}