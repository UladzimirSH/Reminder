using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class BankCard
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BankId { get; set; }
        public int Number { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Note { get; set; }
        public int NotifyType { get; set; }

        public Bank Bank { get; set; }
    }
}
