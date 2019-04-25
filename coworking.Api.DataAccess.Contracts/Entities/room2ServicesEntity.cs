using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.Contracts.Entities
{
    public class room2ServicesEntity
    {
        public int idRoom {get;set;}
        public int idService {get;set;}
        public virtual roomEntity room { get; set; }
        public virtual servicesEntity services { get; set; }
    }
}
