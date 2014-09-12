﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberParty { get; set; }
        public string ContactPhone { get; set; }
        public string ReservationStatus { get; set; }
        public string EventCode { get; set; }
    }
}
