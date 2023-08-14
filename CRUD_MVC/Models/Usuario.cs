﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public DateTime? Fecha { get; set; }

        public string? Clave { get; set; }

    }
}
