
using coworking.Api.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess
{
    public class coworkingDBContext : DbContext, IcoworkingDBContext
    {
        public coworkingDBContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
