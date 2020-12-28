using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ProductosPendientesDeRecepción
    {
        [StringLength(10)]
        public string CodBase { get; set; }
        public double? Expr1 { get; set; }
    }
}
