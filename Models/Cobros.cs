using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VictorP2_AP2.Models
{
      public class Cobros
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        public int CobroId { get; set; }

        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime Fecha { get; set; }

        [Range(1, 1000000, ErrorMessage = "Debe elegir un cliente...")]
        public int ClienteId { get; set; }

        [Range(1, 1000000, ErrorMessage = "Debe elegir una venta...")]
        public int VentaId { get; set; }

        public double Cobrado { get; set; }

        public string Observaciones { get; set; }
       
        [ForeignKey("CobroId")]
        public virtual List<CobrosDetalle> CobrosDetalle { get; set; }


        public Cobros()
        {
            CobroId = 0;
            Fecha = DateTime.Now;
            ClienteId =0;
            VentaId =0;
            Cobrado= 0;
            Observaciones = string.Empty;
            CobrosDetalle = new List<CobrosDetalle>();
        }
        
    }

}