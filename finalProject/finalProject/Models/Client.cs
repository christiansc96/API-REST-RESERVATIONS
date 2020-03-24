using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El campo solo acepta entre 2 y 100 caracteres")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [Range(1, 120, ErrorMessage = "Solo se acepta entre 1 a 120")]
        public int Age { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(8, MinimumLength = 7,ErrorMessage ="El campo solo acepta entre 7 y 8 caracteres")]
        [Phone(ErrorMessage = "Ingrese un número correcto")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El campo solo acepta entre 2 y 100 caracteres")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico correcto")]
        public string Email { get; set; }
    }
}
