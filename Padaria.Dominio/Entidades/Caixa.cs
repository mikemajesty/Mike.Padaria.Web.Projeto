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
    public class Caixa
    {
        [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Campo {0} contem valores invalidos")]
        [DisplayName(displayName: "Valor:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        [RegularExpression(@"\d+(\,\d{1.2})?", ErrorMessage = "Campo {0} contém valores Inválido.")]

        public decimal Valor { get; set; }
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [DisplayName(displayName: "UsuarioID:")]
        [Key]
        [HiddenInput(DisplayValue=false)]
        public int UsuarioID { get; set; }
    }
}
