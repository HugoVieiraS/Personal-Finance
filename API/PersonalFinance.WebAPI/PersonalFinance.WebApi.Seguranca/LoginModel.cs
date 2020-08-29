using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.WebApi.Seguranca
{
    public class LoginModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Usuário")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
