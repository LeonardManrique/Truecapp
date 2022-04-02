using Microsoft.EntityFrameworkCore;
using Truecapp2.Entities;
using Truecapp2.Interfaz;


namespace Truecapp2.Servicios
{
    public class ProductoManager : IProductocs
    {
        readonly Truecapp _dbContext = new();
        public ProductoManager(Truecapp dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all user details
        public List<Producto> GetUserDetails()
        {
            try
            {
                return _dbContext.Productos.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new user record
        public void AddUser(Producto user)
        {
            try
            {
                _dbContext.Productos.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar user
        public void UpdateUserDetails(Producto producto)
        {
            try
            {
                _dbContext.Entry(producto).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular user
        public Producto GetUserData(int id)
        {
            try
            {
                Producto? producto = _dbContext.Productos.Find(id);
                if (producto != null)
                {
                    return producto;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular user
        public void DeleteUser(int id)
        {
            try
            {
                Producto? producto = _dbContext.Productos.Find(id);
                if (producto != null)
                {
                    _dbContext.Productos.Remove(producto);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        List<Producto> IProductocs.GetUserDetails()
        {
            throw new NotImplementedException();
        }

       /* public void AddUser(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserDetails(Producto producto)
        {
            throw new NotImplementedException();
        }*/

        Producto IProductocs.GetUserData(int id)
        {
            throw new NotImplementedException();
        }
    }
}
