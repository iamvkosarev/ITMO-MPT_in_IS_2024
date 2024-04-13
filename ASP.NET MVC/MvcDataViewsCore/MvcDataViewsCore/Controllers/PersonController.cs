using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcDataViewsCore.Model;

namespace MvcDataViewsCore.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> people = new List<Person>();

        // GET: PersonController
        public ActionResult Index()
        {
            return View(people);
        }

        // GET: PersonController/Details/
        public ActionResult Details(Person p)
        {
            return View(p);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        public ActionResult Create(Person p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", p);
                }
                people.Add(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            Person p = new Person();
            foreach (Person pn in people)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;
                }
            }
            return View(p);
        }


        // POST: PersonController/Delete/5
        [HttpPost]
        public ActionResult Delete(Person p)
        {
            try
            {
                // TODO: Add delete logic here
                foreach (Person pn in people)
                {
                    if (pn.Id == p.Id)
                    {
                        people.Remove(pn);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }
        }


        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            Person p = new Person();
            foreach (Person pn in people)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Age = pn.Age;
                    p.Id = pn.Id;
                    p.Phone = pn.Phone;
                    p.Email = pn.Email;
                }
            }
            return View(p);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        public ActionResult Edit(Person p)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", p);
            }
            foreach (Person pn in people)
            {
                if (pn.Id == p.Id)
                {
                    pn.Name = p.Name;
                    pn.Age = p.Age;
                    pn.Id = p.Id;
                    pn.Phone = p.Phone;
                    pn.Email = p.Email;
                }
            }
            return RedirectToAction("Index");
        }

    }
}
