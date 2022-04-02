using Truecapp2.Entities;

namespace Truecapp2.Interfaz
{
    public interface IProductocs
    {
        public List<Producto> GetUserDetails();
        public void AddUser(Producto producto);
        public void UpdateUserDetails(Producto producto);
        public Producto GetUserData(int id);
        public void DeleteUser(int id);
    }
}
