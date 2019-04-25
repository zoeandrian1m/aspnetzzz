﻿using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.Contracts.Entities
{
    public class servicesEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public decimal price { get; set; }
        public virtual ICollection<oficce2RoomsEntity> oficce2Room { get; set; }
        public virtual ICollection<room2ServicesEntity> room2Services { get; set; }
    }
}
