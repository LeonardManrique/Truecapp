using Truecapp2.Entities;

namespace Truecapp2.Data
{
    public class TruecappDALcs : IDisposable
    {
        public void Dispose()
        {

        }
        public void GuardarProducto(Producto InformacionProducto)
        {
            using Truecapp ice = new Truecapp() ;
            {
                ice.Productos.Add(InformacionProducto);
                ice.SaveChanges();
            }
           
        }

    }
}
