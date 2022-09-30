﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Net2.Models;

namespace Net2.Controllers;

public class HomeController : Controller
{
    GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string heSoA, string heSoB)
    {
        string message = gpt.GiaiPhuongTrinhBacNhat(heSoA, heSoB);
        ViewBag.message = message;
        return View();
    }

    public IActionResult GiaiPhuongTrinh()
    {
        return View();
    }
    [HttpPost]
    public IActionResult GiaiPhuongTrinh(string heSoA, string heSoB, string heSoC)
    {
        string message = gpt.GiaiPhuongTrinhBacHai(heSoA, heSoB, heSoC);
        ViewBag.message = message;
        return View();
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
