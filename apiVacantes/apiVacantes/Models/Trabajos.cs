using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiVacantes.Models
{
    public class Trabajos
    {
        public int IdTrabajo { get; set; }
        public int? IdCategoria { get; set; }
        public DateTime? Fecha { get; set; }
        public string Ubicacion { get; set; }
        public string Posicion { get; set; }
        public string Empresa { get; set; }
        public int? IdTipo { get; set; }
        public byte[] Logo { get; set; }
        public string UrlString { get; set; }
        public string Descripcion { get; set; }
        public string Email { get; set; }
        public string ComoAplicar { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Tipo IdTipoNavigation { get; set; }
    }
}
