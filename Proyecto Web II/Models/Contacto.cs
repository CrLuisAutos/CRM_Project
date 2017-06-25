using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_Web_II.Models
{
    public class Contactos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Nombre")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "El nombre debe tener una longitud entre 2 y 10 caracteres")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Apellido")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "El apellido debe tener una longitud entre 2 y 15 caracteres")]
        public String Apellido{ get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Correo Electrónico")]
        [EmailAddress(ErrorMessage = "Correo Electrónico invalido")]
        public String Email { get; set; }

        [Required (ErrorMessage ="Requerido")]
        [DisplayName("Teléfono")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{4})$", ErrorMessage = "Número de Teléfono invalido")]
        public String Telefono { get; set; }

        [Required(ErrorMessage ="Requerido")]
        [DisplayName("Puesto")]
        [StringLength(15, MinimumLength = 2, ErrorMessage ="El máximo de caracteres permitido es de 15")]
        public String Puesto { get; set; }
        
        public int CuentaId{ get; set; }

        [ForeignKey("CuentaId")]
        public virtual Cuenta Cuenta { get; set; }
    }
}