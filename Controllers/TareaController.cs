using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GestionTareas.Models;
using GestionTareas.Data;
using Microsoft.AspNetCore.Authorization;

namespace GestionTareas.Controllers;

[Authorize]

public class TareaController : Controller
{
    private readonly ILogger<TareaController> _logger;
    private readonly ApplicationDbContext _context;

    public TareaController(ApplicationDbContext context, ILogger<TareaController> logger)
    {   
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}