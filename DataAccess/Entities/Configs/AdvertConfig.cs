﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities.Configs
{
	public class AdvertConfig : IEntityTypeConfiguration<Advert>
	{
		public void Configure(EntityTypeBuilder<Advert> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Title);
			builder.Property(x => x.Description);
			builder.Property(x => x.Date);
			builder.Property(x => x.IsNew);
			builder.Property(x => x.Price).HasPrecision(12, 2);
			builder.HasOne(x => x.User).WithMany(x => x.Adverts).HasForeignKey(x=>x.UserId);
			builder.HasOne(x => x.City).WithMany(x => x.Adverts).HasForeignKey(x => x.CityId);
			builder.HasOne(x => x.Category).WithMany(x => x.Adverts).HasForeignKey(x => x.CategoryId);
			builder.ToTable(t => t.HasCheckConstraint("Title_check", "[Title] <> ''"));
			builder.ToTable(t => t.HasCheckConstraint("Description_check", "[Description] <> ''"));
		}
	}
}
