using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{

    // Data Anotations
    public class Cliente
    {
        // propiedades -> prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(80)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(80)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(25)]
        public string Documento { get; set; }

        [StringLength(120)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(30)]
        public string Telefono { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime FechaRegistro { get; set; }
    }
}

// Data Anotations
public class Cliente
{
    // propiedades -> prop
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int ClienteId { get; set; }

    [Required]
    [StringLength(80)]
    public string Nombres { get; set; }

    [Required]
    [StringLength(80)]
    public string Apellidos { get; set; }

    [Required]
    [StringLength(25)]
    public string Documento { get; set; }

    [StringLength(120)]
    [EmailAddress]
    public string Email { get; set; }

    [StringLength(30)]
    public string Telefono { get; set; }

    [Required]
    [Column(TypeName = "datetime2")]
    public DateTime FechaRegistro { get; set; }
}
