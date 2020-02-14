﻿using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cReg_WebApp.Models;
using cReg_WebApp.Models.Objects;
using cReg_WebApp.Models.SQL;

namespace cReg_WebApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string StudentID, string Password)
        {
            int id = int.Parse(StudentID);
            DatabaseClient.Initialize();
            Student stu = DatabaseClient.findStudent(id);
            if (stu != null)
            {
                if (stu.password.Equals(Password))
                {
                    string url = string.Format("/home/index?studentId={0}", stu.id);
                    return Redirect(url);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Index()
        {
            DatabaseClient.Initialize();
            if(!String.IsNullOrEmpty(Request.Query["studentId"]))
            {
                Student stu = DatabaseClient.findStudent(int.Parse(Request.Query["studentId"]));
                return View(stu);
            }
            else
            {
                return RedirectToAction("Home", "Login");
            }
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
