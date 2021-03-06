﻿using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UserApi.Data.Repositories
{
    public class ProjectManagerContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }

        public ProjectManagerContext(DbContextOptions<ProjectManagerContext> options)
            : base(options)
        {
        }
    }
}
