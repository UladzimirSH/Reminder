using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Enums;

namespace Domain.Entities {
    public class BankCard : EntityBase {
        
        [Required]
        public int UserId { get; set; }

        [Required]
        [ForeignKey(nameof(Bank))]        
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        [MaxLength(256)]
        public string Note { get; set; }

        public NotifyType? NotifyType { get; set; }        
    }
}
