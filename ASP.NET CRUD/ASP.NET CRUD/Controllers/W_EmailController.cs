using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_CRUD.Contexts;
using ASP.NET_CRUD.Models;

namespace ASP.NET_CRUD.Controllers
{
    public class W_EmailController : Controller
    {
        private readonly GameStoreContext _context;

        public W_EmailController(GameStoreContext context)
        {
            _context = context;
        }

        // GET: W_Email
        public async Task<IActionResult> Index()
        {
            return View(await _context.W_Email.ToListAsync());
        }

        // GET: W_Email/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var w_Email = await _context.W_Email
                .FirstOrDefaultAsync(m => m.ID == id);
            if (w_Email == null)
            {
                return NotFound();
            }

            return View(w_Email);
        }

        // GET: W_Email/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: W_Email/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CreateDate,EmailAddress")] W_Email w_Email)
        {
            if (ModelState.IsValid)
            {
                _context.Add(w_Email);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(w_Email);
        }

        // GET: W_Email/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var w_Email = await _context.W_Email.FindAsync(id);
            if (w_Email == null)
            {
                return NotFound();
            }
            return View(w_Email);
        }

        // POST: W_Email/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,CreateDate,EmailAddress")] W_Email w_Email)
        {
            if (id != w_Email.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(w_Email);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!W_EmailExists(w_Email.ID))
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
            return View(w_Email);
        }

        // GET: W_Email/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var w_Email = await _context.W_Email
                .FirstOrDefaultAsync(m => m.ID == id);
            if (w_Email == null)
            {
                return NotFound();
            }

            return View(w_Email);
        }

        // POST: W_Email/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var w_Email = await _context.W_Email.FindAsync(id);
            _context.W_Email.Remove(w_Email);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool W_EmailExists(string id)
        {
            return _context.W_Email.Any(e => e.ID == id);
        }
    }
}
