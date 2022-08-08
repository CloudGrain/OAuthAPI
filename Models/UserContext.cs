using Microsoft.EntityFrameworkCore;
using OAuthV2API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OAuthV2API.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions dbContextOptions)
       : base(dbContextOptions)
        {
        }
        public DbSet<LoginModel> LoginModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginModel>().HasData(new LoginModel
            {
                Id = 1,
                UserName = "[UserName]",
                Password = "[Password]"
            });
        }
    }
}
