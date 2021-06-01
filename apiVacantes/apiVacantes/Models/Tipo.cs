using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiVacantes.Models
{
    public partial class Tipo
    {
        public Tipo()
        {
            Trabajos = new HashSet<Trabajos>();
        }

        public int IdTipo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Trabajos> Trabajos { get; set; }
    }
}
