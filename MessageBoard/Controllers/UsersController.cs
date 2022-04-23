using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MessageBoard.Models;

namespace MessageBoard.Controllers {
  public class UsersController : Controller {
    private readonly MessageBoardContext _db;
    public UsersController(MessageBoardContext db) {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Users.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(User user)
    {
      _db.Users.Add(user);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
    User thisUser = _db.Users.FirstOrDefault(user => user.UserId == id);
    // ViewBag.ListOfMessages = _db.Messages.ToList();
    // List<Message> model = _db.Messages.Include(message => message.User).ToList();
    return View(thisUser);
    }
  }
}