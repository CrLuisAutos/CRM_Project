using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_Web_II.Models
{
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Nombre")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "El nombre debe tener una longitud entre 2 y 10 caracteres")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Cédula Jurídica")]
        public int Cedula_Juridica { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Página Web")]
        public String Pagina_Web { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Dirección Física")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "La dirección física debe tener una longitud 10 y 150 caracteres")]
        public String Direccion_Fisica { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [DisplayName("Número de Teléfono")]
        public int Numero_de_telefono { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public SectorList Sector { get; set; }

    }
    public enum SectorList
    {
        Educación,
        Industria,
        Agricola,
        Manufactura,
        Servicios
    }
}
