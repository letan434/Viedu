using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ViEdu.Data.EF;
using ViEdu.Data.Entities;
using ViEdu.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViEdu.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ViEduDbContext _context;
        public DepartmentController( IConfiguration configuration, ViEduDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var departments = _context.Departments.AsQueryable();
            var results = await departments.Select(u => new DepartmentVm()
            {
                ID = u.ID,
                DEPT_CD = u.DEPT_CD,
                DEPT_NAME = u.DEPT_NAME
            }).ToListAsync();
            return View(results);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] DepartmentVm request)
        {
            if (!ModelState.IsValid)
                return View(request);
            var test = await _context.Departments.FindAsync(request.ID);
            if (test != null) return BadRequest();
            var department = new Department()
            {
                DEPT_CD = request.DEPT_CD,
                DEPT_NAME = request.DEPT_NAME
            };
            _context.Departments.AddRange(department);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {         
                return RedirectToAction("Index");
            }            
            return View(request);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!ModelState.IsValid)
                return View();
            var department = await _context.Departments.FindAsync(id);
            var editdepartment = new DepartmentVm()
            {
                ID = department.ID,
                DEPT_CD = department.DEPT_CD,
                DEPT_NAME = department.DEPT_NAME
            };
            return View(editdepartment);
        }
        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] DepartmentVm request)
        {
            if (!ModelState.IsValid)
                return View(request);
            var department = await _context.Departments.FindAsync(request.ID);
            if (department == null) return BadRequest();

            department.DEPT_CD = request.DEPT_CD;
            department.DEPT_NAME = request.DEPT_NAME;

            _context.Departments.Update(department);
            var result = await _context.SaveChangesAsync();
            if(result >0)
            {                
                return RedirectToAction("Index");
            }
            return View(request);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (!ModelState.IsValid)
                return View();
            var department = await _context.Departments.FindAsync(id);
            var result = new DepartmentVm()
            {
                ID = department.ID,
                DEPT_CD = department.DEPT_CD,
                DEPT_NAME = department.DEPT_NAME
            };
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var departmentDelete = await _context.Departments.FindAsync(id);

            return View(new DepartmentVm
            {
                ID = id,
                DEPT_NAME = departmentDelete.DEPT_NAME,
                DEPT_CD  = departmentDelete.DEPT_CD
            });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(DepartmentVm request)
        {
            if (!ModelState.IsValid) return View();
            var departmentDelete = await _context.Departments.FindAsync(request.ID);
            if (departmentDelete == null) return BadRequest();
            _context.Departments.Remove(departmentDelete);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {               
                return RedirectToAction("Index");
            }            
            return View(request);
        }
    }
}
