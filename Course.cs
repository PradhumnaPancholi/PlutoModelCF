namespace PlutoCFEDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        [Key]
        public int CourseID { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public int? Author_AuthorID { get; set; }

        public int? Tag_TagID { get; set; }

        public virtual Author Author { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
