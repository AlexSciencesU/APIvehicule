using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculeAPI
{
    public interface IDataLayer
    {
        List<Client> Clients { get; set; }
    }
}
