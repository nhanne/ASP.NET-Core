using BlazorAssembly.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task = BlazorAssembly.API.Entities.Task;

namespace BlazorAssembly.API.Data
{
    public class BlazorDbContext : IdentityDbContext<User,Role,Guid>    
    {
        public BlazorDbContext(DbContextOptions<BlazorDbContext> options) : base(options) {
        
        
        }
        public DbSet<Task> Tasks { get; set; }  
    }
}
