using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDs.Models
{
    [Table("Artigos")]
    public class Artigo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Preço")]
        public int Preco { get; set; }

        [Display(Name = "Qta em Stock")]
        public Int16 QtaStock { get; set; }

    }
}
