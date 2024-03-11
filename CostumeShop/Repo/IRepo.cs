using CostumeShop.Models;

namespace CostumeShop.Repo
{
    public interface IRepo
    {
        public void Create();
        public Brand Delete(Guid id);
    }
}
