using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.data.interfaces;
using WebApplication4.data.models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllMotos _motoRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllMotos motoRep, ShopCart shopCart)
        {
            _motoRep = motoRep;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _motoRep.Motos.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
                }
    }
}
