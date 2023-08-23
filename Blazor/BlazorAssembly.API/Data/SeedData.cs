using BlazorAssembly.API.Entities;
using Microsoft.AspNetCore.Identity;
using Task = System.Threading.Tasks.Task;

namespace BlazorAssembly.API.Data
{
    public class SeedData
    {
        private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
        public async Task SeedAsync(BlazorDbContext context, ILogger<BlazorDbContext> logger)
        {
            if (!context.Users.Any())
            {
                var user = new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Mr",
                    LastName = "A",
                    Email = "Admin@gmail.com",
                    PhoneNumber = "0858032268",
                    UserName = "admin"
                };
                user.PasswordHash = _passwordHasher.HashPassword(user, "Nhan123?");
                context.Users.Add(user);

            };
            if (!context.Tasks.Any())
            {
                context.Tasks.Add(new Entities.Task()
                {
                    Id = Guid.NewGuid(),
                    Name = "Same task 1",
                    CreateDate = DateTime.Now,
                    Priority = Enums.Priority.High,
                    Status = Enums.Status.Canceled
                });
            };
            await context.SaveChangesAsync();
        }
    }
}
