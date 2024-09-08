using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BoykoyYapanlaraDestek.v2.Mvc.Data;
using BoykoyYapanlaraDestek.v2.Mvc.Models;

namespace BoykoyYapanlaraDestek.v2.Mvc.Areas.YonetimPaneli.Controllers
{
    [Area("YonetimPaneli")]
    public class DuyurularController : Controller
    {
        private readonly BoykoyYapanlaraDestekv2MvcContext _context;

        public DuyurularController(BoykoyYapanlaraDestekv2MvcContext context)
        {
            _context = context;
        }

        // GET: YonetimPaneli/Duyurular
        public async Task<IActionResult> Index()
        {
            return View(await _context.Duyuru.ToListAsync());
        }

        // GET: YonetimPaneli/Duyurular/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duyuru = await _context.Duyuru
                .FirstOrDefaultAsync(m => m.Id == id);
            if (duyuru == null)
            {
                return NotFound();
            }

            return View(duyuru);
        }

        // GET: YonetimPaneli/Duyurular/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: YonetimPaneli/Duyurular/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DuyuruMetni,OlusturmaTarihi")] Duyuru duyuru)
        {
            if (ModelState.IsValid)
            {
                _context.Add(duyuru);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(duyuru);
        }

        // GET: YonetimPaneli/Duyurular/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duyuru = await _context.Duyuru.FindAsync(id);
            if (duyuru == null)
            {
                return NotFound();
            }
            return View(duyuru);
        }

        // POST: YonetimPaneli/Duyurular/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DuyuruMetni,OlusturmaTarihi")] Duyuru duyuru)
        {
            if (id != duyuru.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duyuru);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DuyuruExists(duyuru.Id))
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
            return View(duyuru);
        }

        // GET: YonetimPaneli/Duyurular/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duyuru = await _context.Duyuru
                .FirstOrDefaultAsync(m => m.Id == id);
            if (duyuru == null)
            {
                return NotFound();
            }

            return View(duyuru);
        }

        // POST: YonetimPaneli/Duyurular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var duyuru = await _context.Duyuru.FindAsync(id);
            if (duyuru != null)
            {
                _context.Duyuru.Remove(duyuru);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DuyuruExists(int id)
        {
            return _context.Duyuru.Any(e => e.Id == id);
        }
    }
}
