using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_CorrioneroJuan
{
    class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Codigo { get; set; }
        public string Imagen { get; set; }
        public float Precio { get; set; }
        Marca marca;
        Categoria Categoria;

    }
}
