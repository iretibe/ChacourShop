using ChacourShop.OAuth.Data;
using ChacourShop.OAuth.Models;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ChacourShop.OAuth.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            if (_roleManager.FindByNameAsync(ServiceProvider.Admin).Result == null)
            {
                _roleManager.CreateAsync(new IdentityRole(ServiceProvider.Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(ServiceProvider.Customer)).GetAwaiter().GetResult();
            }
            else { return; }

            ApplicationUser adminUser = new ApplicationUser()
            {
                UserName = "somady12@gmail.com",
                Email = "somady12@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "00233245508217",
                FirstName = "Somad",
                LastName = "Yessoufou"
            };

            _userManager.CreateAsync(adminUser, "Somad@2021").GetAwaiter().GetResult();

            _userManager.AddToRoleAsync(adminUser, ServiceProvider.Admin).GetAwaiter().GetResult();

            var temp1 = _userManager.AddClaimsAsync(adminUser, new Claim[] {
                new Claim(JwtClaimTypes.Name, adminUser.FirstName + " " + adminUser.LastName),
                new Claim(JwtClaimTypes.GivenName, adminUser.FirstName),
                new Claim(JwtClaimTypes.FamilyName, adminUser.LastName),
                new Claim(JwtClaimTypes.Role, ServiceProvider.Admin),
            }).Result;

            ApplicationUser customerUser = new ApplicationUser()
            {
                UserName = "yessouf2009@yahoo.fr",
                Email = "yessouf2009@yahoo.fr",
                EmailConfirmed = true,
                PhoneNumber = "00233245508217",
                FirstName = "Yessoufou",
                LastName = "Somad"
            };

            _userManager.CreateAsync(customerUser, "Admin@2021").GetAwaiter().GetResult();

            _userManager.AddToRoleAsync(customerUser, ServiceProvider.Customer).GetAwaiter().GetResult();

            var temp2 = _userManager.AddClaimsAsync(customerUser, new Claim[] {
                new Claim(JwtClaimTypes.Name, customerUser.FirstName+" "+ customerUser.LastName),
                new Claim(JwtClaimTypes.GivenName, customerUser.FirstName),
                new Claim(JwtClaimTypes.FamilyName, customerUser.LastName),
                new Claim(JwtClaimTypes.Role, ServiceProvider.Customer),
            }).Result;
        }
    }
}
