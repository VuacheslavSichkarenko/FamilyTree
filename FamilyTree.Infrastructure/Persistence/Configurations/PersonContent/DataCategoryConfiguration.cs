﻿using FamilyTree.Domain.Entities.PersonContent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyTree.Infrastructure.Persistence.Configurations.PersonContent
{
    public class DataCategoryConfiguration : IEntityTypeConfiguration<DataCategory>
    {
        public void Configure(EntityTypeBuilder<DataCategory> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.Property(c => c.IsDeletable)
                .HasColumnType("bit")
                .HasDefaultValueSql("1");
        }
    }
}
