using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace TesteApi.Models
{
    [Table("Cliente")]
    public class Cliente
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O nome deve ter entre 5 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "O nome deve ter entre 10 e 11 caracteres")]
        public string Telefone { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]        
        public string Email { get; set; }
        public Mensagem Mensagem { get; set; }
    }
}
