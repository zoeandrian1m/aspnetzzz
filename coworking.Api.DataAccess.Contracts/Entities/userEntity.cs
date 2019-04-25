using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.Contracts.Entities
{
    public class userEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string eMail { get; set; }
        public bool active { get; set; }
        public DateTime createDate { get; set; }


        public virtual bookingEntity booking { get; set; }

    }
}
