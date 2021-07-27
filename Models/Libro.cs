using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El titulo es obligatorio")]
        [StringLength(50, ErrorMessage ="El {0} debe ser al menos {2} y maximo {1} caracteres",MinimumLength =3)]
        [Display(Name ="Titulo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="La descripcion es obligatorio")]
        [StringLength(50, ErrorMessage ="El {0} debe ser al menos {2} y maximo {1} caracteres",MinimumLength =3)]
        [Display(Name ="Descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="La fecha es obligatorio")]
        [DataType(DataType.Date)]
        [Display(Name ="Fecha")]
        public DateTime FechaLanzamiento { get; set; }
        [Required(ErrorMessage ="El autor es obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage ="El precio es obligatorio")]
        public int Precio { get; set; }
    }
}