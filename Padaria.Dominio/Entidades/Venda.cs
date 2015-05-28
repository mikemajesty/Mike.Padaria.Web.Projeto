using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
    public class Venda
    {
        [HiddenInput(DisplayValue = false)]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "VendaID:")]
        [Key]
        public int VendaID { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Campo {0} contem valores inválidos")]
        [DisplayName(displayName: "Total Venda:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        [RegularExpression(@"\d+(\,\d{1.2})?", ErrorMessage = "Campo {0} contém valores Inválido.")]
        public decimal VendaTotal { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Campo {0} contem valores inválidos")]
        [DisplayName(displayName: "Total Lucro:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        [RegularExpression(@"\d+(\,\d{1.2})?", ErrorMessage = "Campo {0} contém valores Inválido.")]

        public decimal LucroTotal { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Data { get; set; }
        [HiddenInput(DisplayValue = false)]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [DisplayName(displayName: "UsuarioID:")]
        public int UsuarioID { get; set; }
        [HiddenInput(DisplayValue = false)]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [DisplayName(displayName: "TipoPagamentoID:")]
        public int TipoPagamentoID { get; set; }
    }
}
