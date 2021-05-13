using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.data.interfaces;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class MotosController : Controller
    {
        private readonly IAllMotos _allMotos;
        private readonly IMotosCategory _allCategory;

        public MotosController(IAllMotos iallMotos, IMotosCategory iMotoCat)
        {
            _allMotos = iallMotos;
            _allCategory = iMotoCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "страница с мотоциклами";
            MotosListViewModel obj = new MotosListViewModel();
            obj.allMotos = _allMotos.Motos;
            obj.currCategory = "Мотоциклы";
            return View(obj);
        }

    }
}
