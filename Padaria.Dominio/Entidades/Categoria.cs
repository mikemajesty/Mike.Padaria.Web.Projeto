using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
    public class Categoria
    {
        [HiddenInput(DisplayValue = false)]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "CategoriaID:")]
        [Key]
        public int CategoriaID { get; set; }
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Campo {0} só permite letras.")]
        [StringLength(maximumLength: 30, MinimumLength = 3, ErrorMessage = "Campo {0} só permite de 3 a 30 letras.")]
        [DisplayName(displayName: "Nome:")]
        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Nome { get; set; }
    }
}
