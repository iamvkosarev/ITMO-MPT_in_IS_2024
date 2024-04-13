using Microsoft.AspNetCore.Mvc;
using MvcCreditApp1.Models;
using System.Data.Entity;
using System.Diagnostics;

namespace MvcCreditApp1.Controllers
{
    public class HomeController : Controller
    {
        private CreditContext db = new CreditContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
    

        public IActionResult Index()
        {
            GiveCredits();
            return View();
        }
        public ActionResult BidSearch(string name)
        {
            var allBids = db.Bids.Where(a =>
           a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("��������� ������ " + name + " �� ������");
                //return HttpNotFound();
            }
            return PartialView(allBids);
        }


        [HttpGet]
        public ActionResult CreateBid()
        {
            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }
        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // ��������� ����� ������ � ��
            db.Bids.Add(newBid);
            // ��������� � �� ��� ���������
            db.SaveChanges();
            return "�������, <b>" + newBid.Name + "</b>, �� ����� ������ �����. ���� ������ ����� ����������� � ������� 10 ����.";
        }

        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
