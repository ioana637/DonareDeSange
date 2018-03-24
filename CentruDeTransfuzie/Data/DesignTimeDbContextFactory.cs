using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace CentruDeTransfuzie1.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CTContext>
    {
       public CTContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CTContext>();
            builder.UseSqlServer(Configuration.ConnectionString);
            return new CTContext(builder.Options);
        } 

    }
}
