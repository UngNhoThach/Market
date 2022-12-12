using Market.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Market.Controllers
{
    public class ProductController : Controller
    {
        private readonly treeShopContext _treeShop;
        public ProductController(treeShopContext treeShop)
        {
            _treeShop = treeShop;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var product = _treeShop.Products.Include(x => x.CartId).FirstOrDefault(x => x.ProductId == id);
            if(product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
