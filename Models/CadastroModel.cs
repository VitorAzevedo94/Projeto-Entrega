using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq

namespace Controle.Models
{
    public class CadastroModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite o Perfil")]
        public string Perfil { get; set; }
    }
}
