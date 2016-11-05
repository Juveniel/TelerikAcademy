using System;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Homework
    {
        [Key]
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public string Content { get; set; }

        public virtual DateTime TimeSent { get; set; }
        
        public virtual Course Course { get; set; }        

        public virtual Student Student { get; set; }
    }
}
