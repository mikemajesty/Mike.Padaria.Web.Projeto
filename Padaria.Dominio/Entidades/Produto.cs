using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
    public class Produto
    {
     
        
        [DisplayName(displayName: "ProdutoID:")]
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int ProdutoID { get; set; }
        [DisplayName(displayName: "Codigo:")]
        [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "Campo {0} só permite de 2 a 30 letras.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Campo {0} só permite numeros e letras.")]
        public string Codigo { get; set; }
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Campo {0} só permite letras.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Campo {0} só permite de 3 a 50 letras.")]
        [DisplayName(displayName: "Nome:")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Nome { get; set; }
        //[RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        //[Required(ErrorMessage = "Campo Categoria é obrigatorio.")]
        //[DisplayName(displayName: "Categoria:")]
        //[HiddenInput(DisplayValue = false)]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Campo {0} contem vaores invalidos")]
        [DisplayName(displayName: "Preco de Compra:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        [RegularExpression(@"\d+(\,\d{1.2})?", ErrorMessage = "Campo {0} contém valores Inválido.")]
        public decimal PrecoCompra { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Campo {0} contem vaores invalidos")]
        [DisplayName(displayName: "Preco de Venda:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        [RegularExpression(@"\d+(\,\d{1.2})?", ErrorMessage = "Campo {0} contém valores Inválido.")]
        public decimal PrecoVenda { get; set; }
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        //[DisplayName(displayName: "Descrição:")]
        [StringLength(maximumLength: 70, MinimumLength = 0, ErrorMessage = "Campo {0} só permite de 0 a 70 letras.")]       
        public string Descricao { get; set; }
        //[Range(minimum: 0, maximum: 100, ErrorMessage = "Campo {0} só permite de 0 a 100")]
        //[RegularExpression(@"^[0-9]+$", ErrorMessage = "Campo {0} só permite numeros.")]
        //[DisplayName(displayName: "Quantidade:")]
        //[Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        ///* [Required(ErrorMessage = "Campo {0} é obrigatorio.")]*/
        public int Quantidade { get; set; }
        //[Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public int QuantidadeMaxima { get; set; }
        //[Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public int QuantidadeMinima { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
