
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Range(1, 120, ErrorMessage = "Solo se acepta entre 1 a 120")]
        public int NumberChildren { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Range(1, 120, ErrorMessage = "Solo se acepta entre 1 a 120")]
        public int NumberAdults { get; set; }

        public DateTime Date { get; set; }

        [StringLength(500, MinimumLength = 0, ErrorMessage = "El campo solo acepta entre 2 y 500 caracteres")]
        public string Observations { get; set; }
    }
}
