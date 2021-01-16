using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViEdu.Data.Entities
{
    [Table("Positions")]
    public class Position
    {
        public int ID { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string POSITION_CD { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string NAME { get; set; }
        public string DESC { get; set; }
        public string JOB_REQUIRED { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string DEPT_CD { get; set; }
        public int RANK { get; set; }
        public string BENEFIT { get; set; }
        public string JOB_TYPE_DESC { get; set; }
        public DateTime CREATED_DATE { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string CREATED_BY { get; set; }
        public DateTime MODIFIED_DATE { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string MODIFIED_BY { get; set; }
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string NOTE { get; set; }
        
    }
}
