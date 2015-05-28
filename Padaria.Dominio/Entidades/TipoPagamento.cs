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
    public class TipoPagamento
    {
        [HiddenInput(DisplayValue = false)]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "TipoPagamentoID:")]
        [Key]
        public int TipoPagamentoID { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "Tipo:")]
        [StringLength(maximumLength: 15, MinimumLength = 3, ErrorMessage = "Campo {0} só permite de 3 a 15 caracteres.")]
        public string Tipo { get; set; }
    }
}
