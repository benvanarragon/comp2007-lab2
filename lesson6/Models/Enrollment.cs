//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lesson6.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Nullable<int> Grade { get; set; }

        public virtual Course Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
