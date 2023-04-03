using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BIRC.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O Campo{0} é obrigatório ")]
        [StringLength(7, ErrorMessage = "Use seu ID")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo{0} é obrigatório ")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "O Campo{0} é obrigatório ")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O Campo{0} é obrigatório ")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme sua senha")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string SenhaConfirmada { get; set; }

    }
}
