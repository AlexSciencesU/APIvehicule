using System;
using System.Collections.Generic;
using System.Text;
using VehiculeAPI;

namespace SpecFlowProject1.Fake
{
    public class FakeDataLayer : IDataLayer
    {
        public List<Client> Clients { get; set; }
        public List<Vehicule> Vehicules { get; set; } 

        public FakeDataLayer()
        {
            this.Clients = new List<Client>();
            this.Vehicules = new List<Vehicule>();
        }
    }
}
