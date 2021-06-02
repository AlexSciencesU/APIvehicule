using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculeAPI
{
    public class Reservation
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string VehiculeImmat { get; set; }
        public string ClientUsername { get; set; }

        public Reservation(string startDate, string endDate, string vehiculeImmat, string clientUsername)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.VehiculeImmat = vehiculeImmat;
            this.ClientUsername = clientUsername;
        }


    }
}
