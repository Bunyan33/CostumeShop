using CostumeShop.Data;
using CostumeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CostumeShop.Repo
{
    public class Repo : IRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public Repo(ApplicationDbContext dbContext)
        {
            _dbContext=dbContext;
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public Brand Delete(Guid id)
        {
            Brand brand = _dbContext.Brand.FirstOrDefault(x => x.Id == id);
            return brand;
        }
    }
}
