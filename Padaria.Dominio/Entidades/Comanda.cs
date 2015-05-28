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
    public class Comanda
    {
       [HiddenInput(DisplayValue = false)]
       [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
       [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
       [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
       [DisplayName(displayName: "ComandaID:")]
        [Key]
        public int ComandaID { get; set; }
         [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
         [DisplayName(displayName: "Codigo:")]
         [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "Campo {0} só permite de 2 a 30 letras.")]
         [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Campo {0} só permite numeros e letras.")]
        public string Codigo { get; set; }  
    }
}
