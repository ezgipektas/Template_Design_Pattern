using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template_Design_Pattern.DAL.Entities;

namespace Template_Design_Pattern.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-FJT4L6QM;initial catalog=DbTemplateDesign;integrated security=true");
        }
       
    }
}
