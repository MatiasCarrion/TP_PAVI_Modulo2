using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TP_PAVI_Modulo2.Entidades;

namespace TP_PAVI_Modulo2.AccesoDatos
{
    public class CursoDao
    {
        public IList<Curso> GetAllUser()
        {
            List<Curso> listaCursos = new List<Curso>();
            String strSql = string.Concat(" SELECT id_curso, ",
                                          "        nombre, ",
                                          "        descripcion, ",
                                          "        t.id_categoria, ",
                                          "        t.nombre categ ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Categorias t ON u.id_categoria= p.id_categoria " +
                                          "  WHERE u.borrado = 0 ");
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaCursos.Add(ObjectMappingUser(row));
            }

            return (IList<Curso>)listaCursos;
        }
        private Curso ObjectMappingUser(DataRow row)
        {
            Curso oCurso = new Curso
            {
                idCurso = Convert.ToInt32(row["id_curso"].ToString()),
                nombre = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),
                fechaVigencia = Convert.ToDateTime(row["id_categoria"].ToString()),
                categoria = new Categoria()
                {
                    idCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                    nombre = row["categoria"].ToString(),
                }
            };

            return oCurso;
        }
    }
}
