using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedular.Domain.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Infrastrucrure.Data.Configuration;

internal class EventEntityConfiguration: IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(_ => _.Id);

        builder.Property(_ => _.Id)
            .ValueGeneratedNever();

        builder.Property(_ => _.Name)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);

        builder.Property(_ => _.Description)
            .IsRequired()
            .HasMaxLength(600)
            .IsUnicode(false);

        builder.Property(_ => _.DateEvent)
            .IsRequired();
    }
}
