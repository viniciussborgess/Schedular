using Microsoft.EntityFrameworkCore;
using Schedular.Domain.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Infrastrucrure.Data;

public class ApplicationDataContext: DbContext
{
    public DbSet<Event> Events { get; set; }

    public ApplicationDataContext(DbContextOptions<ApplicationDataContext> opitions) : base(opitions) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDataContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
