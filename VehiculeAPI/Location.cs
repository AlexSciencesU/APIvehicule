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

        public string MakeReservation(string startDate, string endDate, string immat, string username, string plannedKm)
        {
            Client client = this._datalayer.Clients.SingleOrDefault(_ => _.Username == username);
            Vehicule vehicule = this._datalayer.Vehicules.SingleOrDefault(_ => _.Immat == immat);
            DateTime currentDate = DateTime.Now;
            DateTime bithdate = Convert.ToDateTime(client.BirthDate);
            int anneeCurrent = currentDate.Year;
            int anneeBirthday = bithdate.Year;
            int compare = anneeCurrent - anneeBirthday;
            int chevauxFiscaux = int.Parse(vehicule.ChevauxFisc);
            if (compare < 18) {
                return "Client can't reserve because he is minor";
            }
            else if (compare < 21 && compare < 25 && chevauxFiscaux >= 8)
            {
                return "Client can't reserve this car because he is too young (-21)";
            }
            else if (compare < 25 && chevauxFiscaux > 13)
            {
                return "Client can't reserve this car because he is too young (-25)";
            }
            int prixReserv = int.Parse(vehicule.PrixReservation);
            double tarifKil = double.Parse(vehicule.TarifKil);
            int plannedKLM = int.Parse(plannedKm);
            double total = prixReserv + (plannedKLM * tarifKil);
            Reservation reservation = new Reservation(startDate, endDate, vehicule.Immat, client.Username);
            return ($"{username} : Reservation accepted for {vehicule.Immat} vehicule from {reservation.StartDate} to {reservation.EndDate} and it will cost {total}€");

        }

    }
}
