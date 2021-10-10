using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TP_PAVI_Modulo2.Entidades;

namespace TP_PAVI_Modulo2.AccesoDatos
{
    public class CategoriaDao
    {
        public IList<Categoria> GetAll()
        {
            List<Categoria> listadoCategorias = new List<Categoria>();

            var strSql = "SELECT id_categoria, nombre from Categorias";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCategorias.Add(MappingBug(row));
            }

            return listadoCategorias;
        }
        private Categoria MappingBug(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                idCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                nombreCateg = row["nombre"].ToString()
            };

            return oCategoria;
        }
    }
}
