using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
   public class VendaComComandaAtiva
   {
       [HiddenInput(DisplayValue = false)]
       [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
       [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
       [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
       [DisplayName(displayName: "VendaComComandaAtivaID:")]
       [Key]
       public int VendaComComandaAtivaID { get; set; }
       [HiddenInput(DisplayValue = false)]
       [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
       [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
       [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
       [DisplayName(displayName: "ProdutoID:")]
       public int ProdutoID { get; set; }
       [HiddenInput(DisplayValue = false)]
       [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
       [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
       [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
       [DisplayName(displayName: "ComandaID:")]
       public int ComandaID { get; set; }
       [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
       [DisplayName(displayName: "Quantidade:")]
       [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
       [Range(minimum: int.MinValue, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de -2.147.483.648 e 2.147.483.647.")]
       public int Quantidade { get; set; }
       [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
       [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Campo {0} contem valores invalidos")]
       [DisplayName(displayName: "Preco Total:")]
       [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
       [RegularExpression(@"\d+(\,\d{1.2})?", ErrorMessage = "Campo {0} contém valores Inválido.")]
       public decimal PrecoTotal { get; set; }

    }
}
