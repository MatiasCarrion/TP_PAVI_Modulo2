using System;
using System.Collections.Generic;
using System.Text;
using TP_PAVI_Modulo2.AccesoDatos;
using TP_PAVI_Modulo2.Entidades;

namespace TP_PAVI_Modulo2.LogicaNegocio
{
    public class CategoriaService
    {
        private CategoriaDao oCategoriaDao;
        public CategoriaService()
        {
            oCategoriaDao = new CategoriaDao();
        }
        public IList<Categoria> ObtenerTodos()
        {
            return oCategoriaDao.GetAll();
        }
    }
}
