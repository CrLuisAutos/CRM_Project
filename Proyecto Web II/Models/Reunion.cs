using Proyecto_Web_II.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto_Web_II.Models
{
    public class Reunion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Requerido"), DisplayName("Título")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "El título debe tener una longitud entre 2 y 15 caracteres")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "Requerido"), DisplayName("Fecha y hora"), DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
        [DisplayName("Es Virtual")]
        public bool EsVirtual { get; set; }

        public int CuentaId { get; set; }
        [ForeignKey("CuentaId")]

        public virtual Cuenta Cuenta { get; set; }
    }
}