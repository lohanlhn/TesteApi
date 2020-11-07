using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteApi.Models
{
    [Table("Mensagem")]
    public class Mensagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Texto { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }
}
