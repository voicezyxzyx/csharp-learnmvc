using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class AccountDbContext
    {
        public DbSet<AccountDbContext> AccountDbContexts { get; set; }
    }
}