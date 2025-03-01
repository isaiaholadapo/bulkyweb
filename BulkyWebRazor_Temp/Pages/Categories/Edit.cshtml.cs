using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;

namespace BulkyWebRazor_Temp.Pages.Categories;

[BindProperties]
public class Edit : PageModel
{
    private readonly ApplicationDbContext _db;
    public Category Category { get; set; }
    public Edit(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int? id)
    {
        if (id != null && id != 0)
        {
            Category? category = _db.Categories.Find(id);
            if (category == null)
            {
                return;
            }
            Category = category;
        }
       
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Categories.Update(Category);
            _db.SaveChanges();
            TempData["success"] = "Category updated successfully";
            return RedirectToPage("Index");
        } 
        return Page();
    }
    
    
}