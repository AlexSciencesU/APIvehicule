using System.Collections.Generic;

namespace VehiculeAPI
{
    internal class DataLayer : IDataLayer
    {
        public List<Client> Clients { get; set; }
        public List<Vehicule> Vehicules { get; set; }

        public DataLayer()
        {
            this.Clients = new List<Client>();
            this.Vehicules = new List<Vehicule>();
        }
    }
}