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
   public class Data
    {
        [HiddenInput(DisplayValue = false)]
       [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
       [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
       [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
       [DisplayName(displayName: "DataID:")]
        [Key]
        public int DataID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "Data:")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Campo {0} só permite 10 caracteres.")]
        public string Datas { get; set; }
    }
}
