using coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.EntityConfig
{
    public class adminEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<adminEntity> entityBuilder)
        {
            entityBuilder.ToTable("Admins");
            entityBuilder.HasKey(x => x.id);
            entityBuilder.Property(x => x.id).IsRequired();
            entityBuilder.HasOne(x => x.Oficce).WithOne(x => x.admin);


        }
    }
}
