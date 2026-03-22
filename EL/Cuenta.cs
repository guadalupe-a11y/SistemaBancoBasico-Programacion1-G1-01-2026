using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
public class Cuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int CuentaId { get; set; }

        [Required]
        [StringLength(30)]
        [Index("UQ_NumeroCuenta", IsUnique = true)]
        public string NumeroCuenta { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        // propiedades de navegación
        public Cliente Cliente { get; set; }

        [Required]
        [ForeignKey("TipoCuenta")]
        public int TipoCuentaId { get; set; }
        // propiedades de navegación
        public TipoCuenta TipoCuenta { get; set; }

        [Required]
        [Column(TypeName = "decimal")]
        public decimal Saldo { get; set; }

        [Required]
        public byte Estado { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime FechaApertura { get; set; }
    }
}