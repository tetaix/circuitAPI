using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace tetaix_circuit.Modele
{
    public class Circuit
    {
        public int CircuitId { get; set; }
        public string nom_circuit { get; set; }
        public int nombre_km { get; set; }
        public int etat_circuit { get; set; }

    }
}
