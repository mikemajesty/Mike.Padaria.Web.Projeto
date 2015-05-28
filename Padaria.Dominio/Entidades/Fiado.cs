using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
    public class Fiado
    {
       
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "FiadoID:")]
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int FiadoID { get; set; }
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "ClienteID:")]
        [HiddenInput(DisplayValue = false)]
        public int ClienteID { get; set; }
        [Range(minimum: 0, maximum: double.MaxValue, ErrorMessage = "Campo {0} contem vaores invalidos")]
        [DisplayName(displayName: "Valor:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C}")]
        [RegularExpression(@"\d+(\,\d{1.2})?", ErrorMessage = "Campo {0} contém valores Inválido.")]
        public decimal Valor { get; set; }
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "FuncionarioID:")]
        [HiddenInput(DisplayValue = false)]
        public int FuncionarioID { get; set; }

        public virtual Usuarios Usuario { get; set; }
    }
}
