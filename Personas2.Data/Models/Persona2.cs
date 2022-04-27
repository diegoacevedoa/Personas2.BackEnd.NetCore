﻿using Personas2.Data.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Personas2.Data.Models
{
    public class Persona2 : BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(200)]
        public string Apellidos { get; set; }

        [Required]
        public int TipoDocumento { get; set; }

        [Required]
        public string NoDocumento { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string NoContacto { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }
    }
}
