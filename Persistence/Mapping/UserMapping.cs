﻿using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Mapping;

public class UserMapping : EntityTypeConfiguration<User>
{
    #region Configures

    /// <summary>
    /// Configures the entity
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity</param>
    /// <param name="entity"></param>
    public override void Configure(EntityTypeBuilder<User> entity)
    {

        entity.ToTable(nameof(User), "public");

        entity.HasKey(st =>  st.ProviderToken);

        entity.Property(a => a.Id)
            .ValueGeneratedOnAdd();

        entity.Property(a => a.ProviderToken);

        entity.Property(a => a.Email);

        entity.Property(a => a.Password);

        entity.Property(a => a.Name);

        entity.Property(a => a.IsAdmin);

        entity.Property(a => a.ProfilePicture);

        entity.Property(_ => _.IsDeleted).IsRequired().HasDefaultValue(false);


        entity.HasMany(s => s.Wishlists)
            .WithOne(st => st.User)
            .HasForeignKey(st => st.ProviderToken);

        #endregion

        #region Seeding data
        entity.HasData(
            new List<User>()
            {

            }
        );
        #endregion

        base.Configure(entity);
    }

}