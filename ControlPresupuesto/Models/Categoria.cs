using System.ComponentModel.DataAnnotations;

namespace ControlPresupuesto.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(maximumLength: 50, ErrorMessage = "No puede tener más de {1} caracteres")]
        public string Nombre { get; set; }
        public TipoOperacion TipoOperacionId { get; set; }
        public int UsuarioId { get; set; }

    }
}
