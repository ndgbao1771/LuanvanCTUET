using LuanvanCTUET.Data.Enum;
using LuanvanCTUET.Data.Interface;
using Microsoft.AspNetCore.Identity;
using System;

namespace LuanvanCTUET.Data.Entity
{
    public class AppUser : IdentityUser<string>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Balance { get; set; }
        public string Avatar { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}