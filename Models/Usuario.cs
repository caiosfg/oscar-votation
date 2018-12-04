using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="O campo Nome é obrigatório !")]
        public string Nome { get; set; }
        public string Observacoes { get; set; }
        [Required(ErrorMessage = "O campo Setor é obrigatório !")]
        public string Setor { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um Email válido !")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Login é obrigatório !")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este Login já existe!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório !")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não coincidem !")]
        public string ConfirmaSenha { get; set; }

    }
}