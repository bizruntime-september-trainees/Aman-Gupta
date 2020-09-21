using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCPROJECTDEMO4.Models;

namespace MVCPROJECTDEMO4.Controllers
{
    public class EmployeeTablesController : Controller
    {
        private readonly BizRunTimeEmployeeContext _context;

        public EmployeeTablesController(BizRunTimeEmployeeContext context)
        {
            _context = context;
        }

        // GET: EmployeeTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeTable.ToListAsync());
        }

        // GET: EmployeeTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTable = await _context.EmployeeTable
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeTable == null)
            {
                return NotFound();
            }

            return View(employeeTable);
        }

        // GET: EmployeeTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeName,EmployeeProfile,Employeelevel,EmployeeId")] EmployeeTable employeeTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeTable);
        }

        // GET: EmployeeTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTable = await _context.EmployeeTable.FindAsync(id);
            if (employeeTable == null)
            {
                return NotFound();
            }
            return View(employeeTable);
        }

        // POST: EmployeeTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeName,EmployeeProfile,Employeelevel,EmployeeId")] EmployeeTable employeeTable)
        {
            if (id != employeeTable.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeTableExists(employeeTable.EmployeeId))
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
            return View(employeeTable);
        }

        // GET: EmployeeTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTable = await _context.EmployeeTable
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeTable == null)
            {
                return NotFound();
            }

            return View(employeeTable);
        }

        // POST: EmployeeTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeTable = await _context.EmployeeTable.FindAsync(id);
            _context.EmployeeTable.Remove(employeeTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeTableExists(int id)
        {
            return _context.EmployeeTable.Any(e => e.EmployeeId == id);
        }
    }
}
