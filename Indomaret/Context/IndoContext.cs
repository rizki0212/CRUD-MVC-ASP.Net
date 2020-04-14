using Indomaret.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Indomaret.Context
{
    public class IndoContext : DbContext
    {
        public DbSet<Indomaretku> indomaret { get; set; }
    }
}