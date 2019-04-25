using System;
using System.Collections.Generic;
using System.Text;

namespace coworking.Api.DataAccess.Contracts.Entities
{
    public class oficceEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public bool active { get; set; }
        public int idAdmin { get; set; }
        public bool hasIndividualWorkSpace { get; set; }
        public int numberWorkSpaces { get; set; }
        public decimal priceWorSpaceMonth { get; set; }
        public decimal priceWorkSpaceDay { get; set; }



        public virtual adminEntity admin { get; set; }
        public virtual bookingEntity booking { get; set; }
        public virtual ICollection<oficce2RoomsEntity> oficce2Room { get; set; }


    }
}
