using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
   public class NegocioMatrial
    {
        Datos.Consultas_Material.MostrarMaterial MM = new Datos.Consultas_Material.MostrarMaterial();


        public List<Material> Lista()
        {
            return MM.Listar();
        }

            
    }
}
