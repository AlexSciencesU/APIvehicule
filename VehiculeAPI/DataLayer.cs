using System.Collections.Generic;

namespace VehiculeAPI
{
    internal class DataLayer : IDataLayer
    {
        public List<Client> Clients { get; set; }

        public DataLayer()
        {
            this.Clients = new List<Client>();
        }
    }
}