using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ebookshopping.Models;

namespace ebookshopping.Data
{
    public class ebookshoppingContext : DbContext
    {
        public ebookshoppingContext(DbContextOptions<ebookshoppingContext> options)
            : base(options)
        {
        }

        public DbSet<ebookshopping.Models.book>? book { get; set; }

        public DbSet<ebookshopping.Models.usersaccounts>? usersaccounts { get; set; }

        public DbSet<ebookshopping.Models.orders>? orders { get; set; }
        public DbSet<ebookshopping.Models.report>? report { get; set; }
    }
}
