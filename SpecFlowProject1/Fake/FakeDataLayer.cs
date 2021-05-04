using System;
using System.Collections.Generic;
using System.Text;
using VehiculeAPI;

namespace SpecFlowProject1.Fake
{
    public class FakeDataLayer : IDataLayer
    {
        public List<Client> Clients { get; set; }

        public FakeDataLayer()
        {
            this.Clients = new List<Client>();
        }
    }
}
