using DAL.Mappers;
using DAL.Repositories.Declarations;
using Domain.Entities;
using Models;

namespace DAL.Repositories {
    public class BankCardRepository : Repository<BankCardModel, BankCard>, IBankCardRepository {
        public BankCardRepository(IMapper<BankCardModel, BankCard> mapper) : base(mapper) {
        }
    }
}
