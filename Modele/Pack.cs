using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace tetaix_circuit.Modele
{
    public class Pack
    {
        public int PackId { get; set; }
        public int nom_pack { get; set; }
        public int nb_tour { get; set; }


        public int CircuitId { get; set; }
        [ForeignKey("CircuitId")]
        public Circuit Circuit { get; set; }

        public int VoitureId { get; set; }
        [ForeignKey("VoitureId")]
        public Voiture Voiture { get; set; }
    }
}
