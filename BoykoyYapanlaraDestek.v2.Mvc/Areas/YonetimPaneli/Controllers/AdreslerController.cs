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
    public class AdreslerController : Controller
    {
        private readonly BoykoyYapanlaraDestekv2MvcContext _context;

        public AdreslerController(BoykoyYapanlaraDestekv2MvcContext context)
        {
            _context = context;
        }

        // GET: YonetimPaneli/Adresler
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adres.ToListAsync());
        }

        // GET: YonetimPaneli/Adresler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adres = await _context.Adres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adres == null)
            {
                return NotFound();
            }

            return View(adres);
        }

        // GET: YonetimPaneli/Adresler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: YonetimPaneli/Adresler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Adi,Adresi,Il,Ilce,TelefonNumarasi,CocaColaYok,AlgidaYok,MapSrc,Enlem,Boylam,OlusturmaTarihi")] Adres adres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adres);
        }

        // GET: YonetimPaneli/Adresler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adres = await _context.Adres.FindAsync(id);
            if (adres == null)
            {
                return NotFound();
            }
            return View(adres);
        }

        // POST: YonetimPaneli/Adresler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Adi,Adresi,Il,Ilce,TelefonNumarasi,CocaColaYok,AlgidaYok,MapSrc,Enlem,Boylam,OlusturmaTarihi")] Adres adres)
        {
            if (id != adres.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdresExists(adres.Id))
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
            return View(adres);
        }

        // GET: YonetimPaneli/Adresler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adres = await _context.Adres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adres == null)
            {
                return NotFound();
            }

            return View(adres);
        }

        // POST: YonetimPaneli/Adresler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adres = await _context.Adres.FindAsync(id);
            if (adres != null)
            {
                _context.Adres.Remove(adres);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdresExists(int id)
        {
            return _context.Adres.Any(e => e.Id == id);
        }
    }
}
