using LuanvanCTUET.Data.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanvanCTUET.Data.EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public DbInitializer(AppDbContext context, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public async Task Seed()
        {
            if(_context.Categories.Count() == 0) 
            {
                _context.Categories.AddRange(new List<Category>()
                {
                    new Category() {Name="Điện thoại", Description="sản phẩm di động", HomeFlag=true, DateCreated=DateTime.Now},
                    new Category() {Name="Laptop", Description="máy tính", HomeFlag=true, DateCreated=DateTime.Now},
                    new Category() {Name="Máy tính bảng", Description="sản phẩm di động", HomeFlag=true, DateCreated=DateTime.Now},
                });    
            }
            if(!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Top manager"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "staff",
                    NormalizedName = "staff",
                    Description = "staff"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "customer",
                    NormalizedName = "customer",
                    Description = "customer"
                });
            }
            if (!_userManager.Users.Any())
            {
                await _userManager.CreateAsync(new AppUser()
                {
                    UserName = "admin",
                    FullName = "administrator",
                    Email = "admin@gmail.com",
                    Balance = 0,
                }, "123456");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            _context.SaveChanges();
        }

    }
}
