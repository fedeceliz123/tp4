using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Material
    {
        private long Id;

        private string Dni;

        private string Codigo_de_area;

        private string Telefono;

        public long Id1 { get => Id; set => Id = value; }
        public string Dni1 { get => Dni; set => Dni = value; }
        public string Codigo_de_area1 { get => Codigo_de_area; set => Codigo_de_area = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
    }
}
