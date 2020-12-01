using System;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace eMenka.Domain
{
    public class User : IdentityUser<int>
    {
        public override string Email { get; set; }

        [IgnoreDataMember] public override bool EmailConfirmed { get; set; }

        [IgnoreDataMember] public override bool TwoFactorEnabled { get; set; }

        [IgnoreDataMember] public override string PhoneNumber { get; set; }

        [IgnoreDataMember] public override bool PhoneNumberConfirmed { get; set; }

        [IgnoreDataMember] public override string PasswordHash { get; set; }

        [IgnoreDataMember] public override string SecurityStamp { get; set; }

        [IgnoreDataMember] public override bool LockoutEnabled { get; set; }

        [IgnoreDataMember] public override DateTimeOffset? LockoutEnd { get; set; }

        [IgnoreDataMember] public override int AccessFailedCount { get; set; }

        [IgnoreDataMember] public override string NormalizedEmail { get; set; }

        [IgnoreDataMember] public override string NormalizedUserName { get; set; }

        [IgnoreDataMember] public override string ConcurrencyStamp { get; set; }
    }
}