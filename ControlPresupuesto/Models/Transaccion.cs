using System.ComponentModel.DataAnnotations;

namespace ControlPresupuesto.Models
{
    public class Transaccion
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        [Display(Name = "Fecha de Transacción")]
        [DataType(DataType.Date)]
        public DateTime FechaTransaccion { get; set; } = DateTime.Today;
        [StringLength(1000, ErrorMessage = "La nota no puede exceder los {1} caracteres")]
        public string Nota { get; set; }
        [Range(1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una categoría")]
        public int CategoriaId { get; set; }
        public int UsuarioId { get; set; }
        [Range(1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una cuenta")]
        public int CuentaId { get; set; }   

    }
}
