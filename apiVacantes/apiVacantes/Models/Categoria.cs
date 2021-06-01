using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiVacantes.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            this.Trabajos = new HashSet<Trabajos>();
        }

        [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Trabajos> Trabajos { get; set; }
    }
}
