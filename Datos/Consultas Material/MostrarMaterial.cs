using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.Consultas_Material
{
    public class MostrarMaterial:ConexionDB
    {
        public List<Material> Listar()
        {
            string Consulta = "select * from Telefonos";
            SqlDataAdapter da = new SqlDataAdapter(Consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            var listaTelefonos = new List<Material>();
            Material Materia = new Material();

            foreach(DataRow col in dt.Rows)
            {
                
                            
               

                listaTelefonos.Add(new Material {Id1=long.Parse(col["Id"].ToString()),
                    Codigo_de_area1=col["Codigo_de_area"].ToString(),
                    Dni1=col["DNI_CUIT"].ToString(),
                    Telefono1=col["Telefono"].ToString()});


            }

            return listaTelefonos;

        }

    }
}
