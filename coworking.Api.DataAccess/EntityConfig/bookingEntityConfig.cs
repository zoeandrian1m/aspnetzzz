using coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.EntityConfig
{
    public class bookingEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<bookingEntity> entityBuilder)
        {
            entityBuilder.ToTable("Bookings");
            entityBuilder.HasKey(x => x.id);
            entityBuilder.Property(x => x.id).IsRequired();
            entityBuilder.HasOne(x => x.oficce).WithOne(x => x.booking);
            entityBuilder.HasOne(x => x.user).WithOne(x => x.booking);


        }
    }
}
