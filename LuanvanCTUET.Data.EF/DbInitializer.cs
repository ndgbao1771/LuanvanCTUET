using LuanvanCTUET.Data.Entity;
using LuanvanCTUET.Data.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
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

        /*public async Task Seed()
        {
            if (_context.Categories.Count() == 0)
            {
                _context.Categories.AddRange(new List<Category>()
                {
                    new Category() {Name="Điện thoại", Description="sản phẩm di động", HomeFlag=true, DateCreated=DateTime.Now},
                    new Category() {Name="Laptop", Description="máy tính", HomeFlag=true, DateCreated=DateTime.Now},
                    new Category() {Name="Máy tính bảng", Description="sản phẩm di động", HomeFlag=true, DateCreated=DateTime.Now},
                });
            }
            if (!_roleManager.Roles.Any())
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
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    Balance = 0,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Status = Status.Active
                }, "123654$");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            _context.SaveChanges();
        }*/

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();

                InitializeRoles(roleManager);
                InitializeUsers(userManager);
            }


        }
        private static void InitializeRoles(RoleManager<AppRole> roleManager)
        {
            // Kiểm tra xem các roles đã tồn tại hay chưa
            if (roleManager.Roles.Any())
            {
                return; // Các roles đã tồn tại, không cần tạo mới
            }

            // Tạo các roles mới
            var roles = new[]
            {
            new AppRole { Name = "admin",
                    NormalizedName = "admin",
                    Description = "Top manager" },
            new AppRole { Name = "staff",
                    NormalizedName = "staff",
                    Description = "staff" }
        };

            foreach (var role in roles)
            {
                role.Id = Guid.NewGuid().ToString();
                roleManager.CreateAsync(role).GetAwaiter().GetResult();
            }
        }

        private static void InitializeUsers(UserManager<AppUser> userManager)
        {
            // Kiểm tra xem các users đã tồn tại hay chưa
            if (userManager.Users.Any())
            {
                return; // Các users đã tồn tại, không cần tạo mới
            }

            // Tạo các users mới
            var users = new[]
            {
            new AppUser { UserName = "admin",
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    Balance = 0,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Status = Status.Active,
                    EmailConfirmed = true }
        };

            foreach (var user in users)
            {
                user.Id = Guid.NewGuid().ToString();
                userManager.CreateAsync(user, "123456").GetAwaiter().GetResult();
                userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult(); // Gán role "Admin" cho user "admin@example.com"
            }

        }
    }
}