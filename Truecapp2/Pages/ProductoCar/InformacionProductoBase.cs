using Microsoft.AspNetCore.Components;
using Truecapp2.Data;
using Truecapp2.Entities;
using Truecapp2.Pages.ProductoCar;

namespace InformacionProductoBase
{
    public class InformacionProductoBase : ComponentBase
    {
        public Producto Producto
        {
            get;
            set;
        }
        protected override Task OnParametersSetAsync()
        {
            Producto = new Producto();


            return base.OnParametersSetAsync();
        }

        public void GuardarProducto()
        {
            using (TruecappDALcs dal = new TruecappDALcs())
            {
                dal.GuardarProducto(Producto);
            }
        }
    }
}
