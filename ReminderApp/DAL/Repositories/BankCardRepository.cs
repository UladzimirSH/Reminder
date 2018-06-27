using Domain.Entities;
using System.Data.Entity;
using DAL.Repositories.Declarations;

namespace DAL.Repositories {
    public class BankCardRepository : Repository<BankCard>, IBankCardRepository {
        public BankCardRepository(DbContext context) : base(context) {
        }
    }
}
