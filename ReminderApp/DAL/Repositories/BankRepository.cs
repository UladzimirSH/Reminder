using DAL.Mappers;
using DAL.Repositories.Declarations;
using Domain.Entities;
using Models;

namespace DAL.Repositories {
    public class BankRepository : Repository<BankModel, Bank>, IBankRepository {
        public BankRepository(IMapper<BankModel, Bank> mapper) : base(mapper)
        {
        }
    }
}
