using KatmanliProje.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliProje.Dal
{
   public class SirketContext:DbContext
    {
        public SirketContext(DbContextOptions<SirketContext> options):base(options)
        {

        }
         DbSet<Categories> Categories { get; set; }
         DbSet<Products> Products { get; set; }
    }
}
