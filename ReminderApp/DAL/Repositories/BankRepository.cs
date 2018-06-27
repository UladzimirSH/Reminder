using Domain.Entities;
using System.Data.Entity;
using DAL.Repositories.Declarations;

namespace DAL.Repositories {
    public class BankRepository : Repository<Bank>, IBankRepository {
        public BankRepository(DbContext context) : base(context) {
        }
    }
}
