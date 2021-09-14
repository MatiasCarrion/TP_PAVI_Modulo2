using System;
using System.Collections.Generic;
using System.Text;

namespace TP_PAVI_Modulo2.Entidades
{
    public class Curso
    {
        public int idCurso { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaVigencia { get; set; }
        public int idCategoria { get; set; }
        public bool borrado { get; set; }
    }
}
