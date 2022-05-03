using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADN104FinalProjectWozU.Models
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
    }
}
