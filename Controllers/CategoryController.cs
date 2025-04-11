using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
  private readonly ApplicationDbContext _dbContext;

  public CategoryController(ApplicationDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public IActionResult Index()
  {
    List<Category> objectCategoryList = _dbContext.Categories.ToList();
    return View(objectCategoryList);
  }
}