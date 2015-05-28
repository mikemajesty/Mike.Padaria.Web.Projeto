using System.ComponentModel.DataAnnotations;

namespace Padaria.Dominio.Entidades
{
    public class Permissao
    {
        [Key]
        public int PermissaoID { get; set; }
        public string Nome { get; set; }
    }
}
