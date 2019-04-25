using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.Contracts.Entities
{
    public class bookingEntity
    {
        public int id { get; set; }
        public int userId { get; set; }
        public DateTime bookingDate { get; set; }
        public DateTime createDate { get; set; }
        public int oficceId { get; set; }
        public bool rentWorkSpace { get; set; }
        public int? roomId { get; set; }
        public virtual userEntity user { get; set; }
        public virtual oficceEntity oficce { get; set; }

    }
}
