using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

    public class RazorPagesCarContext : DbContext
    {
        public RazorPagesCarContext (DbContextOptions<RazorPagesCarContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.Car> Car { get; set; }
    }
