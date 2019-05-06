using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PremierTestEntitiesFramework
{
    class DefaultContext : DbContext
    {
        public DefaultContext( DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }
        public DbSet<Droide> dbSetDroid;

    }
}
