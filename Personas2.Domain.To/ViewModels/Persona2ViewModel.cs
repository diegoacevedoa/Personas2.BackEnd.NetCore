using Personas2.Domain.To.Helpers;
using Personas2.Domain.To.ViewModels.Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Personas2.Domain.To.ViewModels
{
    public class Persona2ViewModel : BaseEntityViewModel
    {
        [Display(Name = "Nombres")]
        [StringLength(200)]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [StringLength(200)]
        public string Apellidos { get; set; }

        [Display(Name = "Tipo Documento")]
        [DefaultValue((int)EnumTipoDocumento.CC)]
        public int TipoDocumento { get; set; }

        public string NombreTipoDocumento
        {
            get
            {
                return ((EnumTipoDocumento)TipoDocumento).ToString();
            }
            set { }
        }

        [Display(Name = "No Documento")]
        public string NoDocumento { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "No Contacto")]
        [StringLength(50)]
        public string NoContacto { get; set; }

        [Display(Name = "Email")]
        [StringLength(200)]
        public string Email { get; set; }

        [Display(Name = "Dirección")]
        [StringLength(200)]
        public string Direccion { get; set; }
    }
}
