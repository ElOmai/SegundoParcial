using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
    public class Metas
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Cuota { get; set; }
    }
}
