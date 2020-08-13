
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model.ViewModel;
using Presentation.Extensions;
using Presentation.Models;
using Services.Interface;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly string CartSession = "CartSession";

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var res = _productService.GetAll(10, 1);
            return View(res);
        }
        public IActionResult GetAllProduct(int pageSize, int page = 2)
        {
            var res = _productService.GetAll(pageSize, page);

            return new OkObjectResult(res);
        }
        public IActionResult Cart()
        {
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CartSession);
            if(session != null)
            {
                return View(session);
            }
            return View(new List<ShoppingCartViewModel>());
            
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            //Get product detail
            var product = _productService.GetById(productId);

            //Get session with item list from cart
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CartSession);
            if (session != null)
            {
                //Convert string to list object
                bool hasChanged = false; // gắn cờ

                //Check exist with item product id
                if (session.Any(x => x.Product.Id == productId)) // chheck xem có sp chưa
                {
                    foreach (var item in session)
                    {
                        //Update quantity for product if match product id
                        if (item.Product.Id == productId)
                        {
                            item.Quantity += quantity; // nếu có rồi tăng sl lên 1
                            hasChanged = true;
                        }
                    }
                }
                else
                {
                    session.Add(new ShoppingCartViewModel()
                    {
                        Product = product,
                        Quantity = quantity,
                    });
                    hasChanged = true;
                }

                //Update back to cart
                if (hasChanged == true)
                {
                    HttpContext.Session.Set(CartSession, session);
                }
            }
            else
            {
                //Add new cart
                var cart = new List<ShoppingCartViewModel>();
                cart.Add(new ShoppingCartViewModel()
                {
                    Product = product,
                    Quantity = quantity,
                });
                HttpContext.Session.Set(CartSession, cart);
            }
            return new OkObjectResult(session);
        }
        public IActionResult RemoveFromCart(int productId)
        {
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CartSession);
            if (session != null)
            {
                bool hasChanged = false; // gắn cờ
                foreach (var item in session)
                {
                    if (item.Product.Id == productId)
                    {
                        session.Remove(item);
                        hasChanged = true;
                        break;
                    }
                }
                if (hasChanged == true)
                {
                    HttpContext.Session.Set(CartSession, session);
                }
                return new OkObjectResult(productId);
            }
            return new EmptyResult();
        }
        public IActionResult ClearCart()
        {
            // remove session hiện tại
            HttpContext.Session.Remove(CartSession);
            return new OkObjectResult("OK");
        }
    }
}