using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModel
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="Preencha o SobreNome")]
        [MaxLength(150, ErrorMessage = "Texto excedeu {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Nome")]
        [MaxLength(100, ErrorMessage = "Texto excedeu {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
    
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o Nome")]
        [MaxLength(150, ErrorMessage = "Texto excedeu {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um Email Valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}