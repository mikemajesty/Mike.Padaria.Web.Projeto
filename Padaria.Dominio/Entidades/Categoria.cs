using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
    public class Categoria
    {
        [HiddenInput(DisplayValue = false)]
        [DisplayName(displayName: "CategoriaID:")]
        [Key]
        public int CategoriaID { get; set; }
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Campo {0} só permite letras.")]
        [StringLength(maximumLength: 30, MinimumLength = 3, ErrorMessage = "Campo {0} só permite de 3 a 30 letras.")]
        [DisplayName(displayName: "Nome:")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Nome { get; set; }
    }
}
