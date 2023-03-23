using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserDetails_API.Models;

namespace UserDetails_API.Data
{
    public class UserDetails_APIContext : DbContext
    {
        public UserDetails_APIContext (DbContextOptions<UserDetails_APIContext> options)
            : base(options)
        {
        }

        public DbSet<UserDetails_API.Models.UserDetails> UserDetails { get; set; } = default!;
    }
}
