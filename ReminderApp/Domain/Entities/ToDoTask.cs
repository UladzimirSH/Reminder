using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;

namespace Domain.Entities {
    public class ToDoTask {
        [Key, Required]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]        
        public TaskType TaskType { get; set; }

        [Required]
        public Priority Priority { get; set; }

        public DateTime DoneDate { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public DateTime DeadlineDate { get; set; }
    }
}
