using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.Contracts.Entities
{
    public class oficce2RoomsEntity
    {
        public int idOficce { get; set; }
        public int idRoom { get; set; }
        public virtual oficceEntity oficce { get; set; }
        public virtual roomEntity room { get; set; }

    }
}
