using coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.EntityConfig
{
    public class oficceEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<oficceEntity> entityBuilder)
        {
            entityBuilder.ToTable("Oficces");
            entityBuilder.HasKey(x => x.id);
            entityBuilder.Property(x => x.id).IsRequired();
            entityBuilder.HasOne(x => x.admin).WithOne(x => x.oficce);
            entityBuilder.HasOne(x => x.booking).WithOne(x => x.oficce);


        }
    }
}
