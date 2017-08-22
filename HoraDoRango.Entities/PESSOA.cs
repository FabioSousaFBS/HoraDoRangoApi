using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoraDoRango.Entities
{
    [Table("Pessoa")]
    public class PESSOA
    {
        [Key]
        public int Pess_RA { get; set; }

        public string Pess_nome { get; set; }

        public byte Pess_Admin { get; set; }

    }


}
