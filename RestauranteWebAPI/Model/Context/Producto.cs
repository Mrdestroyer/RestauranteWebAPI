using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RestauranteWebAPI.Model.Context
{
    [Table("PRODUCTO")]
    public partial class Producto
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
        [Column("CATEGORIA")]
        public long? Categoria { get; set; }
    }
}
