﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class BookingDetail
    {
        public int BookingReservationID { get; set; }
        public int RoomID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal ActualPrice { get; set; }

        public BookingDetail() { }
    }
}
