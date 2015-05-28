using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Padaria.Dominio.Entidades
{
    public class Usuarios
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Campo {0} só permite valores acima de 1 e 2.147.483.647.")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Campo {0} só permite numeros.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [DisplayName(displayName: "UsuarioID:")]
        public int UsuarioID { get; set; }
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Campo {0} só permite de 5 a 20 letras.")]
        [DisplayName(displayName: "Nome:")]
        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Nome { get; set; }
        [DisplayName(displayName: "Senha:")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Campo {0} só permite de 5 a 20 letras.")]
        //[Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Senha { get; set; }
        [DisplayName(displayName: "Confirmar Senha:")]
        [System.ComponentModel.DataAnnotations.CompareAttribute("Senha", ErrorMessage = "Senhas não coincide.")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Campo {0} só permite de 5 a 20 letras.")]
       // [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [NotMapped]
        public string Confimar { get; set; }
        [StringLength(maximumLength: 15, MinimumLength = 0, ErrorMessage = "Campo {0} só permite de 0 a 15 letras.")]
        public int PermissaoID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string UltimoAcesso { get; set; }

        public virtual Permissao Permissao { get; set; }
    }
}
