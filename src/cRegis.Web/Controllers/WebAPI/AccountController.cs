﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using cRegis.Web.Models;
//using cRegis.Web.Models.ViewModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace cRegis.Web.Controllers.WebAPI
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private readonly SignInManager<StudentUser> _signInManager;

//        public AccountController(SignInManager<StudentUser> _signInManager) 
//        {
//            _signInManager = _signInManager;
//        }

//        public async Task<IActionResult> Index(LoginViewModel model)
//        {
//            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: false, lockoutOnFailure: false);

//            return Content("");
//        }
//    }
//}