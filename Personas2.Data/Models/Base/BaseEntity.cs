using System;
using System.ComponentModel.DataAnnotations;

namespace Personas2.Data.Models.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Activo = true;
            Eliminado = false;
            FechaRegistro = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public bool Eliminado { get; set; }

        [Required]
        public int UsuarioRegistro { get; set; }

        public int? UsuarioModifica { get; set; }

        public int? UsuarioElimina { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        public DateTime? FechaModificado { get; set; }

        public DateTime? FechaEliminado { get; set; }
    }
}
