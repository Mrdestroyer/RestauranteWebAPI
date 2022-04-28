using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RestauranteWebAPI.Model.Context
{
    [Table("USUARIO")]
    public partial class Usuario
    {
        public Usuario()
        {
            Pedidos = new HashSet<Pedido>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NOMBRE_USUARIO", TypeName = "VARCHAR(60)")]
        public string NombreUsuario { get; set; }
        [Required]
        [Column("CONTRASENA", TypeName = "VARCHAR(150)")]
        public string Contrasena { get; set; }
        [Column("CORREO", TypeName = "VARCHAR(120)")]
        public string Correo { get; set; }
        [Column("NOMBRE", TypeName = "VARCHAR(80)")]
        public string Nombre { get; set; }
        [Column("ROLL", TypeName = "VARCHAR(30)")]
        public string Roll { get; set; }

        [InverseProperty(nameof(Pedido.IdUsuarioNavigation))]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
