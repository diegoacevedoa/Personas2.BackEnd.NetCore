using System;
using System.ComponentModel.DataAnnotations;

namespace Personas2.Domain.To.ViewModels.Base
{
    public class BaseEntityViewModel
    {      
        public int Id { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }

        [Display(Name = "Eliminado")]
        public bool Eliminado { get; set; }

        [Display(Name = "UsuarioRegistro")]
        public int UsuarioRegistro { get; set; }

        [Display(Name = "UsuarioModifica")]
        public int UsuarioModifica { get; set; }

        [Display(Name = "UsuarioElimina")]
        public int UsuarioElimina { get; set; }

        [Display(Name = "FechaRegistro")]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "FechaModificado")]
        public DateTime FechaModificado { get; set; }

        [Display(Name = "FechaEliminado")]
        public DateTime FechaEliminado { get; set; }
    }
}
