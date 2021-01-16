using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViEdu.Data.Entities
{
    [Table("Departments")]
    public class Department
    {
        public int ID { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string DEPT_CD { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string DEPT_NAME { get; set; }
    }
}
