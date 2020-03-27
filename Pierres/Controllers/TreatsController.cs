using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pierres.Models;

namespace Pierres.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierresContext _db;

    public TreatsController(PierresContext db)
    {
        _db = db;
    }

    public ActionResult Index(string searchString)
    {
      var model = _db.Treats.ToList();

      // if (!String.IsNullOrEmpty(searchString))
      // {
      //     model = model.Where(m => m.Name.Contains(searchString) || m.Name.Contains(searchString));
      // }
      return View(model.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
        _db.Treats.Add(treat);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisTreat = _db.Treats
            .Include(treat => treat.Flavors)
            .ThenInclude(join => join.Flavor)
            .FirstOrDefault(treat => treat.TreatId == id);
        return View(thisTreat);
    }

    public ActionResult Delete(int id)
    {
        var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
        return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
        _db.Treats.Remove(thisTreat);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}