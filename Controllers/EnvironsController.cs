using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BallGameMVC.Data;
using BallGameMVC.Models;

namespace BallGameMVC.Controllers
{
    public class EnvironsController : Controller
    {
        private readonly BallGameDBContext _context;

        public EnvironsController(BallGameDBContext context)
        {
            _context = context;
        }

        // GET: Environs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Environs.ToListAsync());
        }

        // GET: Environs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var environ = await _context.Environs
                .FirstOrDefaultAsync(m => m.EnvID == id);
            if (environ == null)
            {
                return NotFound();
            }

            return View(environ);
        }

        // GET: Environs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Environs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnvID,EnvName,EnvLocation,EnvTurfType,EnvRegistrationDate")] Environ environ)
        {
            if (ModelState.IsValid)
            {
                _context.Add(environ);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(environ);
        }

        // GET: Environs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var environ = await _context.Environs.FindAsync(id);
            if (environ == null)
            {
                return NotFound();
            }
            return View(environ);
        }

        // POST: Environs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnvID,EnvName,EnvLocation,EnvTurfType,EnvRegistrationDate")] Environ environ)
        {
            if (id != environ.EnvID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(environ);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnvironExists(environ.EnvID))
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
            return View(environ);
        }

        // GET: Environs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var environ = await _context.Environs
                .FirstOrDefaultAsync(m => m.EnvID == id);
            if (environ == null)
            {
                return NotFound();
            }

            return View(environ);
        }

        // POST: Environs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var environ = await _context.Environs.FindAsync(id);
            _context.Environs.Remove(environ);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnvironExists(int id)
        {
            return _context.Environs.Any(e => e.EnvID == id);
        }
    }
}
