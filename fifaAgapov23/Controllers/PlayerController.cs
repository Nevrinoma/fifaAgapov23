using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using fifaAgapov23.Models;
using System.Linq;
using YourApp.Data;

public class PlayerController : Controller
{
    private readonly ApplicationDbContext _context;

    public PlayerController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Create()
    {
        ViewBag.Teams = new SelectList(_context.Teams, "Id", "Name");
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Player player)
    {
        if (ModelState.IsValid)
        {
            _context.Add(player);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index)); 
        }
        ViewBag.Teams = new SelectList(_context.Teams, "Id", "Name", player.TeamId);
        return View(player);
    }
}
