using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
    public class Cliente
    {
        [HiddenInput(DisplayValue = false)]     
        [DisplayName(displayName: "ClienteID:")]
        [Key]
        public int ClienteID { get; set; }
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Campo {0} só permite letras.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Campo {0} só permite de 3 a 50 letras.")]
        [DisplayName(displayName: "Nome:")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Nome { get; set; }
        [StringLength(maximumLength: 15, MinimumLength = 11, ErrorMessage = "Campo {0} só permite de 11 a 14 caracteres.")]
        [DisplayName(displayName: "CPF:")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Campo {0} contem valores inválido.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]      
        public string Cpf { get; set; }
        [Range(minimum: 11, maximum: 11, ErrorMessage = "Campo {0} só permite [00000000000]")]
        [DisplayName(displayName: "Celular:")]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{5})[-. ]?([0-9]{4})$", ErrorMessage = "Campo {0} contem valores inválido.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]      
        public string Celular { get; set; }
    }
}
