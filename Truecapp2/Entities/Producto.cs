using System;
using System.Collections.Generic;

namespace Truecapp2.Entities
{
    public partial class Producto
    {
        public string Estado { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Codigo { get; set; }
    }
}
