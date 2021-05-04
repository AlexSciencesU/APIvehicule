using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculeAPI
{
    public class Reservation
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public Reservation(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }


    }
}
