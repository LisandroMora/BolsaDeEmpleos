using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiVacantes.Models
{
    public class Trabajos
    {
        public int IdTrabajo { get; set; }
        [Required]
        public int? IdCategoria { get; set; }
        [Required]
        public DateTime? Fecha { get; set; }
        [Required]
        public string Ubicacion { get; set; }
        [Required]
        public string Posicion { get; set; }
        [Required]
        public string Empresa { get; set; }
        [Required]
        public int? IdTipo { get; set; }
        public string Logo { get; set; }
        public string UrlString { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ComoAplicar { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Tipo IdTipoNavigation { get; set; }
    }
}
