using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Credits Earned")]
        public int? CreditsEarned { get; set; }
        [Range(0.7, 4.0, ErrorMessage = "GPA cannot be below 0.7 or exceed 4.0")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]

        public Double? GPA { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}