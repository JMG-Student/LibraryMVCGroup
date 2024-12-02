﻿using LibraryMVCGroup.DBAccess;
using LibraryMVCGroup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryMVCGroup.Controllers
{
    
    public class BooksController : Controller
    {
        
        private readonly LibraryDBContext _dbContext;

        public BooksController(LibraryDBContext libraryDBContext)
        {
            _dbContext = libraryDBContext;
        }
        public IActionResult Index()
        {
              
          

            return View();
        }

        
    }
}
