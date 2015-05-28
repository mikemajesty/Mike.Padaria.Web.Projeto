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
        [DisplayName(displayName: "UsuarioID:")]
        public int UsuarioID { get; set; }
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Campo {0} só permite de 5 a 20 letras.")]
        [DisplayName(displayName: "Nome:")]       
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Nome { get; set; }
        [DisplayName(displayName: "Senha:")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Campo {0} só permite de 5 a 20 letras.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        public string Senha { get; set; }
        [DisplayName(displayName: "Confirmar Senha:")]
        [System.ComponentModel.DataAnnotations.CompareAttribute("Senha", ErrorMessage = "Senhas não coincide.")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Campo {0} só permite de 5 a 20 letras.")]
        [Required(ErrorMessage = "Campo {0} é obrigatorio.")]
        [NotMapped]
        public string Confimar { get; set; }
      
        public int PermissaoID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string UltimoAcesso { get; set; }

        public virtual Permissao Permissao { get; set; }
    }
}
