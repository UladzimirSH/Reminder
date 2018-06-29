using System;
using Common.Enums;

namespace Models {
    public class BankCardModel : ModelBase {

        public int UserId { get; set; }

        public int BankId { get; set; }
        public BankModel Bank { get; set; }

        public int Number { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Note { get; set; }

        public NotifyType NotifyType { get; set; }
    }
}
