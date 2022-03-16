using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MessageBoard.Models;

namespace MessageBoard.Controllers {
  public class RoomsController : Controller {
    private readonly MessageBoardContext _db;
    public RoomsController(MessageBoardContext db) {
      _db = db;
    }

    public ActionResult Index () {
      List<Room> model = _db.Rooms.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }


    [HttpPost]
    public ActionResult Create(Room room)
    {
      _db.Rooms.Add(room);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Room thisRoom = _db.Rooms.FirstOrDefault(room => room.RoomId == id);
      ViewBag.UserId = new SelectList (_db.Users, "UserId", "UserName");
      return View(thisRoom);
    }
  }
}
