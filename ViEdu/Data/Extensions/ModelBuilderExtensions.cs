using System;
using Microsoft.EntityFrameworkCore;
using ViEdu.Data.Entities;

namespace ViEdu.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
               new Department() { ID = 1, DEPT_CD = "TEACHER", DEPT_NAME = "Chuyên môn giảng dạy"},
               new Department() { ID = 2, DEPT_CD = "SALE", DEPT_NAME = "Kinh doanh" },
               new Department() { ID = 5, DEPT_CD = "MK", DEPT_NAME = "Marketing & Support" },
               new Department() { ID = 3, DEPT_CD = "OP", DEPT_NAME = "Operation" },
               new Department() { ID = 4, DEPT_CD = "TRA", DEPT_NAME = "Training" }
               );
            modelBuilder.Entity<Position>().HasData(
                new Position()
                {
                    ID = 2172, POSITION_CD = "0015", NAME = "ADMIN", DESC = "Nhân viên văn phòng", JOB_REQUIRED = null, DEPT_CD = "OP",
                    RANK = 8, CREATED_DATE = DateTime.Parse("2020-08-26T00:00:00.000"), CREATED_BY = "0000001"
                },
                new Position()
                {
                    ID = 2173, POSITION_CD = "0003", NAME = "TEACHER-PARTTIME", DESC = "Giáo viên bán thời gian", JOB_REQUIRED = null, DEPT_CD = "TEACHER",
                    RANK = 8, CREATED_DATE = DateTime.Parse("2020-08-26T00:00:00.000"), CREATED_BY = "0000001"
                },
                new Position()
                {
                    ID = 2174, POSITION_CD = "0004", NAME = "TEACHER-FULLTIME", DESC = "Giáo viên Fulltime", JOB_REQUIRED = null, DEPT_CD = "TEACHER",
                    RANK = 8, CREATED_DATE = DateTime.Parse("2020-08-26T00:00:00.000"), CREATED_BY = "0000001"
                }
                );
        }
        }
}
