using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;
using MvcCreditApp1.Models;

namespace MvcCreditApp1.Controllers
{
    public class BidsController : Controller
    {
        private CreditContext db = new CreditContext();


        // GET: Bids
        public IActionResult Index()
        {
            return View(db.Bids.ToList());
        }

        // GET: Bids/Details/5
        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bid = db.Bids
                .FirstOrDefault(m => m.BidId == id);
            if (bid == null)
            {
                return NotFound();
            }

            return View(bid);
        }

        // GET: Bids/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bids/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("BidId,Name,CreditHead,bidDate")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(bid);
        }

        // GET: Bids/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bid = db.Bids.Find(id);
            if (bid == null)
            {
                return NotFound();
            }
            return View(bid);
        }

        // POST: Bids/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("BidId,Name,CreditHead,bidDate")] Bid bid)
        {
            if (id != bid.BidId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var bidInDb = db.Bids.FirstOrDefault(b => b.BidId == id);
                    if (bidInDb != null)
                    {
                        bidInDb.CreditHead = bid.CreditHead;
                        bidInDb.Name = bid.Name;
                        bidInDb.bidDate = bid.bidDate;

                        // Сохраняем изменения в базе данных
                        db.SaveChanges();
                    }
                    
                }
                catch (Exception ex)
                {
                    if (!BidExists(bid.BidId))
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
            return View(bid);
        }

        // GET: Bids/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bid = db.Bids.FirstOrDefault(m => m.BidId == id);
            if (bid == null)
            {
                return NotFound();
            }

            return View(bid);
        }

        // POST: Bids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var bid =  db.Bids.First(bid => bid.BidId == id);
            if (bid != null)
            {
                db.Bids.Remove(bid);
            }

             db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool BidExists(int id)
        {
            return db.Bids.Any(e => e.BidId == id);
        }
    }
}
