using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Personas
    {
        public int PersonaId { get; set; }
        [MaxLength(50, ErrorMessage = "maximo 50 caracteres")]
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [RegularExpression(@"^\d+\.?\d{0,2}$", ErrorMessage = "Maximo 2 decimales")]
        [Range(0, 999999999999999999.99, ErrorMessage = "Maximo 20 digitos")]
        public double CreditoMaximo { get; set; }
    }
}
