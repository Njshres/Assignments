﻿using System.ComponentModel.DataAnnotations;

namespace Student_Management.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateOnly EnrollmentDate { get; set; }
       
    }
}
