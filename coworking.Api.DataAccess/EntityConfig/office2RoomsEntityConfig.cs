using coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.EntityConfig
{
    public class oficce2RoomsEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<oficce2RoomsEntity> entityBuilder)
        {
            entityBuilder.ToTable("Oficce2Room");
            entityBuilder.HasOne(x => x.oficce).WithMany(X => X.oficce2Room).HasForeignKey(x => x.idOficce);
            entityBuilder.HasOne(x => x.room).WithMany(X => X.oficce2Room).HasForeignKey(x => x.idRoom);
            entityBuilder.HasKey(x => new { x.idOficce, x.idRoom });
            entityBuilder.Property(x => x.idOficce).IsRequired();
            entityBuilder.Property(x => x.idRoom).IsRequired();



        }
    }
}
