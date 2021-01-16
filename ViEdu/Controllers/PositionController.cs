using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViEdu.Data.EF;
using ViEdu.Data.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViEdu.Controllers
{
    public class PositionController : Controller
    {
        private readonly ViEduDbContext _context;
        public PositionController(ViEduDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var positions = await _context.Positions.ToListAsync();
            return View(positions);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] Position request)
        {
            if (!ModelState.IsValid)
                return View(request);
            var positionResult = new Position()
            {
                ID = request.ID,
                DESC = request.DESC,
                DEPT_CD = request.DEPT_CD,
                CREATED_BY = request.CREATED_BY,
                CREATED_DATE = DateTime.Now,
                JOB_REQUIRED = request.JOB_REQUIRED,
                JOB_TYPE_DESC = request.JOB_TYPE_DESC,
                MODIFIED_BY = request.MODIFIED_BY,
                MODIFIED_DATE = DateTime.Now,
                POSITION_CD = request.POSITION_CD,
                BENEFIT = request.BENEFIT,
                NAME = request.NAME,
                NOTE = request.NOTE,
                RANK = request.RANK
            };
            _context.Positions.AddRange(positionResult);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(request);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var positionDelete = await _context.Positions.FindAsync(id);
            return View(new Position
            {
                ID = id,
                POSITION_CD = positionDelete.POSITION_CD,
                NAME = positionDelete.NAME
            });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Position request)
        {
            if (!ModelState.IsValid) return View();
            var positionDelete = await _context.Positions.FindAsync(request.ID);
            if(positionDelete == null) { return BadRequest(); }
            _context.Positions.Remove(positionDelete);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
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
            var position = await _context.Positions.FindAsync(id);
            var result = new Position()
            {
                ID = position.ID,
                POSITION_CD = position.POSITION_CD,
                DEPT_CD = position.DEPT_CD,
                JOB_TYPE_DESC = position.JOB_TYPE_DESC,
                DESC = position.DESC,
                CREATED_DATE = position.CREATED_DATE,
                JOB_REQUIRED = position.JOB_REQUIRED,
                CREATED_BY = position.CREATED_BY,
                MODIFIED_BY = position.MODIFIED_BY,
                MODIFIED_DATE = position.MODIFIED_DATE,
                BENEFIT = position.BENEFIT,
                NAME = position.NAME,
                NOTE = position.NOTE,
                RANK = position.RANK
            };
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var position = await _context.Positions.FindAsync(id);
            return View(new Position
            {
                ID = position.ID,
                POSITION_CD = position.POSITION_CD,
                DEPT_CD = position.DEPT_CD,
                JOB_TYPE_DESC = position.JOB_TYPE_DESC,
                DESC = position.DESC,
                CREATED_DATE = position.CREATED_DATE,
                JOB_REQUIRED = position.JOB_REQUIRED,
                CREATED_BY = position.CREATED_BY,
                MODIFIED_BY = position.MODIFIED_BY,
                MODIFIED_DATE = position.MODIFIED_DATE,
                BENEFIT = position.BENEFIT,
                NAME = position.NAME,
                NOTE = position.NOTE,
                RANK = position.RANK
            });
        }
        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] Position request)
        {
            if (!ModelState.IsValid)
                return View(request);
            var position = await _context.Positions.FindAsync(request.ID);
            if (position == null) return BadRequest();

            position.POSITION_CD = request.POSITION_CD;
            position.DESC = request.DESC;
            position.DEPT_CD = request.DEPT_CD;
            position.JOB_TYPE_DESC = request.JOB_TYPE_DESC;
            position.CREATED_DATE = request.CREATED_DATE;
            position.JOB_REQUIRED = request.JOB_REQUIRED;
            position.CREATED_BY = request.CREATED_BY;
            position.MODIFIED_BY = request.MODIFIED_BY;
            position.MODIFIED_DATE = request.MODIFIED_DATE;
            position.BENEFIT = request.BENEFIT;
            position.NAME = request.NAME;
            position.NOTE = request.NOTE;
            position.RANK = request.RANK;
            _context.Positions.Update(position);
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View(request);
        }
    }
}
