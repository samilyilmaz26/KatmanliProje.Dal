using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliProje.Dal
{
    public class KatmanliProjeFactory : IDesignTimeDbContextFactory<SirketContext>
    {
        public SirketContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SirketContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-PG28H37\\SQLEXPRESS;Database=SirketDB;Trusted_Connection=True;");
            return new SirketContext(optionsBuilder.Options);
        }
    }
}
