using System;
using System.Collections.Generic;
<<<<<<< Updated upstream
=======
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
>>>>>>> Stashed changes
using System.Linq;
using System.Web;

namespace Thiago.TesteASPNETMVC.Web.Models
{
    public class Pessoa
    {
<<<<<<< Updated upstream
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
=======
        [Required(ErrorMessage = "O nome é obrigatòrio")]
        [DisplayName("Nome da pessoa: ")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A idade é obrigatòrio")]
        [DisplayName("Idade da pessoa: ")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "O endereço é obrigatòrio")]
        [DisplayName("Endereço da pessoa: ")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O Email é obrigatòrio")]
        [DisplayName("Email da pessoa: ")]
        public string Email { get; set; }
>>>>>>> Stashed changes
    }
}