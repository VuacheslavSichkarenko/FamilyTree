﻿using FamilyTree.Domain.Entities.Media;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyTree.Infrastructure.Persistence.Configurations.Media
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ImageData)
                .HasColumnType("image")
                .IsRequired();

            builder.Property(i => i.ImageFormat)
                .HasColumnType("nvarchar(10)")
                .IsRequired();

            builder.Property(i => i.Title)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.Property(i => i.Description)
                .HasColumnType("nvarchar(1000)");
        }
    }
}
