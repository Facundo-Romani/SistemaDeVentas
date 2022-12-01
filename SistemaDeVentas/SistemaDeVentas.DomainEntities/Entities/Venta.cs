﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.DomainEntities.Entities
{
    /// <summary>
    /// Detalle de venta.
    /// </summary>
    public class Venta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime? Fecha { get; set; }

        [Required]
        public decimal Total { get; set; }

        [ForeignKey("Cliente")]
        public int Id_cliente { get; set; }
        public Cliente cliente { get; set; }

    }
}
