using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Models
{
    [Table("Vuelo")]
    public class Vuelo
    {
        // Id- Fecha-Destino-Origen-Matrícula
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        //[RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$")]
        public DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Destino { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Origen { get; set; }

        [Range(100, 10000)]
        public int Matricula { get; set; }

    }
}