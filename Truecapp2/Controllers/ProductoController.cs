using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truecapp2.Entities;
using Truecapp2.Interfaz;

namespace Truecapp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductocs _IPro;
        public ProductoController(IProductocs iProducto)
        {
            _IPro = iProducto;
        }
        [HttpGet]
        public async Task<List<Producto>> Get()
        {
            return await Task.FromResult(_IPro.GetUserDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Producto producto = _IPro.GetUserData(id);
            if (producto != null)
            {
                return Ok(producto);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Producto producto)
        {
            _IPro.AddUser(producto);
        }
        [HttpPut]
        public void Put(Producto producto)
        {
            _IPro.UpdateUserDetails(producto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IPro.DeleteUser(id);
            return Ok();
        }
    }
}
