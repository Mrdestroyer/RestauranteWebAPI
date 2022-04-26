using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RestauranteWebAPI.Model.Context
{
    [Table("QUEJAS")]
    public partial class Queja
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("NOMBRE_EMISOR", TypeName = "VARCHAR(90)")]
        public string NombreEmisor { get; set; }
        [Column("CORREO", TypeName = "VARCHAR(180)")]
        public string Correo { get; set; }
        [Column("QUEJA")]
        public string Queja1 { get; set; }
    }
}
