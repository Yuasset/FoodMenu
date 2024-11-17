using BLL.Services.Abstracts;
using DAL.Models.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMenuServiceManager menuServiceManager;
        private readonly IFoodServiceManager foodServiceManager;
        private readonly IMenuItemServiceManager menuItemServiceManager;
        private readonly ICategoryServiceManager categoryServiceManager;

        public HomeController(IMenuServiceManager menuServiceManager, IMenuItemServiceManager menuItemServiceManager, IFoodServiceManager foodServiceManager, ICategoryServiceManager categoryServiceManager)
        {
            this.menuServiceManager = menuServiceManager;
            this.menuItemServiceManager = menuItemServiceManager;
            this.foodServiceManager = foodServiceManager;
            this.categoryServiceManager = categoryServiceManager;
        }

        public IActionResult Index()
        {
            var menus = menuServiceManager.GetAll();
            return View(menus);
        }

        public IActionResult Menu(int id)
        {
            var menuItem = menuItemServiceManager.GetMenuItems(id);
            List<Food> food = new List<Food>();
            foreach (var item in menuItem)
            {
                food.Add(foodServiceManager.GetAll().Where(x => x.ID == item.FoodID).First());
            }

            return View(food);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            var category = categoryServiceManager.GetAll();
            ViewData["category"] = category;
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            categoryServiceManager.CreateAsync(category);
            return RedirectToAction("CategoryAdd");
        }

        public IActionResult CategoryDelete(int id)
        {
            var category = categoryServiceManager.GetByID(id);
            categoryServiceManager.DeleteAsync(category);
            return RedirectToAction("CategoryAdd");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult MenuUpdate(int id)
        {
            var menuItem = menuItemServiceManager.GetAll().Where(x => x.MenuID == id).ToList();
            ViewData["menuItem"] = menuItem;
            var food = foodServiceManager.GetAll();
            ViewBag.Items = new SelectList(food, "ID", "Name");
            return View(menuItem);
        }
        [HttpPost]
        public IActionResult MenuUpdate(List<MenuItem> menuItem)
        {
            if (menuItem != null)
            {
                foreach (var item in menuItem)
                {
                    var data = menuItemServiceManager.GetByID(item.ID);
                    if (data != null)
                    {
                        data.FoodID = item.FoodID;
                        menuItemServiceManager.UpdateAsync(data);

                    }
                }
            }
            return RedirectToAction("MenuUpdate");
        }

    }
}
