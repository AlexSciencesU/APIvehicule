using System;
using System.Linq;

namespace VehiculeAPI
{
    public class Location
    {
        private IDataLayer _datalayer;

        public bool UserConnected { get; private set; }

        public Location()
        {
            this._datalayer = new DataLayer();
        }

        public Location(IDataLayer dataLayer)
        {
            this._datalayer = dataLayer;
        }

        public string ConnectUser(string username, string password)
        {
            Client client = this._datalayer.Clients.SingleOrDefault(_ => _.Username == username);
            if(client == null)
            {
                this.UserConnected = false;
                return "Username not recognized";
            }
            else
            {
                if (client.Password == password)
                {
                    this.UserConnected = true;
                }
                else
                {
                    this.UserConnected = false;
                    return "Incorrect password";
                }
            }
            return "";
        }

        public string makeReservation(string startDate, string endDate)
        {
            new Reservation(startDate, endDate);
            return "Reservation accepted";
        }

    }
}
