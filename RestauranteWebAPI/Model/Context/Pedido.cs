using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RestauranteWebAPI.Model.Context
{
    [Table("PEDIDO")]
    public partial class Pedido
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("NOMBRE_PRODUCTO")]
        public string NombreProducto { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("PRECIO", TypeName = "NUMERIC")]
        public byte[] Precio { get; set; }
        [Column("FOTO")]
        public string Foto { get; set; }
        [Column("CATEGORIA", TypeName = "VARCHAR(50)")]
        public string Categoria { get; set; }
        [Column("CANTIDAD")]
        public long? Cantidad { get; set; }
        [Column("ESTADO")]
        public long? Estado { get; set; }
        [Column("ID_USUARIO")]
        public long? IdUsuario { get; set; }
        [Column("COMENTARIO")]
        public string Comentario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Usuario.Pedidos))]
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
