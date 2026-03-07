using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFDemo.Models;
using EFDemo.Repositories;
using EFDemo.Services;


namespace EFDemo.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        //public StudentsController(StudentPortalDbContext context)
        //{
        //    _context = context;
        //}

        // GET: Students
        public async Task<IActionResult> Index(string q=null)
        {
            var items = await _service.SearchAsync(q);
            ViewBag.Query = q ?? "";
            return View(items);
            //return View(await _context.Students.ToListAsync());
        }

        // GET: /Students/Search?q=...
        [HttpGet]
        public async Task<IActionResult> Search(string q = null)
        {
            var items = await _service.SearchAsync(q);
            return Json(items);
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _service.GetByIdAsync(id.Value);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,FullName,Email,Phone,Status,JoinDate,CreatedAt")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _service.GetByIdAsync(id.Value);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,FullName,Email,Phone,Status,JoinDate,CreatedAt")] Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(student);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!StudentExists(student.StudentId))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(student);
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            try
            {
                await _service.UpdateAsync(student);
            }
            catch (DbUpdateConcurrencyException)
            {
                var students = await _service.SearchAsync();
                if (!students.Any(s => s.StudentId == student.StudentId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _service.GetByIdAsync(id.Value);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int studentId)
        {
            await _service.DeleteAsync(studentId);
            return RedirectToAction(nameof(Index));
        }

        private Task<bool> StudentExists(int id)
        {
            return _service.StudentExistsAsync(id);
        }
    }
}
