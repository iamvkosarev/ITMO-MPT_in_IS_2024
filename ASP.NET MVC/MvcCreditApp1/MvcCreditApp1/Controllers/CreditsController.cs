using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcCreditApp1.Models;

namespace MvcCreditApp1.Controllers
{
    [Authorize]
    public class CreditsController : Controller
    {

        private CreditContext db = new CreditContext();

        // GET: Credits
        public IActionResult Index()
        {
            return View(db.Credits.ToList());
        }

        // GET: Credits/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit =  db.Credits
                .FirstOrDefault(m => m.CreditId == id);
            if (credit == null)
            {
                return NotFound();
            }

            return View(credit);
        }

        // GET: Credits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Credits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CreditId,Head,Period,Sum,Procent")] Credit credit)
        {
            if (ModelState.IsValid)
            {
                db.Credits.Add(credit);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(credit);
        }

        // GET: Credits/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit = db.Credits.Find(id);
            if (credit == null)
            {
                return NotFound();
            }
            return View(credit);
        }

        // POST: Credits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CreditId,Head,Period,Sum,Procent")] Credit credit)
        {
            if (id != credit.CreditId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var creditInDb = db.Credits.FirstOrDefault(b => b.CreditId == id);
                    if (creditInDb != null)
                    {
                        creditInDb.Procent = credit.Procent;
                        creditInDb.Head = credit.Head;
                        creditInDb.Sum = credit.Sum;
                        creditInDb.Period = credit.Period;

                        // Сохраняем изменения в базе данных
                        db.SaveChanges();
                    }
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreditExists(credit.CreditId))
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
            return View(credit);
        }

        // GET: Credits/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit =  db.Credits
                .FirstOrDefault(m => m.CreditId == id);
            if (credit == null)
            {
                return NotFound();
            }

            return View(credit);
        }

        // POST: Credits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
            var credit =  db.Credits.Find(id);
            if (credit != null)
            {
                db.Credits.Remove(credit);
            }

             db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool CreditExists(int id)
        {
            return db.Credits.Any(e => e.CreditId == id);
        }
    }
}
