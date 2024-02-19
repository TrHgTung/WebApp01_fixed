using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApp01.Models;
using WebApp01.Repository;

namespace WebApp01.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class StatController : Controller
    {
      

        //private readonly DataContext _dataContext;
        //private readonly IWebHostEnvironment _webHostEnvironment;
        //public StatController(DataContext context)
        //{
        //    _dataContext = context;
        //    //_webHostEnvironment = webHostEnvironment;
        //}
        public IActionResult Index()
        {
            Models.ProductModel model;
           //int count = model.Count;
            return View();
        }
        
    }
}
