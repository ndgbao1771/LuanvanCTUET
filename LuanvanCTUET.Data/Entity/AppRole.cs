using Microsoft.AspNetCore.Identity;

namespace LuanvanCTUET.Data.Entity
{
    public class AppRole : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}