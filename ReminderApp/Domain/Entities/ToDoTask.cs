using Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities {
    public class ToDoTask {

        [Key, Required]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Type { get; set; }
        public TaskType TaskType { get; set; }

        [Required]
        public Priority Priority { get; set; }

        public DateTime? DoneDate { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public DateTime? DeadlineDate { get; set; }
    }
}
