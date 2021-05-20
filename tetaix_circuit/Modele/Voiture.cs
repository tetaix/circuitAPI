using System;
namespace tetaix_circuit.Modele
{
    public class Voiture
    {

        public int VoitureId { get; set; }
        public string Nom { get; set; }
        public int puissance { get; set; }
        public int nb_place { get; set; }
        public int vmax { get; set; }
        public int annee { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int etat_voiture { get; set; }

    }
}
