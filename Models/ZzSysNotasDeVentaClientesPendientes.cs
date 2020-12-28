using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    public partial class ZzSysNotasDeVentaClientesPendientes
    {
        [StringLength(10)]
        public string RutCli { get; set; }
    }
}
