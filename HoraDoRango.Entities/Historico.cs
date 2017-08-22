using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoraDoRango.Entities
{

    [Table("Historico")]
    public partial class Historico
    {
        [Key]
        [Column(Order = 0)]
        public int Hist_ID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Hist_Data { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Hist_Ciclo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Hist_Tipo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FK_Rest_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FK_Pess_RA { get; set; }
    }
}
