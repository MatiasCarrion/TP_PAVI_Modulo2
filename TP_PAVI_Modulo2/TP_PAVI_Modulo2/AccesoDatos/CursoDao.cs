using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TP_PAVI_Modulo2.Entidades;

namespace TP_PAVI_Modulo2.AccesoDatos
{
    public class CursoDao
    {
        public IList<Curso> GetAllCurso()
        {
            List<Curso> listaCursos = new List<Curso>();
            String strSql = string.Concat(" SELECT c.id_curso, ",
                                          "        c.nombre, ",
                                          "        c.descripcion, ",
                                          "        c.fecha_vigencia, ",
                                          "        t.id_categoria, ",
                                          "        t.nombre categoria ",
                                          "   FROM Cursos c",
                                          "  INNER JOIN Categorias t ON c.id_categoria = t.id_categoria " +
                                          "  WHERE c.borrado = 0 ");
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaCursos.Add(ObjectMappingCurso(row));
            }

            return listaCursos;
        }
        private Curso ObjectMappingCurso(DataRow row)
        {
            Curso oCurso = new Curso
            {
                idCurso = Convert.ToInt32(row["id_curso"].ToString()),
                nombre = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),
                fechaVigencia = Convert.ToDateTime(row["fecha_vigencia"].ToString()),
                //borrado = Convert.ToBoolean(row["borrado"].ToString()),
                categoria = new Categoria()
                {
                    idCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                    nombreCateg  = row["categoria"].ToString(),
                }
            };

            return oCurso;
        }
        public IList<Curso> GetCursoByFilters(Dictionary<string, object> parametros)
        {
            List<Curso> listadoCursos = new List<Curso>();

            var strSql = String.Concat("SELECT c.id_curso, ",
                                          "        c.nombre, ",
                                          "        c.descripcion, ",
                                          "        c.fecha_vigencia, ",
                                          "        t.id_categoria, ",
                                          "        t.nombre categoria ",
                                          "   FROM Cursos c",
                                          "  INNER JOIN Categorias t ON c.id_categoria = t.id_categoria ");
                                          //"  WHERE c.borrado = 0 ");

            if (parametros.ContainsKey("id_categoria"))
                strSql += "AND (t.id_categoria=@id_categoria) ";
                strSql += "WHERE c.nombre LIKE @Search OR c.descripcion LIKE @Search ";
            
            //strSql += " ORDER BY bug.fecha_alta DESC";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoCursos.Add(ObjectMappingCurso(row));
            }
            return listadoCursos;

        }
    }
}
