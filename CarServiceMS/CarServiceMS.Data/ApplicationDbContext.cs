﻿using System;
using System.Collections.Generic;
using System.Text;
using CarServiceMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarServiceMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> User { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Manipulation> Manipulations { get; set; }
    }
}