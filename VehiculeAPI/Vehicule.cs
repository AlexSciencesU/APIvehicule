using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculeAPI
{
    public class Vehicule
    {
        public string Immat { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Couleur { get; set; }
        public string PrixReservation { get; set; }
        public string TarifKil { get; set; }
        public string ChevauxFisc { get; set; }


        public Vehicule(string immat, string chevauxFisc, string prixReservation, string tarifKil)
        {
            this.Immat = immat;
            this.ChevauxFisc = chevauxFisc;
            this.PrixReservation = prixReservation;
            this.TarifKil = tarifKil;
        }
    }
}
