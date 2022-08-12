using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Telefonos
    {
        public int TelefonoId { get; set; }
        [ForeignKey("Personas")]
        public int PersonaID { get; set; }
        public Personas Persona { get; set; }
        [MaxLength(50, ErrorMessage = "maximo 50 caracteres")]
        public string Telefono { get; set; }
    }
}
