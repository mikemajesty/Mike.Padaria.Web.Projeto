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
