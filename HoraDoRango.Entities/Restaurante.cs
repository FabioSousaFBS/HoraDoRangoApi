using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoraDoRango.Entities
{
    [Table("Restaurante")]
    public partial class Restaurante
    {
        [Key]
        [Column(Order = 0)]
        public int Rest_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Rest_Nome { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Rest_End { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Rest_Ativo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FK_Pess_RA { get; set; }
    }
}
